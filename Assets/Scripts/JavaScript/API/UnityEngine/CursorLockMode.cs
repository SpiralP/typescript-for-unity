using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCursorLockMode {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue CursorLockModePrototype;
      JavaScriptValue CursorLockModeConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.CursorLockMode),
        (args) => { throw new System.NotImplementedException(); },
        out CursorLockModePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("CursorLockMode", CursorLockModeConstructor);


      // Static Fields

      CursorLockModeConstructor.SetProperty(
        "None",
        Bridge.CreateExternalWithPrototype(UnityEngine.CursorLockMode.None)
      );


      CursorLockModeConstructor.SetProperty(
        "Locked",
        Bridge.CreateExternalWithPrototype(UnityEngine.CursorLockMode.Locked)
      );


      CursorLockModeConstructor.SetProperty(
        "Confined",
        Bridge.CreateExternalWithPrototype(UnityEngine.CursorLockMode.Confined)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
