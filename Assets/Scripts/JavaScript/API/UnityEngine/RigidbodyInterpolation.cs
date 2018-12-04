using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSRigidbodyInterpolation {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RigidbodyInterpolationPrototype;
      JavaScriptValue RigidbodyInterpolationConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.RigidbodyInterpolation),
        (args) => { throw new System.NotImplementedException(); },
        out RigidbodyInterpolationPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("RigidbodyInterpolation", RigidbodyInterpolationConstructor);


      // Static Fields

      RigidbodyInterpolationConstructor.SetProperty(
        "None",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyInterpolation.None)
      );


      RigidbodyInterpolationConstructor.SetProperty(
        "Interpolate",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyInterpolation.Interpolate)
      );


      RigidbodyInterpolationConstructor.SetProperty(
        "Extrapolate",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyInterpolation.Extrapolate)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
