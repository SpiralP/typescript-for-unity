using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSAssetBundleRequest {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue AssetBundleRequestPrototype;
      JavaScriptValue AssetBundleRequestConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.AssetBundleRequest),
        (args) => { throw new System.NotImplementedException(); },
        out AssetBundleRequestPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("AssetBundleRequest", AssetBundleRequestConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        AssetBundleRequestPrototype,
        "asset",
        Bridge.WithExternal<UnityEngine.AssetBundleRequest>((o, args) => Bridge.CreateExternalWithPrototype(o.asset))
      );


      Bridge.DefineGetter(
        AssetBundleRequestPrototype,
        "allAssets",
        Bridge.WithExternal<UnityEngine.AssetBundleRequest>((o, args) => Bridge.CreateExternalWithPrototype(o.allAssets))
      );


      // Instance Methods

    }
  }
}
