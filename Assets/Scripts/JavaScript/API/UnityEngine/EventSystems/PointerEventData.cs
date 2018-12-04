using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.EventSystems {
  class JSPointerEventData {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PointerEventDataPrototype;
      JavaScriptValue PointerEventDataConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.EventSystems.PointerEventData),
        (args) => { throw new NotImplementedException(); },
        out PointerEventDataPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("EventSystems")
        .SetProperty("PointerEventData", PointerEventDataConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields

      /*
        PointerEventData hovered
        System.Collections.Generic.List`1[UnityEngine.GameObject] has generics
      */


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "pointerEnter",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.pointerEnter)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.pointerEnter = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      Bridge.DefineGetter(
        PointerEventDataPrototype,
        "lastPress",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.lastPress))
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "rawPointerPress",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.rawPointerPress)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.rawPointerPress = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "pointerDrag",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.pointerDrag)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.pointerDrag = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "pointerCurrentRaycast",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.pointerCurrentRaycast)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.pointerCurrentRaycast = Bridge.GetExternal<UnityEngine.EventSystems.RaycastResult>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "pointerPressRaycast",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.pointerPressRaycast)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.pointerPressRaycast = Bridge.GetExternal<UnityEngine.EventSystems.RaycastResult>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "eligibleForClick",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromBoolean(o.eligibleForClick)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.eligibleForClick = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "pointerId",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromInt32(o.pointerId)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.pointerId = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "position",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.position)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.position = Bridge.GetExternal<UnityEngine.Vector2>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "delta",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.delta)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.delta = Bridge.GetExternal<UnityEngine.Vector2>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "pressPosition",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.pressPosition)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.pressPosition = Bridge.GetExternal<UnityEngine.Vector2>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "clickTime",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromDouble(o.clickTime)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.clickTime = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "clickCount",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromInt32(o.clickCount)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.clickCount = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "scrollDelta",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.scrollDelta)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.scrollDelta = Bridge.GetExternal<UnityEngine.Vector2>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "useDragThreshold",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromBoolean(o.useDragThreshold)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.useDragThreshold = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "dragging",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromBoolean(o.dragging)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.dragging = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "button",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.button)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.button = Bridge.GetExternal<UnityEngine.EventSystems.PointerEventData.InputButton>(args[1]); })
      );


      Bridge.DefineGetter(
        PointerEventDataPrototype,
        "enterEventCamera",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.enterEventCamera))
      );


      Bridge.DefineGetter(
        PointerEventDataPrototype,
        "pressEventCamera",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.pressEventCamera))
      );


      Bridge.DefineGetterSetter(
        PointerEventDataPrototype,
        "pointerPress",
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => Bridge.CreateExternalWithPrototype(o.pointerPress)),
        WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => { o.pointerPress = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      // Instance Methods

      PointerEventDataPrototype.SetProperty(
        "IsPointerMoving",
        Bridge.CreateFunction(
          "IsPointerMoving",
          WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromBoolean(o.IsPointerMoving()))
        )
      );


      PointerEventDataPrototype.SetProperty(
        "IsScrolling",
        Bridge.CreateFunction(
          "IsScrolling",
          WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromBoolean(o.IsScrolling()))
        )
      );


      PointerEventDataPrototype.SetProperty(
        "ToString",
        Bridge.CreateFunction(
          "ToString",
          WithExternal<UnityEngine.EventSystems.PointerEventData>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


    }
  }
}
