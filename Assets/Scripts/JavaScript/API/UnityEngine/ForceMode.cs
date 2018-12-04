using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSForceMode {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ForceModePrototype;
      JavaScriptValue ForceModeConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.ForceMode),
        (args) => { throw new System.NotImplementedException(); },
        out ForceModePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("ForceMode", ForceModeConstructor);


      // Static Fields

      ForceModeConstructor.SetProperty(
        "Force",
        Bridge.CreateExternalWithPrototype(UnityEngine.ForceMode.Force)
      );


      ForceModeConstructor.SetProperty(
        "Acceleration",
        Bridge.CreateExternalWithPrototype(UnityEngine.ForceMode.Acceleration)
      );


      ForceModeConstructor.SetProperty(
        "Impulse",
        Bridge.CreateExternalWithPrototype(UnityEngine.ForceMode.Impulse)
      );


      ForceModeConstructor.SetProperty(
        "VelocityChange",
        Bridge.CreateExternalWithPrototype(UnityEngine.ForceMode.VelocityChange)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
