using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSBehaviour {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue BehaviourPrototype;
      JavaScriptValue BehaviourConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Behaviour),
        (args) => { throw new System.NotImplementedException(); },
        out BehaviourPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Behaviour", BehaviourConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        BehaviourPrototype,
        "enabled",
        Bridge.WithExternal<UnityEngine.Behaviour>((o, args) => JavaScriptValue.FromBoolean(o.enabled)),
        Bridge.WithExternal<UnityEngine.Behaviour>((o, args) => { o.enabled = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        BehaviourPrototype,
        "isActiveAndEnabled",
        Bridge.WithExternal<UnityEngine.Behaviour>((o, args) => JavaScriptValue.FromBoolean(o.isActiveAndEnabled))
      );


      // Instance Methods

    }
  }
}
