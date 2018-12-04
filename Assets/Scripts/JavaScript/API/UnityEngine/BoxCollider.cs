using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSBoxCollider {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue BoxColliderPrototype;
      JavaScriptValue BoxColliderConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.BoxCollider),
        (args) => { throw new System.NotImplementedException(); },
        out BoxColliderPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("BoxCollider", BoxColliderConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        BoxColliderPrototype,
        "center",
        Bridge.WithExternal<UnityEngine.BoxCollider>((o, args) => Bridge.CreateExternalWithPrototype(o.center)),
        Bridge.WithExternal<UnityEngine.BoxCollider>((o, args) => { o.center = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        BoxColliderPrototype,
        "size",
        Bridge.WithExternal<UnityEngine.BoxCollider>((o, args) => Bridge.CreateExternalWithPrototype(o.size)),
        Bridge.WithExternal<UnityEngine.BoxCollider>((o, args) => { o.size = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      // Instance Methods

    }
  }
}
