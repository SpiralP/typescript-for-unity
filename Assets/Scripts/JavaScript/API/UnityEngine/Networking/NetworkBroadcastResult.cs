using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkBroadcastResult {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkBroadcastResultPrototype;
      JavaScriptValue NetworkBroadcastResultConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkBroadcastResult),
        (args) => { throw new NotImplementedException(); },
        out NetworkBroadcastResultPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkBroadcastResult", NetworkBroadcastResultConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields

      Bridge.DefineGetterSetter(
        NetworkBroadcastResultPrototype,
        "serverAddress",
        WithExternal<UnityEngine.Networking.NetworkBroadcastResult>((o, args) => JavaScriptValue.FromString(o.serverAddress)),
        WithExternal<UnityEngine.Networking.NetworkBroadcastResult>((o, args) => { o.serverAddress = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkBroadcastResultPrototype,
        "broadcastData",
        WithExternal<UnityEngine.Networking.NetworkBroadcastResult>((o, args) => Bridge.CreateExternalWithPrototype(o.broadcastData)),
        WithExternal<UnityEngine.Networking.NetworkBroadcastResult>((o, args) => { o.broadcastData = Bridge.GetExternal<System.Byte[]>(args[1]); })
      );


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
