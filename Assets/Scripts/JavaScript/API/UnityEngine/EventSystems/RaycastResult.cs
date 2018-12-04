using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.EventSystems {
  class JSRaycastResult {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RaycastResultPrototype;
      JavaScriptValue RaycastResultConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.EventSystems.RaycastResult),
        (args) => { throw new NotImplementedException(); },
        out RaycastResultPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("EventSystems")
        .SetProperty("RaycastResult", RaycastResultConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields

      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "module",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => Bridge.CreateExternalWithPrototype(o.module)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.module = Bridge.GetExternal<UnityEngine.EventSystems.BaseRaycaster>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "distance",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => JavaScriptValue.FromDouble(o.distance)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.distance = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "index",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => JavaScriptValue.FromDouble(o.index)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.index = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "depth",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => JavaScriptValue.FromInt32(o.depth)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.depth = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "sortingLayer",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => JavaScriptValue.FromInt32(o.sortingLayer)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.sortingLayer = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "sortingOrder",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => JavaScriptValue.FromInt32(o.sortingOrder)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.sortingOrder = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "worldPosition",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => Bridge.CreateExternalWithPrototype(o.worldPosition)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.worldPosition = Bridge.GetExternal<UnityEngine.Vector3>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "worldNormal",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => Bridge.CreateExternalWithPrototype(o.worldNormal)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.worldNormal = Bridge.GetExternal<UnityEngine.Vector3>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "screenPosition",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => Bridge.CreateExternalWithPrototype(o.screenPosition)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.screenPosition = Bridge.GetExternal<UnityEngine.Vector2>(args[1]); })
      );


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        RaycastResultPrototype,
        "gameObject",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => Bridge.CreateExternalWithPrototype(o.gameObject)),
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => { o.gameObject = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      Bridge.DefineGetter(
        RaycastResultPrototype,
        "isValid",
        WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => JavaScriptValue.FromBoolean(o.isValid))
      );


      // Instance Methods

      RaycastResultPrototype.SetProperty(
        "Clear",
        Bridge.CreateFunction(
          "Clear",
          WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => o.Clear())
        )
      );


      RaycastResultPrototype.SetProperty(
        "ToString",
        Bridge.CreateFunction(
          "ToString",
          WithExternal<UnityEngine.EventSystems.RaycastResult>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


    }
  }
}
