using System;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;

// TODO extends class

// TODO #if UNITY_EDITOR #else #endif

#if UNITY_EDITOR
namespace JavaScript {
  public class JSTypeScriptGenerator {
    private static string fileSaveDir = Application.dataPath + "/Scripts/Javascript/API/.Generated/";

    [MenuItem("JSClassGenerator/Generate TypeScript Files")]
    private static void UserClickedButton() {

      foreach (var classType in new Type[] {
          // Add the types you want to run the generator on here
          // typeof(UnityEngine.Object),
          // typeof(UnityEngine.Collider),
          // typeof(UnityEngine.Color),
          // typeof(UnityEngine.Component),
          // typeof(UnityEngine.GameObject),
          // typeof(UnityEngine.Input),
          // typeof(UnityEngine.Physics),
          // typeof(UnityEngine.Ray),
          // typeof(UnityEngine.Transform),
          // typeof(UnityEngine.Vector2),
          // typeof(UnityEngine.Vector3),
        }) {
        Generate(classType);
      }
    }

    private static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace) {
      return
      assembly.GetTypes()
        .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
        .ToArray();
    }

    private static void Generate(Type classType) {

      // TODO usings/namespace, folder per namespace, file per class
      var folder = $"{fileSaveDir}/";
      if (classType.Namespace != null) {
        folder = $"{fileSaveDir}/{classType.Namespace.Replace(".", "/")}/";
      }
      System.IO.Directory.CreateDirectory(folder);

      var path = $"{folder}/{classType.Name}.d.ts";

      string formattedCode = "";

      var numNamespaces = 0;
      var namespaces = "";
      if (classType.Namespace != null) {
        foreach (var name in classType.Namespace.Split('.')) {
          numNamespaces++;
          namespaces += "namespace " + name + " {\n"; // namespace UnityEngine {
        }
      }

      var namespacesEndings = string.Concat(Enumerable.Repeat("}\n", numNamespaces));

      if (classType.IsEnum) {
        var fields = classType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);
        var enums = "";
        foreach (var field in fields) {
          enums += $"{field.Name},\n";
        }

        /*
        declare namespace UnityEngine {
          namespace Networking {
            class ag {
              thing();
            }
          }
        }
        */


        formattedCode = $@"
          declare {namespaces} enum {classType.Name} {{
              {enums}
            }}
          {namespacesEndings}
        ";
      } else {
        formattedCode = $@"
          declare {namespaces} class {classType.Name} extends System.Object {{
              // Static Fields
              {GenerateStaticFields(classType)}


              // Static Property Accessors
              {GenerateStaticProperties(classType)}


              // Static Methods
              {GenerateStaticMethods(classType)}


              // Instance Fields
              {GenerateInstanceFields(classType)}


              // Instance Property Accessors
              {GenerateInstanceProperties(classType)}


              // Instance Methods
              {GenerateInstanceMethods(classType)}
            }}
          {namespacesEndings}
        ";
      }
      Debug.Log(path + "\n" + formattedCode);
      System.IO.File.WriteAllText(path, formattedCode);
    }


    private static string GenerateInstanceMethods(Type classType) {
      var stringBuilder = new StringBuilder();

      var methods = classType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

      foreach (var method in methods) {
        if (method.IsSpecialName) continue; // Names that begin with or contain an underscore character (_), property accessors, and operator overloading methods
        if (method.GetCustomAttribute(typeof(ObsoleteAttribute)) != null) {
          Debug.Log("skipping obsolete " + method.Name);
          continue;
        }

        stringBuilder.AppendLine(FormatInstanceMethod(classType, method));
      }

      return stringBuilder.ToString();
    }


    private static string FormatInstanceMethod(Type classType, MethodInfo method) {
      var className = classType.Name;
      var methodName = method.Name;

      /* RayPrototype.SetProperty(
        "getPoint",
        Bridge.CreateFunction(WithExternal<Ray>((o, args) => {
          return FromVector3(o.GetPoint((float) args[1].ToDouble()));
        }))
      ); */
      try {
        if (method.GetGenericArguments().Length > 0) throw new Exception("method has generics");

        return $@"
          {(methodName == "ToString" ? "toString" : methodName)}({FormatArgs(method)}): {ToTSType(method.ReturnType)};
        ";
      } catch (Exception e) {
        Debug.LogWarning(classType.Name + "." + method.Name + ": " + e);
        return $@"
          /*
            {classType.Name} {method.Name}
            {e.Message}
          */
        ";
      }
    }


    private static string GenerateInstanceProperties(Type classType) {
      var stringBuilder = new StringBuilder();

      var properties = classType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

      DefaultMemberAttribute weirdAttr = (DefaultMemberAttribute) classType.GetCustomAttribute(typeof(DefaultMemberAttribute));

      foreach (var prop in properties) {
        if (prop.IsSpecialName) continue; // Names that begin with or contain an underscore character (_), property accessors, and operator overloading methods
        if (prop.GetCustomAttribute(typeof(ObsoleteAttribute)) != null) {
          Debug.Log("skipping obsolete " + prop.Name);
          continue;
        }

        if (weirdAttr != null && prop.Name == weirdAttr.MemberName) {
          Debug.Log("skipping weird DefaultMember attribute: " + prop.Name);
          continue; // ???
        }


        stringBuilder.AppendLine(FormatInstanceProperty(classType, prop));
      }

      return stringBuilder.ToString();
    }


    private static string GenerateInstanceFields(Type classType) {
      var stringBuilder = new StringBuilder();

      var fields = classType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

      DefaultMemberAttribute weirdAttr = (DefaultMemberAttribute) classType.GetCustomAttribute(typeof(DefaultMemberAttribute));

      foreach (var field in fields) {
        if (field.IsSpecialName) continue; // Names that begin with or contain an underscore character (_), property accessors, and operator overloading methods
        if (field.GetCustomAttribute(typeof(ObsoleteAttribute)) != null) {
          Debug.Log("skipping obsolete " + field.Name);
          continue;
        }

        if (weirdAttr != null && field.Name == weirdAttr.MemberName) {
          Debug.Log("skipping weird DefaultMember attribute: " + field.Name);
          continue; // ???
        }


        stringBuilder.AppendLine(FormatInstanceField(classType, field));
      }

      return stringBuilder.ToString();
    }


    private static string FormatInstanceField(Type classType, FieldInfo field) {
      var className = classType.Name;
      var propName = field.Name;
      //   DefineGetterSetter(FramePrototype, "xSize",
      //   WithExternal<Frame>((o, args) => JavaScriptValue.FromInt32(o.XSize)),
      //   WithExternal<Frame>((o, args) => { o.XSize = args[1].ToInt32(); })
      // );

      try {
        return $@"
          {propName}: {ToTSType(field.FieldType)};
        ";
      } catch (Exception e) {
        Debug.LogWarning(classType.Name + "." + field.Name + ": " + e);
        return $@"
          /*
            {classType.Name} {field.Name}
            {e.Message}
          */
        ";
      }
    }

    private static string FormatInstanceProperty(Type classType, PropertyInfo prop) {
      var className = classType.Name;
      var propName = prop.Name;
      //   DefineGetterSetter(FramePrototype, "xSize",
      //   WithExternal<Frame>((o, args) => JavaScriptValue.FromInt32(o.XSize)),
      //   WithExternal<Frame>((o, args) => { o.XSize = args[1].ToInt32(); })
      // );

      try {
        if (prop.CanRead && !prop.CanWrite) {
          return $@"
            readonly {propName}: {ToTSType(prop.PropertyType)};
          ";
        } else {
          if (prop.CanWrite) {
            return $@"
              {propName}: {ToTSType(prop.PropertyType)};
            ";
          } else {
            throw new NotImplementedException(); // write but not read
          }
        }
      } catch (Exception e) {
        Debug.LogWarning(classType.Name + "." + prop.Name + ": " + e);
        return $@"
          /*
            {classType.Name} {prop.Name}
            {e.Message}
          */
        ";
      }
    }


    private static string GenerateStaticFields(Type classType) {
      var stringBuilder = new StringBuilder();

      var fields = classType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);

      foreach (var field in fields) {
        if (field.IsSpecialName) continue; // Names that begin with or contain an underscore character (_), property accessors, and operator overloading methods
        if (field.GetCustomAttribute(typeof(ObsoleteAttribute)) != null) {
          Debug.Log("skipping obsolete " + field.Name);
          continue;
        }

        stringBuilder.AppendLine(FormatStaticField(classType, field));
      }

      return stringBuilder.ToString();
    }

    private static string GenerateStaticProperties(Type classType) {
      var stringBuilder = new StringBuilder();

      var properties = classType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);

      foreach (var prop in properties) {
        if (prop.IsSpecialName) continue; // Names that begin with or contain an underscore character (_), property accessors, and operator overloading methods
        if (prop.GetCustomAttribute(typeof(ObsoleteAttribute)) != null) {
          Debug.Log("skipping obsolete " + prop.Name);
          continue;
        }

        stringBuilder.AppendLine(FormatStaticProperty(classType, prop));
      }

      return stringBuilder.ToString();
    }


    private static string FormatStaticField(Type classType, FieldInfo field) {
      var className = classType.Name;
      var propName = field.Name;
      try {
        if (field.IsLiteral) { // const
          return $@"
            static readonly {propName}: {ToTSType(field.FieldType)};
          ";
        } else {
          return $@"
            static {propName}: {ToTSType(field.FieldType)};
          ";
        }
      } catch (Exception e) {
        Debug.LogWarning(classType.Name + "." + field.Name + ": " + e);
        return $@"
          /*
            {classType.Name} {field.Name}
            {e.Message}
          */
        ";
      }
    }

    private static string ToTSType(Type type) {
      if (type.GetGenericArguments().Length > 0) throw new Exception(type + " has generics");

      switch (type.ToString()) {
        case "System.Single": // float
        case "System.Double":
        case "System.Int32": // int
          return "number";
        case "System.String":
          return "string";
        case "System.Boolean":
          return "boolean";
        case "System.Void":
          return "void";

        default:
          // lol @ Replace
          return type.FullName.Replace("+", ".");
      }
    }

    private static string FormatStaticProperty(Type classType, PropertyInfo prop) {
      var className = classType.Name;
      var propName = prop.Name;
      try {
        if (prop.CanRead && !prop.CanWrite) {
          return $@"
              static readonly {propName}: {ToTSType(prop.PropertyType)};
          ";
        } else {
          if (prop.CanWrite) {
            return $@"
              static {propName}: {ToTSType(prop.PropertyType)};
          ";
          } else {
            throw new NotImplementedException(); // write but not read
          }
        }
      } catch (Exception e) {
        Debug.LogWarning(classType.Name + "." + prop.Name + ": " + e);
        return $@"
          /*
            {classType.Name} {prop.Name}
            {e.Message}
          */
        ";
      }
    }

    private static string GenerateStaticMethods(Type classType) {
      var stringBuilder = new StringBuilder();

      var methods = classType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);

      foreach (var method in methods) {
        if (method.IsSpecialName) continue; // Names that begin with or contain an underscore character (_), property accessors, and operator overloading methods
        if (method.GetCustomAttribute(typeof(ObsoleteAttribute)) != null) {
          Debug.Log("skipping obsolete " + method.Name);
          continue;
        }

        stringBuilder.AppendLine(FormatStaticMethod(classType, method));
      }

      return stringBuilder.ToString();
    }

    private static string FormatStaticMethod(Type classType, MethodInfo method) {
      var className = classType.Name;
      var methodName = method.Name;
      try {
        if (method.GetGenericArguments().Length > 0) throw new Exception("method has generics");

        return $@"
          static {methodName}({FormatArgs(method)}): {ToTSType(method.ReturnType)};
        ";
      } catch (Exception e) {
        Debug.LogWarning(classType.Name + "." + method.Name + ": " + e);
        return $@"
          /*
            {classType.Name} {method.Name}
            {e.Message}
          */
        ";
      }
    }


    private static string FormatArgs(MethodInfo method) {
      string args = "";

      var i = 0;
      foreach (var arg in method.GetParameters()) {
        if (i != 0) {
          args += ", ";
        }
        i++;

        if (arg.IsOut) throw new Exception("parameter " + arg.Name + " is out");
        if (arg.IsOptional) throw new Exception("parameter " + arg.Name + " is optional");
        if (arg.ParameterType.IsByRef) throw new Exception("parameter " + arg.Name + " is ref");
        var argType = arg.ParameterType;
        args += $@"{arg.Name}: {ToTSType(argType)}";
      }

      return args;
    }

  }
}
#endif
