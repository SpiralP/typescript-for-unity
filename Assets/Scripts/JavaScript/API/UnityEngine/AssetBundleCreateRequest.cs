using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSAssetBundleCreateRequest {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue AssetBundleCreateRequestPrototype;
      JavaScriptValue AssetBundleCreateRequestConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.AssetBundleCreateRequest),
        (args) => { throw new System.NotImplementedException(); },
        out AssetBundleCreateRequestPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("AssetBundleCreateRequest", AssetBundleCreateRequestConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        AssetBundleCreateRequestPrototype,
        "assetBundle",
        Bridge.WithExternal<UnityEngine.AssetBundleCreateRequest>((o, args) => Bridge.CreateExternalWithPrototype(o.assetBundle))
      );


      // Instance Methods

    }
  }
}
