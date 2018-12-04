using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCharacterController {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue CharacterControllerPrototype;
      JavaScriptValue CharacterControllerConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.CharacterController),
        (args) => { throw new System.NotImplementedException(); },
        out CharacterControllerPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("CharacterController", CharacterControllerConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        CharacterControllerPrototype,
        "velocity",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => Bridge.CreateExternalWithPrototype(o.velocity))
      );


      Bridge.DefineGetter(
        CharacterControllerPrototype,
        "isGrounded",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromBoolean(o.isGrounded))
      );


      Bridge.DefineGetter(
        CharacterControllerPrototype,
        "collisionFlags",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => Bridge.CreateExternalWithPrototype(o.collisionFlags))
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "radius",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromDouble(o.radius)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.radius = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "height",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromDouble(o.height)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.height = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "center",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => Bridge.CreateExternalWithPrototype(o.center)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.center = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "slopeLimit",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromDouble(o.slopeLimit)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.slopeLimit = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "stepOffset",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromDouble(o.stepOffset)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.stepOffset = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "skinWidth",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromDouble(o.skinWidth)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.skinWidth = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "minMoveDistance",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromDouble(o.minMoveDistance)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.minMoveDistance = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "detectCollisions",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromBoolean(o.detectCollisions)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.detectCollisions = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CharacterControllerPrototype,
        "enableOverlapRecovery",
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromBoolean(o.enableOverlapRecovery)),
        Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => { o.enableOverlapRecovery = args[1].ToBoolean(); })
      );


      // Instance Methods

      CharacterControllerPrototype.SetProperty(
        "SimpleMove",
        Bridge.CreateFunction(
          "SimpleMove",
          Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => JavaScriptValue.FromBoolean(o.SimpleMove(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CharacterControllerPrototype.SetProperty(
        "Move",
        Bridge.CreateFunction(
          "Move",
          Bridge.WithExternal<UnityEngine.CharacterController>((o, args) => Bridge.CreateExternalWithPrototype(o.Move(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


    }
  }
}
