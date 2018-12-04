using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSAsyncOperation {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue AsyncOperationPrototype;
      JavaScriptValue AsyncOperationConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.AsyncOperation),
        (args) => { throw new System.NotImplementedException(); },
        out AsyncOperationPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("AsyncOperation", AsyncOperationConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        AsyncOperationPrototype,
        "isDone",
        Bridge.WithExternal<UnityEngine.AsyncOperation>((o, args) => JavaScriptValue.FromBoolean(o.isDone))
      );


      Bridge.DefineGetter(
        AsyncOperationPrototype,
        "progress",
        Bridge.WithExternal<UnityEngine.AsyncOperation>((o, args) => JavaScriptValue.FromDouble(o.progress))
      );


      Bridge.DefineGetterSetter(
        AsyncOperationPrototype,
        "priority",
        Bridge.WithExternal<UnityEngine.AsyncOperation>((o, args) => JavaScriptValue.FromInt32(o.priority)),
        Bridge.WithExternal<UnityEngine.AsyncOperation>((o, args) => { o.priority = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        AsyncOperationPrototype,
        "allowSceneActivation",
        Bridge.WithExternal<UnityEngine.AsyncOperation>((o, args) => JavaScriptValue.FromBoolean(o.allowSceneActivation)),
        Bridge.WithExternal<UnityEngine.AsyncOperation>((o, args) => { o.allowSceneActivation = args[1].ToBoolean(); })
      );


      // Instance Methods

    }
  }
}
