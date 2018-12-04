using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.EventSystems {
  class Root {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("EventSystems", JavaScriptValue.CreateObject());

      JSAbstractEventData.Register(context);
      JSMoveDirection.Register(context);
      JSBaseEventData.Register(context);
      JSAxisEventData.Register(context);
      JSPointerEventData.Register(context);
    }
  }
}
