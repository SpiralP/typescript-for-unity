using System;
using System.Collections.Generic;
using ChakraCore.API;

namespace JavaScript.Bridging {
  public class ConstructorsAndPrototypes {
    public static Dictionary<string, Type> typeNameToType = new Dictionary<string, Type>();
    public static Dictionary<string, JavaScriptValue> typeNameToPrototype = new Dictionary<string, JavaScriptValue>();

    #region Action

    public static JavaScriptValue CreateConstructor(
      Type type,
      Action<JavaScriptValue[]> action,
      out JavaScriptValue prototype,
      bool dontExtend = false
    ) {

      if (dontExtend) {
        return InternalCreateConstructor(type, action, out prototype);
      } else {
        JavaScriptValue? parentPrototype = FindPrototypeParent(type);
        if (parentPrototype.HasValue) {
          return InternalCreateConstructor(type, action, out prototype, parentPrototype.Value);
        } else {
          throw new Exception("couldn't find parent prototype for " + type);
        }
      }
    }
    private static JavaScriptValue InternalCreateConstructor(
      Type type,
      Action<JavaScriptValue[]> action,
      out JavaScriptValue prototype,
      JavaScriptValue? extends = null
    ) {
      JavaScriptValue constructor = FunctionAllocation.CreateFunction(action);

      prototype = constructor.GetProperty("prototype");
      if (extends.HasValue) {
        prototype.Prototype = extends.Value;
      }

      WireUp(constructor, type, prototype);

      return constructor;
    }

    #endregion

    #region Func

    public static JavaScriptValue CreateConstructor(
      Type type,
      Func<JavaScriptValue[], JavaScriptValue> func,
      out JavaScriptValue prototype,
      bool dontExtend = false
    ) {

      if (dontExtend) {
        return InternalCreateConstructor(type, func, out prototype);
      } else {
        JavaScriptValue? parentPrototype = FindPrototypeParent(type);
        if (parentPrototype.HasValue) {
          return InternalCreateConstructor(type, func, out prototype, parentPrototype.Value);
        } else {
          throw new Exception("couldn't find parent prototype for " + type);
        }
      }
    }
    private static JavaScriptValue InternalCreateConstructor(
      Type type,
      Func<JavaScriptValue[], JavaScriptValue> func,
      out JavaScriptValue prototype,
      JavaScriptValue? extends = null
    ) {
      JavaScriptValue constructor = FunctionAllocation.CreateFunction(func);

      prototype = constructor.GetProperty("prototype");
      if (extends.HasValue) {
        prototype.Prototype = extends.Value;
      }

      WireUp(constructor, type, prototype);

      return constructor;
    }

    #endregion

    private static void WireUp(JavaScriptValue constructor, System.Type type, JavaScriptValue prototype) {
      string name = type.ToString();
      typeNameToType[name] = type;

      // So that we can look up c# types by JS constructors, define a name property containing
      // the full name from type.ToString() that we can take off and put back into stringToType.
      JavaScriptValue propertyDescriptor = JavaScriptValue.CreateObject();
      propertyDescriptor.SetProperty("value", JavaScriptValue.FromString(name));
      constructor.DefineProperty("name", propertyDescriptor);

      typeNameToPrototype[name] = prototype;
    }

    private static JavaScriptValue? FindPrototypeParent(Type type) {
      string found = null;
      Type foundType = null;

      foreach (var pair in typeNameToType) {
        if (type.IsSubclassOf(pair.Value)) {
          if (found != null) {
            if (!pair.Value.IsSubclassOf(foundType)) {
              // for example PicaVoxel.Volume -> MonoBehaviour -> Behaviour -> Component
              // if Behaviour was found last, we check if there is a subclass of Behaviour, like MonoBehaviour
              // if there is then we use it because Volume should have the prototype of MonoBehaviour (which will have the prototype of Behaviour...)
              // if not we skip it:
              continue;
            }
          }
          found = pair.Key;
          foundType = pair.Value;
        }
      }

      if (found != null) {
        return typeNameToPrototype[found];
      } else {
        return null;
      }
    }

    public static System.Type GetType(string typeName) {
      if (!typeNameToType.ContainsKey(typeName)) {
        throw new Exception($"Attempted to retrieve the System.Type for '{typeName}', but no such type was registered with the bridge");
      } else {
        return typeNameToType[typeName];
      }
    }

    public static System.Type GetType(JavaScriptValue constructor) {
      string typeName = constructor.GetProperty("name").ToString();
      return GetType(typeName);
    }

    public static JavaScriptValue GetPrototype(string typeName) {
      if (!typeNameToPrototype.ContainsKey(typeName)) {
        throw new Exception($"Attempted to retrieve the prototype for '{typeName}', but no such type was registered with the bridge");
      } else {
        return typeNameToPrototype[typeName];
      }
    }
  }
}
