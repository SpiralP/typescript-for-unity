using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.EventSystems {
  class JSAxisEventData {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue AxisEventDataPrototype;
      JavaScriptValue AxisEventDataConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.EventSystems.AxisEventData),
        (args) => { throw new NotImplementedException(); },
        out AxisEventDataPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("EventSystems")
        .SetProperty("AxisEventData", AxisEventDataConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        AxisEventDataPrototype,
        "moveVector",
        WithExternal<UnityEngine.EventSystems.AxisEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.moveVector)),
        WithExternal<UnityEngine.EventSystems.AxisEventData>((o, args) => { o.moveVector = Bridge.GetExternal<UnityEngine.Vector2>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        AxisEventDataPrototype,
        "moveDir",
        WithExternal<UnityEngine.EventSystems.AxisEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.moveDir)),
        WithExternal<UnityEngine.EventSystems.AxisEventData>((o, args) => { o.moveDir = Bridge.GetExternal<UnityEngine.EventSystems.MoveDirection>(args[1]); })
      );


      // Instance Methods

    }
  }
}
