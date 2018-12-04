using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCoroutine {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue CoroutinePrototype;
      JavaScriptValue CoroutineConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Coroutine),
        (args) => { throw new System.NotImplementedException(); },
        out CoroutinePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Coroutine", CoroutineConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
