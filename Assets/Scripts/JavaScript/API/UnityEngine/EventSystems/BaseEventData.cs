using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.EventSystems {
  class JSBaseEventData {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue BaseEventDataPrototype;
      JavaScriptValue BaseEventDataConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.EventSystems.BaseEventData),
        (args) => { throw new NotImplementedException(); },
        out BaseEventDataPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("EventSystems")
        .SetProperty("BaseEventData", BaseEventDataConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        BaseEventDataPrototype,
        "currentInputModule",
        WithExternal<UnityEngine.EventSystems.BaseEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.currentInputModule))
      );


      Bridge.DefineGetterSetter(
        BaseEventDataPrototype,
        "selectedObject",
        WithExternal<UnityEngine.EventSystems.BaseEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.selectedObject)),
        WithExternal<UnityEngine.EventSystems.BaseEventData>((o, args) => { o.selectedObject = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      // Instance Methods

    }
  }
}
