using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSObject {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ObjectPrototype;
      JavaScriptValue ObjectConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Object),
        (args) => { throw new System.NotImplementedException(); },
        out ObjectPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Object", ObjectConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      ObjectConstructor.SetProperty(
        "Instantiate",
        Bridge.CreateFunction(
          "Instantiate",
          (args) => {
            switch (args.Length) {
              case 2:
                return Bridge.CreateExternalWithPrototype(UnityEngine.Object.Instantiate(Bridge.GetExternal<UnityEngine.Object>(args[1])));
              case 3:
                return Bridge.CreateExternalWithPrototype(UnityEngine.Object.Instantiate(Bridge.GetExternal<UnityEngine.Object>(args[1]), Bridge.GetExternal<UnityEngine.Transform>(args[2])));
              case 4:
                if (args[3].ValueType == JavaScriptValueType.Boolean)
                  return Bridge.CreateExternalWithPrototype(UnityEngine.Object.Instantiate(Bridge.GetExternal<UnityEngine.Object>(args[1]), Bridge.GetExternal<UnityEngine.Transform>(args[2]), args[3].ToBoolean()));
                else
                  return Bridge.CreateExternalWithPrototype(UnityEngine.Object.Instantiate(Bridge.GetExternal<UnityEngine.Object>(args[1]), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[3]).wrapped));
              case 5:
                return Bridge.CreateExternalWithPrototype(UnityEngine.Object.Instantiate(Bridge.GetExternal<UnityEngine.Object>(args[1]), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.Transform>(args[4])));
              default:
                throw new System.Exception("no such overload");
            }
          }
        )
      );


      /*
        Object Instantiate
        method has generics
      */


      /*
        Object Instantiate
        method has generics
      */


      /*
        Object Instantiate
        method has generics
      */


      /*
        Object Instantiate
        method has generics
      */


      /*
        Object Instantiate
        method has generics
      */


      ObjectConstructor.SetProperty(
        "Destroy",
        Bridge.CreateFunction(
          "Destroy",
          (args) => {
            if (args.Length == 2)
              UnityEngine.Object.Destroy(Bridge.GetExternal<UnityEngine.Object>(args[1]));
            else
              UnityEngine.Object.Destroy(Bridge.GetExternal<UnityEngine.Object>(args[1]), (float) args[2].ToDouble());
          }
        )
      );


      ObjectConstructor.SetProperty(
        "DestroyImmediate",
        Bridge.CreateFunction(
          "DestroyImmediate",
          (args) => {
            if (args.Length == 2)
              UnityEngine.Object.DestroyImmediate(Bridge.GetExternal<UnityEngine.Object>(args[1]));
            else
              UnityEngine.Object.DestroyImmediate(Bridge.GetExternal<UnityEngine.Object>(args[1]), args[2].ToBoolean());
          }
        )
      );


      ObjectConstructor.SetProperty(
        "FindObjectsOfType",
        Bridge.CreateFunction(
          "FindObjectsOfType",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Object.FindObjectsOfType(Bridge.GetExternal<System.Type>(args[1])))
        )
      );


      ObjectConstructor.SetProperty(
        "DontDestroyOnLoad",
        Bridge.CreateFunction(
          "DontDestroyOnLoad",
          (args) => UnityEngine.Object.DontDestroyOnLoad(Bridge.GetExternal<UnityEngine.Object>(args[1]))
        )
      );


      /*
        Object FindObjectsOfType
        method has generics
      */


      /*
        Object FindObjectOfType
        method has generics
      */


      ObjectConstructor.SetProperty(
        "FindObjectOfType",
        Bridge.CreateFunction(
          "FindObjectOfType",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Object.FindObjectOfType(Bridge.GetExternal<System.Type>(args[1])))
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        ObjectPrototype,
        "name",
        Bridge.WithExternal<UnityEngine.Object>((o, args) => JavaScriptValue.FromString(o.name)),
        Bridge.WithExternal<UnityEngine.Object>((o, args) => { o.name = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        ObjectPrototype,
        "hideFlags",
        Bridge.WithExternal<UnityEngine.Object>((o, args) => Bridge.CreateExternalWithPrototype(o.hideFlags)),
        Bridge.WithExternal<UnityEngine.Object>((o, args) => { o.hideFlags = Bridge.GetExternal<UnityEngine.HideFlags>(args[1]); })
      );


      // Instance Methods

      ObjectPrototype.SetProperty(
        "GetInstanceID",
        Bridge.CreateFunction(
          "GetInstanceID",
          Bridge.WithExternal<UnityEngine.Object>((o, args) => JavaScriptValue.FromInt32(o.GetInstanceID()))
        )
      );


      ObjectPrototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithExternal<UnityEngine.Object>((o, args) => JavaScriptValue.FromInt32(o.GetHashCode()))
        )
      );


      ObjectPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithExternal<UnityEngine.Object>((o, args) => JavaScriptValue.FromBoolean(o.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      ObjectPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithExternal<UnityEngine.Object>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


    }
  }
}
