using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSResources {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ResourcesPrototype;
      JavaScriptValue ResourcesConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Resources),
        (args) => { throw new System.NotImplementedException(); },
        out ResourcesPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Resources", ResourcesConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      ResourcesConstructor.SetProperty(
        "FindObjectsOfTypeAll",
        Bridge.CreateFunction(
          "FindObjectsOfTypeAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.FindObjectsOfTypeAll(Bridge.GetExternal<System.Type>(args[1])))
        )
      );


      /*
        Resources FindObjectsOfTypeAll
        method has generics
      */


      ResourcesConstructor.SetProperty(
        "Load",
        Bridge.CreateFunction(
          "Load",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.Load(args[1].ToString()))
        )
      );


      /*
        Resources Load
        method has generics
      */


      ResourcesConstructor.SetProperty(
        "Load",
        Bridge.CreateFunction(
          "Load",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.Load(args[1].ToString(), Bridge.GetExternal<System.Type>(args[2])))
        )
      );


      ResourcesConstructor.SetProperty(
        "LoadAsync",
        Bridge.CreateFunction(
          "LoadAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.LoadAsync(args[1].ToString()))
        )
      );


      /*
        Resources LoadAsync
        method has generics
      */


      ResourcesConstructor.SetProperty(
        "LoadAsync",
        Bridge.CreateFunction(
          "LoadAsync",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.LoadAsync(args[1].ToString(), Bridge.GetExternal<System.Type>(args[2])))
        )
      );


      ResourcesConstructor.SetProperty(
        "LoadAll",
        Bridge.CreateFunction(
          "LoadAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.LoadAll(args[1].ToString(), Bridge.GetExternal<System.Type>(args[2])))
        )
      );


      ResourcesConstructor.SetProperty(
        "LoadAll",
        Bridge.CreateFunction(
          "LoadAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.LoadAll(args[1].ToString()))
        )
      );


      /*
        Resources LoadAll
        method has generics
      */


      ResourcesConstructor.SetProperty(
        "GetBuiltinResource",
        Bridge.CreateFunction(
          "GetBuiltinResource",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.GetBuiltinResource(Bridge.GetExternal<System.Type>(args[1]), args[2].ToString()))
        )
      );


      /*
        Resources GetBuiltinResource
        method has generics
      */


      ResourcesConstructor.SetProperty(
        "UnloadAsset",
        Bridge.CreateFunction(
          "UnloadAsset",
          (args) => UnityEngine.Resources.UnloadAsset(Bridge.GetExternal<UnityEngine.Object>(args[1]))
        )
      );


      ResourcesConstructor.SetProperty(
        "UnloadUnusedAssets",
        Bridge.CreateFunction(
          "UnloadUnusedAssets",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Resources.UnloadUnusedAssets())
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
