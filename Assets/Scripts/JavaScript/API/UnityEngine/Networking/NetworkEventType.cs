using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkEventType {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkEventTypePrototype;
      JavaScriptValue NetworkEventTypeConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkEventType),
        (args) => { throw new NotImplementedException(); },
        out NetworkEventTypePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkEventType", NetworkEventTypeConstructor);


      // Static Fields

      NetworkEventTypeConstructor.SetProperty(
        "DataEvent",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkEventType.DataEvent)
      );


      NetworkEventTypeConstructor.SetProperty(
        "ConnectEvent",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkEventType.ConnectEvent)
      );


      NetworkEventTypeConstructor.SetProperty(
        "DisconnectEvent",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkEventType.DisconnectEvent)
      );


      NetworkEventTypeConstructor.SetProperty(
        "Nothing",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkEventType.Nothing)
      );


      NetworkEventTypeConstructor.SetProperty(
        "BroadcastEvent",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkEventType.BroadcastEvent)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
