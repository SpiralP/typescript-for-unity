using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSRigidbodyConstraints {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RigidbodyConstraintsPrototype;
      JavaScriptValue RigidbodyConstraintsConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.RigidbodyConstraints),
        (args) => { throw new System.NotImplementedException(); },
        out RigidbodyConstraintsPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("RigidbodyConstraints", RigidbodyConstraintsConstructor);


      // Static Fields

      RigidbodyConstraintsConstructor.SetProperty(
        "None",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.None)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezePositionX",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezePositionX)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezePositionY",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezePositionY)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezePositionZ",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezePositionZ)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezeRotationX",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezeRotationX)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezeRotationY",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezeRotationY)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezeRotationZ",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezeRotationZ)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezePosition",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezePosition)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezeRotation",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezeRotation)
      );


      RigidbodyConstraintsConstructor.SetProperty(
        "FreezeAll",
        Bridge.CreateExternalWithPrototype(UnityEngine.RigidbodyConstraints.FreezeAll)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
