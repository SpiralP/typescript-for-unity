using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSPrimitiveType {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PrimitiveTypePrototype;
      JavaScriptValue PrimitiveTypeConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.PrimitiveType),
        (args) => { throw new System.NotImplementedException(); },
        out PrimitiveTypePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("PrimitiveType", PrimitiveTypeConstructor);


      // Static Fields

      PrimitiveTypeConstructor.SetProperty(
        "Sphere",
        Bridge.CreateExternalWithPrototype(UnityEngine.PrimitiveType.Sphere)
      );


      PrimitiveTypeConstructor.SetProperty(
        "Capsule",
        Bridge.CreateExternalWithPrototype(UnityEngine.PrimitiveType.Capsule)
      );


      PrimitiveTypeConstructor.SetProperty(
        "Cylinder",
        Bridge.CreateExternalWithPrototype(UnityEngine.PrimitiveType.Cylinder)
      );


      PrimitiveTypeConstructor.SetProperty(
        "Cube",
        Bridge.CreateExternalWithPrototype(UnityEngine.PrimitiveType.Cube)
      );


      PrimitiveTypeConstructor.SetProperty(
        "Plane",
        Bridge.CreateExternalWithPrototype(UnityEngine.PrimitiveType.Plane)
      );


      PrimitiveTypeConstructor.SetProperty(
        "Quad",
        Bridge.CreateExternalWithPrototype(UnityEngine.PrimitiveType.Quad)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
