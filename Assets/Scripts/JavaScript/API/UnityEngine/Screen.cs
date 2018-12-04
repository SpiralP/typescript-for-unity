using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSScreen {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ScreenPrototype;
      JavaScriptValue ScreenConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Screen),
        (args) => { throw new System.NotImplementedException(); },
        out ScreenPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Screen", ScreenConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetter(
        ScreenConstructor,
        "width",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Screen.width)
      );


      Bridge.DefineGetter(
        ScreenConstructor,
        "height",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Screen.height)
      );


      Bridge.DefineGetter(
        ScreenConstructor,
        "dpi",
        (args) => JavaScriptValue.FromDouble(UnityEngine.Screen.dpi)
      );


      Bridge.DefineGetterSetter(
        ScreenConstructor,
        "orientation",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Screen.orientation),
        (args) => { UnityEngine.Screen.orientation = Bridge.GetExternal<UnityEngine.ScreenOrientation>(args[1]); }
      );


      Bridge.DefineGetterSetter(
        ScreenConstructor,
        "sleepTimeout",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Screen.sleepTimeout),
        (args) => { UnityEngine.Screen.sleepTimeout = args[1].ToInt32(); }
      );


      Bridge.DefineGetterSetter(
        ScreenConstructor,
        "autorotateToPortrait",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Screen.autorotateToPortrait),
        (args) => { UnityEngine.Screen.autorotateToPortrait = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        ScreenConstructor,
        "autorotateToPortraitUpsideDown",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Screen.autorotateToPortraitUpsideDown),
        (args) => { UnityEngine.Screen.autorotateToPortraitUpsideDown = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        ScreenConstructor,
        "autorotateToLandscapeLeft",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Screen.autorotateToLandscapeLeft),
        (args) => { UnityEngine.Screen.autorotateToLandscapeLeft = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        ScreenConstructor,
        "autorotateToLandscapeRight",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Screen.autorotateToLandscapeRight),
        (args) => { UnityEngine.Screen.autorotateToLandscapeRight = args[1].ToBoolean(); }
      );


      Bridge.DefineGetter(
        ScreenConstructor,
        "currentResolution",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Screen.currentResolution)
      );


      Bridge.DefineGetterSetter(
        ScreenConstructor,
        "fullScreen",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Screen.fullScreen),
        (args) => { UnityEngine.Screen.fullScreen = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        ScreenConstructor,
        "fullScreenMode",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Screen.fullScreenMode),
        (args) => { UnityEngine.Screen.fullScreenMode = Bridge.GetExternal<UnityEngine.FullScreenMode>(args[1]); }
      );


      Bridge.DefineGetter(
        ScreenConstructor,
        "safeArea",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Screen.safeArea)
      );


      Bridge.DefineGetter(
        ScreenConstructor,
        "resolutions",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Screen.resolutions)
      );


      // Static Methods

      ScreenConstructor.SetProperty(
        "SetResolution",
        Bridge.CreateFunction(
          "SetResolution",
          (args) => UnityEngine.Screen.SetResolution(args[1].ToInt32(), args[2].ToInt32(), Bridge.GetExternal<UnityEngine.FullScreenMode>(args[3]), args[4].ToInt32())
        )
      );


      ScreenConstructor.SetProperty(
        "SetResolution",
        Bridge.CreateFunction(
          "SetResolution",
          (args) => UnityEngine.Screen.SetResolution(args[1].ToInt32(), args[2].ToInt32(), Bridge.GetExternal<UnityEngine.FullScreenMode>(args[3]))
        )
      );


      ScreenConstructor.SetProperty(
        "SetResolution",
        Bridge.CreateFunction(
          "SetResolution",
          (args) => UnityEngine.Screen.SetResolution(args[1].ToInt32(), args[2].ToInt32(), args[3].ToBoolean(), args[4].ToInt32())
        )
      );


      ScreenConstructor.SetProperty(
        "SetResolution",
        Bridge.CreateFunction(
          "SetResolution",
          (args) => UnityEngine.Screen.SetResolution(args[1].ToInt32(), args[2].ToInt32(), args[3].ToBoolean())
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
