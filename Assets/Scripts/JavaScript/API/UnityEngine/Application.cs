using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSApplication {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ApplicationPrototype;
      JavaScriptValue ApplicationConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Application),
        (args) => { throw new System.NotImplementedException(); },
        out ApplicationPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Application", ApplicationConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetter(
        ApplicationConstructor,
        "isPlaying",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.isPlaying)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "isFocused",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.isFocused)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "platform",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.platform)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "buildGUID",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.buildGUID)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "isMobilePlatform",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.isMobilePlatform)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "isConsolePlatform",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.isConsolePlatform)
      );


      Bridge.DefineGetterSetter(
        ApplicationConstructor,
        "runInBackground",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.runInBackground),
        (args) => { UnityEngine.Application.runInBackground = args[1].ToBoolean(); }
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "isBatchMode",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.isBatchMode)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "dataPath",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.dataPath)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "streamingAssetsPath",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.streamingAssetsPath)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "persistentDataPath",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.persistentDataPath)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "temporaryCachePath",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.temporaryCachePath)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "absoluteURL",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.absoluteURL)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "unityVersion",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.unityVersion)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "version",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.version)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "installerName",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.installerName)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "identifier",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.identifier)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "installMode",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.installMode)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "sandboxType",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.sandboxType)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "productName",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.productName)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "companyName",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.companyName)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "cloudProjectId",
        (args) => JavaScriptValue.FromString(UnityEngine.Application.cloudProjectId)
      );


      Bridge.DefineGetterSetter(
        ApplicationConstructor,
        "targetFrameRate",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Application.targetFrameRate),
        (args) => { UnityEngine.Application.targetFrameRate = args[1].ToInt32(); }
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "systemLanguage",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.systemLanguage)
      );


      Bridge.DefineGetterSetter(
        ApplicationConstructor,
        "backgroundLoadingPriority",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.backgroundLoadingPriority),
        (args) => { UnityEngine.Application.backgroundLoadingPriority = Bridge.GetExternal<UnityEngine.ThreadPriority>(args[1]); }
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "internetReachability",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.internetReachability)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "genuine",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.genuine)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "genuineCheckAvailable",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.genuineCheckAvailable)
      );


      Bridge.DefineGetter(
        ApplicationConstructor,
        "isEditor",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.isEditor)
      );


      // Static Methods

      ApplicationConstructor.SetProperty(
        "Quit",
        Bridge.CreateFunction(
          "Quit",
          (args) => UnityEngine.Application.Quit()
        )
      );


      ApplicationConstructor.SetProperty(
        "Unload",
        Bridge.CreateFunction(
          "Unload",
          (args) => UnityEngine.Application.Unload()
        )
      );


      ApplicationConstructor.SetProperty(
        "CanStreamedLevelBeLoaded",
        Bridge.CreateFunction(
          "CanStreamedLevelBeLoaded",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.CanStreamedLevelBeLoaded(args[1].ToInt32()))
        )
      );


      ApplicationConstructor.SetProperty(
        "CanStreamedLevelBeLoaded",
        Bridge.CreateFunction(
          "CanStreamedLevelBeLoaded",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.CanStreamedLevelBeLoaded(args[1].ToString()))
        )
      );


      ApplicationConstructor.SetProperty(
        "GetBuildTags",
        Bridge.CreateFunction(
          "GetBuildTags",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.GetBuildTags())
        )
      );


      ApplicationConstructor.SetProperty(
        "SetBuildTags",
        Bridge.CreateFunction(
          "SetBuildTags",
          (args) => UnityEngine.Application.SetBuildTags(Bridge.GetExternal<System.String[]>(args[1]))
        )
      );


      ApplicationConstructor.SetProperty(
        "HasProLicense",
        Bridge.CreateFunction(
          "HasProLicense",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.HasProLicense())
        )
      );


      ApplicationConstructor.SetProperty(
        "RequestAdvertisingIdentifierAsync",
        Bridge.CreateFunction(
          "RequestAdvertisingIdentifierAsync",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.RequestAdvertisingIdentifierAsync(Bridge.GetExternal<UnityEngine.Application.AdvertisingIdentifierCallback>(args[1])))
        )
      );


      ApplicationConstructor.SetProperty(
        "OpenURL",
        Bridge.CreateFunction(
          "OpenURL",
          (args) => UnityEngine.Application.OpenURL(args[1].ToString())
        )
      );


      ApplicationConstructor.SetProperty(
        "GetStackTraceLogType",
        Bridge.CreateFunction(
          "GetStackTraceLogType",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.GetStackTraceLogType(Bridge.GetExternal<UnityEngine.LogType>(args[1])))
        )
      );


      ApplicationConstructor.SetProperty(
        "SetStackTraceLogType",
        Bridge.CreateFunction(
          "SetStackTraceLogType",
          (args) => UnityEngine.Application.SetStackTraceLogType(Bridge.GetExternal<UnityEngine.LogType>(args[1]), Bridge.GetExternal<UnityEngine.StackTraceLogType>(args[2]))
        )
      );


      ApplicationConstructor.SetProperty(
        "RequestUserAuthorization",
        Bridge.CreateFunction(
          "RequestUserAuthorization",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Application.RequestUserAuthorization(Bridge.GetExternal<UnityEngine.UserAuthorization>(args[1])))
        )
      );


      ApplicationConstructor.SetProperty(
        "HasUserAuthorization",
        Bridge.CreateFunction(
          "HasUserAuthorization",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Application.HasUserAuthorization(Bridge.GetExternal<UnityEngine.UserAuthorization>(args[1])))
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
