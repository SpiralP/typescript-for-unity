using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSResourceRequest {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ResourceRequestPrototype;
      JavaScriptValue ResourceRequestConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.ResourceRequest),
        (args) => { throw new System.NotImplementedException(); },
        out ResourceRequestPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("ResourceRequest", ResourceRequestConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        ResourceRequestPrototype,
        "asset",
        Bridge.WithExternal<UnityEngine.ResourceRequest>((o, args) => Bridge.CreateExternalWithPrototype(o.asset))
      );


      // Instance Methods

    }
  }
}
