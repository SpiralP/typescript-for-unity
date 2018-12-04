using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCollisionFlags {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue CollisionFlagsPrototype;
      JavaScriptValue CollisionFlagsConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.CollisionFlags),
        (args) => { throw new System.NotImplementedException(); },
        out CollisionFlagsPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("CollisionFlags", CollisionFlagsConstructor);


      // Static Fields

      CollisionFlagsConstructor.SetProperty(
        "None",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionFlags.None)
      );


      CollisionFlagsConstructor.SetProperty(
        "Sides",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionFlags.Sides)
      );


      CollisionFlagsConstructor.SetProperty(
        "Above",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionFlags.Above)
      );


      CollisionFlagsConstructor.SetProperty(
        "Below",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionFlags.Below)
      );


      CollisionFlagsConstructor.SetProperty(
        "CollidedSides",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionFlags.CollidedSides)
      );


      CollisionFlagsConstructor.SetProperty(
        "CollidedAbove",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionFlags.CollidedAbove)
      );


      CollisionFlagsConstructor.SetProperty(
        "CollidedBelow",
        Bridge.CreateExternalWithPrototype(UnityEngine.CollisionFlags.CollidedBelow)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
