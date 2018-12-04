using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.EventSystems {
  class JSMoveDirection {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue MoveDirectionPrototype;
      JavaScriptValue MoveDirectionConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.EventSystems.MoveDirection),
        (args) => { throw new NotImplementedException(); },
        out MoveDirectionPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("EventSystems")
        .SetProperty("MoveDirection", MoveDirectionConstructor);


      // Static Fields

      MoveDirectionConstructor.SetProperty(
        "Left",
        Bridge.CreateExternalWithPrototype(UnityEngine.EventSystems.MoveDirection.Left)
      );


      MoveDirectionConstructor.SetProperty(
        "Up",
        Bridge.CreateExternalWithPrototype(UnityEngine.EventSystems.MoveDirection.Up)
      );


      MoveDirectionConstructor.SetProperty(
        "Right",
        Bridge.CreateExternalWithPrototype(UnityEngine.EventSystems.MoveDirection.Right)
      );


      MoveDirectionConstructor.SetProperty(
        "Down",
        Bridge.CreateExternalWithPrototype(UnityEngine.EventSystems.MoveDirection.Down)
      );


      MoveDirectionConstructor.SetProperty(
        "None",
        Bridge.CreateExternalWithPrototype(UnityEngine.EventSystems.MoveDirection.None)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
