using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkDiscovery {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkDiscoveryPrototype;
      JavaScriptValue NetworkDiscoveryConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkDiscovery),
        (args) => { throw new NotImplementedException(); },
        out NetworkDiscoveryPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkDiscovery", NetworkDiscoveryConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "broadcastPort",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromInt32(o.broadcastPort)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.broadcastPort = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "broadcastKey",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromInt32(o.broadcastKey)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.broadcastKey = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "broadcastVersion",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromInt32(o.broadcastVersion)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.broadcastVersion = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "broadcastSubVersion",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromInt32(o.broadcastSubVersion)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.broadcastSubVersion = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "broadcastInterval",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromInt32(o.broadcastInterval)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.broadcastInterval = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "useNetworkManager",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromBoolean(o.useNetworkManager)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.useNetworkManager = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "broadcastData",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromString(o.broadcastData)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.broadcastData = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "showGUI",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromBoolean(o.showGUI)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.showGUI = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "offsetX",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromInt32(o.offsetX)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.offsetX = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "offsetY",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromInt32(o.offsetY)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.offsetY = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "hostId",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromInt32(o.hostId)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.hostId = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "running",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromBoolean(o.running)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.running = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "isServer",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromBoolean(o.isServer)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.isServer = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkDiscoveryPrototype,
        "isClient",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromBoolean(o.isClient)),
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => { o.isClient = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        NetworkDiscoveryPrototype,
        "broadcastsReceived",
        WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => Bridge.CreateExternalWithPrototype(o.broadcastsReceived))
      );


      // Instance Methods

      NetworkDiscoveryPrototype.SetProperty(
        "Initialize",
        Bridge.CreateFunction(
          "Initialize",
          WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromBoolean(o.Initialize()))
        )
      );


      NetworkDiscoveryPrototype.SetProperty(
        "StartAsClient",
        Bridge.CreateFunction(
          "StartAsClient",
          WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromBoolean(o.StartAsClient()))
        )
      );


      NetworkDiscoveryPrototype.SetProperty(
        "StartAsServer",
        Bridge.CreateFunction(
          "StartAsServer",
          WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => JavaScriptValue.FromBoolean(o.StartAsServer()))
        )
      );


      NetworkDiscoveryPrototype.SetProperty(
        "StopBroadcast",
        Bridge.CreateFunction(
          "StopBroadcast",
          WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => o.StopBroadcast())
        )
      );


      NetworkDiscoveryPrototype.SetProperty(
        "OnReceivedBroadcast",
        Bridge.CreateFunction(
          "OnReceivedBroadcast",
          WithExternal<UnityEngine.Networking.NetworkDiscovery>((o, args) => o.OnReceivedBroadcast(args[1].ToString(), args[2].ToString()))
        )
      );


    }
  }
}
