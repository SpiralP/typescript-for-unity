using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCollisionDetectionMode {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue CollisionDetectionModePrototype;
      JavaScriptValue CollisionDetectionModeConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.CollisionDetectionMode),
        (args) => { throw new System.NotImplementedException(); },
        out CollisionDetectionModePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("CollisionDetectionMode", CollisionDetectionModeConstructor);


      // Static Fields

      CollisionDetectionModeConstructor.SetProperty(
        "Discrete",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionDetectionMode.Discrete)
      );


      CollisionDetectionModeConstructor.SetProperty(
        "Continuous",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionDetectionMode.Continuous)
      );


      CollisionDetectionModeConstructor.SetProperty(
        "ContinuousDynamic",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionDetectionMode.ContinuousDynamic)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
