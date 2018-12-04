using System;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;

// TODO fields

// TODO #if UNITY_EDITOR #else #endif

#if UNITY_EDITOR
namespace JavaScript {
  public class JSClassGenerator {
    private static string fileSaveDir = Application.dataPath + "/Scripts/JavaScript/API/.Generated/";

    [MenuItem("JSClassGenerator/Generate Class Files")]
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

      var path = $"{folder}/{classType.Name}.cs";

      var getProperties = "";
      if (classType.Namespace != null) {
        foreach (var name in classType.Namespace.Split('.')) {
          getProperties += $"\n.GetProperty(\"{name}\")";
        }
      }

      var Namespace = "JavaScript.API";
      if (classType.Namespace != null) {
        Namespace = $"JavaScript.API.JS{classType.Namespace}";
      }

      string formattedCode = $@"
        using ChakraCore.API;

        namespace {Namespace} {{
          class JS{classType.Name} {{
            public static void Register(JavaScriptContext context) {{
              JavaScriptValue {classType.Name}Prototype;
              JavaScriptValue {classType.Name}Constructor = Bridge.CreateConstructor(
                typeof({fullName(classType)}),
                (args) => {{ throw new System.NotImplementedException(); }},
                out {classType.Name}Prototype
              );
              JavaScriptValue
                .GlobalObject{getProperties}
                .SetProperty(""{classType.Name}"", {classType.Name}Constructor);


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
          }}
        }}
      ";
      Debug.Log(path + "\n" + formattedCode);
      System.IO.File.WriteAllText(path, formattedCode);
    }


    private static string fullName(Type classType) {
      if (classType.Namespace == null) {
        return $"{classType.Name}";
      }
      return $"{classType.Namespace}.{classType.Name}";
    }

    private static string fullName(string namespaceName, string className) {
      if (namespaceName == null) {
        return $"{className}";
      }
      return $"{namespaceName}.{className}";
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
        Bridge.CreateFunction(WithBoxedExternal<Ray>((o, args) => {
          return FromVector3(o.GetPoint((float) args[1].ToDouble()));
        }))
      ); */
      try {
        if (method.GetGenericArguments().Length > 0) throw new Exception("method has generics");

        return $@"
        {className}Prototype.SetProperty(
          ""{(methodName == "ToString" ? "toString" : methodName)}"",
          Bridge.CreateFunction(
            ""{methodName}"",
            Bridge.With{(IsStruct(classType) ? "Boxed" : "")}External<{fullName(classType)}>((o, args) => {FormatJSReturn(null, IsStruct(classType) ? "o.wrapped" : "o", method)})
          )
        );
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
      //   With{(IsStruct(type) ? "Boxed" : "")}External<Frame>((o, args) => JavaScriptValue.FromInt32(o.XSize)),
      //   With{(IsStruct(type) ? "Boxed" : "")}External<Frame>((o, args) => { o.XSize = args[1].ToInt32(); })
      // );

      try {
        return $@"
          Bridge.DefineGetterSetter(
            {className}Prototype,
            ""{propName}"",
            Bridge.With{(IsStruct(classType) ? "Boxed" : "")}External<{fullName(classType)}>((o, args) => {FormatJSGetter(null, IsStruct(classType) ? "o.wrapped" : "o", field.Name, field.FieldType)}),
            Bridge.With{(IsStruct(classType) ? "Boxed" : "")}External<{fullName(classType)}>((o, args) => {{ {FormatJSSetter(null, IsStruct(classType) ? "o.wrapped" : "o", field.Name, field.FieldType)}; }})
          );
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
      //   With{(IsStruct(classType) ? "Boxed" : "")}External<Frame>((o, args) => JavaScriptValue.FromInt32(o.XSize)),
      //   With{(IsStruct(classType) ? "Boxed" : "")}External<Frame>((o, args) => { o.XSize = args[1].ToInt32(); })
      // );

      try {
        if (prop.CanRead && !prop.CanWrite) {
          return $@"
          Bridge.DefineGetter(
            {className}Prototype,
            ""{propName}"",
            Bridge.With{(IsStruct(classType) ? "Boxed" : "")}External<{fullName(classType)}>((o, args) => {FormatJSGetter(null, IsStruct(classType) ? "o.wrapped" : "o", prop.Name, prop.PropertyType)})
          );
        ";
        } else {
          if (prop.CanWrite) {
            return $@"
            Bridge.DefineGetterSetter(
              {className}Prototype,
              ""{propName}"",
              Bridge.With{(IsStruct(classType) ? "Boxed" : "")}External<{fullName(classType)}>((o, args) => {FormatJSGetter(null, IsStruct(classType) ? "o.wrapped" : "o", prop.Name, prop.PropertyType)}),
              Bridge.With{(IsStruct(classType) ? "Boxed" : "")}External<{fullName(classType)}>((o, args) => {{ {FormatJSSetter(null, IsStruct(classType) ? "o.wrapped" : "o", prop.Name, prop.PropertyType)}; }})
            );
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
            {className}Constructor.SetProperty(
              ""{propName}"",
              {FormatJSGetter(classType.Namespace, classType.Name, field.Name, field.FieldType)}
            );
          ";
        } else {
          return $@"
            Bridge.DefineGetterSetter(
              {className}Constructor,
              ""{propName}"",
              (args) => {FormatJSGetter(classType.Namespace, classType.Name, field.Name, field.FieldType)},
              (args) => {{ {FormatJSSetter(classType.Namespace, classType.Name, field.Name, field.FieldType)}; }}
            );
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


    private static string FormatStaticProperty(Type classType, PropertyInfo prop) {
      var className = classType.Name;
      var propName = prop.Name;
      try {
        if (prop.CanRead && !prop.CanWrite) {
          return $@"
            Bridge.DefineGetter(
              {className}Constructor,
              ""{propName}"",
              (args) => {FormatJSGetter(classType.Namespace, classType.Name, prop.Name, prop.PropertyType)}
            );
          ";
        } else {
          if (prop.CanWrite) {
            return $@"
            Bridge.DefineGetterSetter(
              {className}Constructor,
              ""{propName}"",
              (args) => {FormatJSGetter(classType.Namespace, classType.Name, prop.Name, prop.PropertyType)},
              (args) => {{ {FormatJSSetter(classType.Namespace, classType.Name, prop.Name, prop.PropertyType)}; }}
            );
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


    private static string FormatJSGetter(string namespaceName, string className, string propName, Type propType) {
      var jsReturn = ToJSType(propType);
      // (args) => JavaScriptValue.FromBoolean(Input.compensateSensors),
      // JavaScriptValue.FromString(args[1].ToString())
      if (namespaceName == null) {
        return $"{jsReturn}({className}.{propName})";
      } else {
        return $"{jsReturn}({fullName(namespaceName, className)}.{propName})";
      }
    }

    private static string FormatJSSetter(string namespaceName, string className, string propName, Type propType) {
      // (args) => { Input.compensateSensors = args[1].ToBoolean(); }
      if (namespaceName == null) {
        return $"{className}.{propName} = {FromJSType(1, propType)}";
      } else {
        return $"{fullName(namespaceName, className)}.{propName} = {FromJSType(1, propType)}";
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
        {className}Constructor.SetProperty(
          ""{methodName}"",
          Bridge.CreateFunction(
            ""{methodName}"",
            (args) => {FormatJSReturn(classType.Namespace, classType.Name, method)}
          )
        );
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


    private static string FormatJSReturn(string namespaceName, string className, MethodInfo method) {
      var methodCall = FormatCall(namespaceName, className, method);
      var returnType = method.ReturnType;

      var jsReturn = ToJSType(returnType);
      if (jsReturn != null) {
        return $@"{jsReturn}({methodCall})";
      } else {
        return $"{methodCall}"; // can't wrap () => (thisInParens())
      }
    }

    // InputGlobal.SetProperty("getMouseButton", Bridge.CreateFunction("getMouseButton", (args) => JavaScriptValue.FromBoolean(Input.GetMouseButton(args[1].ToInt32()))));

    private static string FormatCall(string namespaceName, string className, MethodInfo method) {
      if (namespaceName == null) {
        return $"{className}.{method.Name}({FormatArgs(method)})";
      } else {
        return $"{fullName(namespaceName, className)}.{method.Name}({FormatArgs(method)})";
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
        args += $@"{FromJSType(i, argType)}";
      }

      return args;
    }


    private static string FromJSType(int argNumber, Type type) {
      if (type.GetGenericArguments().Length > 0) throw new Exception(type + " has generics");

      switch (type.ToString()) {
        case "System.Single": // float
          return $"(float) args[{argNumber}].ToDouble()";
        case "System.Double":
          return $"args[{argNumber}].ToDouble()";
        case "System.String":
          return $"args[{argNumber}].ToString()";
        case "System.Int32": // int
          return $"args[{argNumber}].ToInt32()";
        case "System.Boolean":
          return $"args[{argNumber}].ToBoolean()";

        default:
          // lol @ Replace
          return $"Bridge.Get{(IsStruct(type) ? "Boxed" : "")}External<{type.FullName.Replace("+", ".")}>(args[{argNumber}])" + (IsStruct(type) ? ".wrapped" : "");
      }
    }

    private static bool IsStruct(Type type) {
      return type.IsValueType && !type.IsEnum;
    }

    private static string ToJSType(Type type) {
      switch (type.ToString()) {
        case "System.Single": // float
        case "System.Double":
          return "JavaScriptValue.FromDouble";
        case "System.String":
          return "JavaScriptValue.FromString";
        case "System.Int32": // int
          return "JavaScriptValue.FromInt32";
        case "System.Boolean":
          return "JavaScriptValue.FromBoolean";
        case "System.Void":
          return null;

        default:
          return $"Bridge.CreateExternalWithPrototype";
      }
    }

    private static string NiceType(Type type) {
      string name = type.Name;
      name = name.Replace("[]", "Array");
      return name;
    }

  }
}
#endif
