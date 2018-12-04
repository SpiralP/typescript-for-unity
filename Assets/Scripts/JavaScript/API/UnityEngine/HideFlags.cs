using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSHideFlags {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue HideFlagsPrototype;
      JavaScriptValue HideFlagsConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.HideFlags),
        (args) => { throw new System.NotImplementedException(); },
        out HideFlagsPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("HideFlags", HideFlagsConstructor);


      // Static Fields

      HideFlagsConstructor.SetProperty(
        "None",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.None)
      );


      HideFlagsConstructor.SetProperty(
        "HideInHierarchy",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.HideInHierarchy)
      );


      HideFlagsConstructor.SetProperty(
        "HideInInspector",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.HideInInspector)
      );


      HideFlagsConstructor.SetProperty(
        "DontSaveInEditor",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.DontSaveInEditor)
      );


      HideFlagsConstructor.SetProperty(
        "NotEditable",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.NotEditable)
      );


      HideFlagsConstructor.SetProperty(
        "DontSaveInBuild",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.DontSaveInBuild)
      );


      HideFlagsConstructor.SetProperty(
        "DontUnloadUnusedAsset",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.DontUnloadUnusedAsset)
      );


      HideFlagsConstructor.SetProperty(
        "DontSave",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.DontSave)
      );


      HideFlagsConstructor.SetProperty(
        "HideAndDontSave",
        Bridge.CreateExternalWithPrototype(UnityEngine.HideFlags.HideAndDontSave)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
