using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSAssetBundle {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue AssetBundlePrototype;
      JavaScriptValue AssetBundleConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.AssetBundle),
        (args) => { throw new System.NotImplementedException(); },
        out AssetBundlePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("AssetBundle", AssetBundleConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      AssetBundleConstructor.SetProperty(
        "UnloadAllAssetBundles",
        Bridge.CreateFunction(
          "UnloadAllAssetBundles",
          (args) => UnityEngine.AssetBundle.UnloadAllAssetBundles(args[1].ToBoolean())
        )
      );


      AssetBundleConstructor.SetProperty(
        "GetAllLoadedAssetBundles",
        Bridge.CreateFunction(
          "GetAllLoadedAssetBundles",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.GetAllLoadedAssetBundles())
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromFileAsync",
        Bridge.CreateFunction(
          "LoadFromFileAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromFileAsync(args[1].ToString()))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromFileAsync",
        Bridge.CreateFunction(
          "LoadFromFileAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromFileAsync(args[1].ToString(), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromFileAsync",
        Bridge.CreateFunction(
          "LoadFromFileAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromFileAsync(args[1].ToString(), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped, Bridge.GetBoxedExternal<System.UInt64>(args[3]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromFile",
        Bridge.CreateFunction(
          "LoadFromFile",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromFile(args[1].ToString()))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromFile",
        Bridge.CreateFunction(
          "LoadFromFile",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromFile(args[1].ToString(), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromFile",
        Bridge.CreateFunction(
          "LoadFromFile",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromFile(args[1].ToString(), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped, Bridge.GetBoxedExternal<System.UInt64>(args[3]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromMemoryAsync",
        Bridge.CreateFunction(
          "LoadFromMemoryAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromMemoryAsync(Bridge.GetExternal<System.Byte[]>(args[1])))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromMemoryAsync",
        Bridge.CreateFunction(
          "LoadFromMemoryAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromMemoryAsync(Bridge.GetExternal<System.Byte[]>(args[1]), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromMemory",
        Bridge.CreateFunction(
          "LoadFromMemory",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromMemory(Bridge.GetExternal<System.Byte[]>(args[1])))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromMemory",
        Bridge.CreateFunction(
          "LoadFromMemory",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromMemory(Bridge.GetExternal<System.Byte[]>(args[1]), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromStreamAsync",
        Bridge.CreateFunction(
          "LoadFromStreamAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromStreamAsync(Bridge.GetExternal<System.IO.Stream>(args[1]), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped, Bridge.GetBoxedExternal<System.UInt32>(args[3]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromStreamAsync",
        Bridge.CreateFunction(
          "LoadFromStreamAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromStreamAsync(Bridge.GetExternal<System.IO.Stream>(args[1]), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromStreamAsync",
        Bridge.CreateFunction(
          "LoadFromStreamAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromStreamAsync(Bridge.GetExternal<System.IO.Stream>(args[1])))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromStream",
        Bridge.CreateFunction(
          "LoadFromStream",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromStream(Bridge.GetExternal<System.IO.Stream>(args[1]), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped, Bridge.GetBoxedExternal<System.UInt32>(args[3]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromStream",
        Bridge.CreateFunction(
          "LoadFromStream",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromStream(Bridge.GetExternal<System.IO.Stream>(args[1]), Bridge.GetBoxedExternal<System.UInt32>(args[2]).wrapped))
        )
      );


      AssetBundleConstructor.SetProperty(
        "LoadFromStream",
        Bridge.CreateFunction(
          "LoadFromStream",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.AssetBundle.LoadFromStream(Bridge.GetExternal<System.IO.Stream>(args[1])))
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        AssetBundlePrototype,
        "mainAsset",
        Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.mainAsset))
      );


      Bridge.DefineGetter(
        AssetBundlePrototype,
        "isStreamedSceneAssetBundle",
        Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => JavaScriptValue.FromBoolean(o.isStreamedSceneAssetBundle))
      );


      // Instance Methods

      AssetBundlePrototype.SetProperty(
        "Contains",
        Bridge.CreateFunction(
          "Contains",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => JavaScriptValue.FromBoolean(o.Contains(args[1].ToString())))
        )
      );


      AssetBundlePrototype.SetProperty(
        "LoadAsset",
        Bridge.CreateFunction(
          "LoadAsset",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAsset(args[1].ToString())))
        )
      );


      /*
        AssetBundle LoadAsset
        method has generics
      */


      AssetBundlePrototype.SetProperty(
        "LoadAsset",
        Bridge.CreateFunction(
          "LoadAsset",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAsset(args[1].ToString(), Bridge.GetExternal<System.Type>(args[2]))))
        )
      );


      AssetBundlePrototype.SetProperty(
        "LoadAssetAsync",
        Bridge.CreateFunction(
          "LoadAssetAsync",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAssetAsync(args[1].ToString())))
        )
      );


      /*
        AssetBundle LoadAssetAsync
        method has generics
      */


      AssetBundlePrototype.SetProperty(
        "LoadAssetAsync",
        Bridge.CreateFunction(
          "LoadAssetAsync",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAssetAsync(args[1].ToString(), Bridge.GetExternal<System.Type>(args[2]))))
        )
      );


      AssetBundlePrototype.SetProperty(
        "LoadAssetWithSubAssets",
        Bridge.CreateFunction(
          "LoadAssetWithSubAssets",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAssetWithSubAssets(args[1].ToString())))
        )
      );


      /*
        AssetBundle LoadAssetWithSubAssets
        method has generics
      */


      AssetBundlePrototype.SetProperty(
        "LoadAssetWithSubAssets",
        Bridge.CreateFunction(
          "LoadAssetWithSubAssets",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAssetWithSubAssets(args[1].ToString(), Bridge.GetExternal<System.Type>(args[2]))))
        )
      );


      AssetBundlePrototype.SetProperty(
        "LoadAssetWithSubAssetsAsync",
        Bridge.CreateFunction(
          "LoadAssetWithSubAssetsAsync",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAssetWithSubAssetsAsync(args[1].ToString())))
        )
      );


      /*
        AssetBundle LoadAssetWithSubAssetsAsync
        method has generics
      */


      AssetBundlePrototype.SetProperty(
        "LoadAssetWithSubAssetsAsync",
        Bridge.CreateFunction(
          "LoadAssetWithSubAssetsAsync",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAssetWithSubAssetsAsync(args[1].ToString(), Bridge.GetExternal<System.Type>(args[2]))))
        )
      );


      AssetBundlePrototype.SetProperty(
        "LoadAllAssets",
        Bridge.CreateFunction(
          "LoadAllAssets",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAllAssets()))
        )
      );


      /*
        AssetBundle LoadAllAssets
        method has generics
      */


      AssetBundlePrototype.SetProperty(
        "LoadAllAssets",
        Bridge.CreateFunction(
          "LoadAllAssets",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAllAssets(Bridge.GetExternal<System.Type>(args[1]))))
        )
      );


      AssetBundlePrototype.SetProperty(
        "LoadAllAssetsAsync",
        Bridge.CreateFunction(
          "LoadAllAssetsAsync",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAllAssetsAsync()))
        )
      );


      /*
        AssetBundle LoadAllAssetsAsync
        method has generics
      */


      AssetBundlePrototype.SetProperty(
        "LoadAllAssetsAsync",
        Bridge.CreateFunction(
          "LoadAllAssetsAsync",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.LoadAllAssetsAsync(Bridge.GetExternal<System.Type>(args[1]))))
        )
      );


      AssetBundlePrototype.SetProperty(
        "Unload",
        Bridge.CreateFunction(
          "Unload",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => o.Unload(args[1].ToBoolean()))
        )
      );


      AssetBundlePrototype.SetProperty(
        "GetAllAssetNames",
        Bridge.CreateFunction(
          "GetAllAssetNames",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.GetAllAssetNames()))
        )
      );


      AssetBundlePrototype.SetProperty(
        "GetAllScenePaths",
        Bridge.CreateFunction(
          "GetAllScenePaths",
          Bridge.WithExternal<UnityEngine.AssetBundle>((o, args) => Bridge.CreateExternalWithPrototype(o.GetAllScenePaths()))
        )
      );


    }
  }
}
