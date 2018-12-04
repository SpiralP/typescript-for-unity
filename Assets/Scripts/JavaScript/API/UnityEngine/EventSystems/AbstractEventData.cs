using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.EventSystems {
  class JSAbstractEventData {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue AbstractEventDataPrototype;
      JavaScriptValue AbstractEventDataConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.EventSystems.AbstractEventData),
        (args) => { throw new NotImplementedException(); },
        out AbstractEventDataPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("EventSystems")
        .SetProperty("AbstractEventData", AbstractEventDataConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        AbstractEventDataPrototype,
        "used",
        WithExternal<UnityEngine.EventSystems.AbstractEventData>((o, args) => JavaScriptValue.FromBoolean(o.used))
      );


      // Instance Methods

      AbstractEventDataPrototype.SetProperty(
        "Reset",
        Bridge.CreateFunction(
          "Reset",
          WithExternal<UnityEngine.EventSystems.AbstractEventData>((o, args) => o.Reset())
        )
      );


      AbstractEventDataPrototype.SetProperty(
        "Use",
        Bridge.CreateFunction(
          "Use",
          WithExternal<UnityEngine.EventSystems.AbstractEventData>((o, args) => o.Use())
        )
      );


    }
  }
}
