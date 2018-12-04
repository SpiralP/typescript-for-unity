using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkServerSimple {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkServerSimplePrototype;
      JavaScriptValue NetworkServerSimpleConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkServerSimple),
        (args) => { throw new NotImplementedException(); },
        out NetworkServerSimplePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkServerSimple", NetworkServerSimpleConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        NetworkServerSimplePrototype,
        "listenPort",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromInt32(o.listenPort)),
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => { o.listenPort = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkServerSimplePrototype,
        "serverHostId",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromInt32(o.serverHostId)),
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => { o.serverHostId = args[1].ToInt32(); })
      );


      Bridge.DefineGetter(
        NetworkServerSimplePrototype,
        "hostTopology",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => Bridge.CreateExternalWithPrototype(o.hostTopology))
      );


      Bridge.DefineGetterSetter(
        NetworkServerSimplePrototype,
        "useWebSockets",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromBoolean(o.useWebSockets)),
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => { o.useWebSockets = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        NetworkServerSimplePrototype,
        "connections",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => Bridge.CreateExternalWithPrototype(o.connections))
      );


      Bridge.DefineGetter(
        NetworkServerSimplePrototype,
        "handlers",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => Bridge.CreateExternalWithPrototype(o.handlers))
      );


      Bridge.DefineGetter(
        NetworkServerSimplePrototype,
        "messageBuffer",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => Bridge.CreateExternalWithPrototype(o.messageBuffer))
      );


      Bridge.DefineGetter(
        NetworkServerSimplePrototype,
        "messageReader",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => Bridge.CreateExternalWithPrototype(o.messageReader))
      );


      Bridge.DefineGetter(
        NetworkServerSimplePrototype,
        "networkConnectionClass",
        WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => Bridge.CreateExternalWithPrototype(o.networkConnectionClass))
      );


      // Instance Methods

      /*
        NetworkServerSimple SetNetworkConnectionClass
        method has generics
      */


      NetworkServerSimplePrototype.SetProperty(
        "Initialize",
        Bridge.CreateFunction(
          "Initialize",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.Initialize())
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "Configure",
        Bridge.CreateFunction(
          "Configure",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromBoolean(o.Configure(Bridge.GetExternal<UnityEngine.Networking.ConnectionConfig>(args[1]), args[2].ToInt32())))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "Configure",
        Bridge.CreateFunction(
          "Configure",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromBoolean(o.Configure(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]))))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "Listen",
        Bridge.CreateFunction(
          "Listen",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromBoolean(o.Listen(args[1].ToString(), args[2].ToInt32())))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "Listen",
        Bridge.CreateFunction(
          "Listen",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromBoolean(o.Listen(args[1].ToInt32())))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "Listen",
        Bridge.CreateFunction(
          "Listen",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromBoolean(o.Listen(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[2]))))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "ListenRelay",
        Bridge.CreateFunction(
          "ListenRelay",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.ListenRelay(args[1].ToString(), args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.Types.NetworkID>(args[3]), Bridge.GetExternal<UnityEngine.Networking.Types.SourceID>(args[4]), Bridge.GetExternal<UnityEngine.Networking.Types.NodeID>(args[5])))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "Stop",
        Bridge.CreateFunction(
          "Stop",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.Stop())
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "RegisterHandler",
        Bridge.CreateFunction(
          "RegisterHandler",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.RegisterHandler(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkMessageDelegate>(args[2])))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "UnregisterHandler",
        Bridge.CreateFunction(
          "UnregisterHandler",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.UnregisterHandler(Bridge.GetExternal<System.Int16>(args[1])))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "ClearHandlers",
        Bridge.CreateFunction(
          "ClearHandlers",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.ClearHandlers())
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "UpdateConnections",
        Bridge.CreateFunction(
          "UpdateConnections",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.UpdateConnections())
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "Update",
        Bridge.CreateFunction(
          "Update",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.Update())
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "FindConnection",
        Bridge.CreateFunction(
          "FindConnection",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => Bridge.CreateExternalWithPrototype(o.FindConnection(args[1].ToInt32())))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "SetConnectionAtIndex",
        Bridge.CreateFunction(
          "SetConnectionAtIndex",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromBoolean(o.SetConnectionAtIndex(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]))))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "RemoveConnectionAtIndex",
        Bridge.CreateFunction(
          "RemoveConnectionAtIndex",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => JavaScriptValue.FromBoolean(o.RemoveConnectionAtIndex(args[1].ToInt32())))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "SendBytesTo",
        Bridge.CreateFunction(
          "SendBytesTo",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.SendBytesTo(args[1].ToInt32(), Bridge.GetExternal<System.Byte[]>(args[2]), args[3].ToInt32(), args[4].ToInt32()))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "SendWriterTo",
        Bridge.CreateFunction(
          "SendWriterTo",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.SendWriterTo(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[2]), args[3].ToInt32()))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "Disconnect",
        Bridge.CreateFunction(
          "Disconnect",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.Disconnect(args[1].ToInt32()))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "DisconnectAllConnections",
        Bridge.CreateFunction(
          "DisconnectAllConnections",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.DisconnectAllConnections())
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "OnConnectError",
        Bridge.CreateFunction(
          "OnConnectError",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.OnConnectError(args[1].ToInt32(), Bridge.GetExternal<System.Byte>(args[2])))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "OnDataError",
        Bridge.CreateFunction(
          "OnDataError",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.OnDataError(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<System.Byte>(args[2])))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "OnDisconnectError",
        Bridge.CreateFunction(
          "OnDisconnectError",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.OnDisconnectError(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<System.Byte>(args[2])))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "OnConnected",
        Bridge.CreateFunction(
          "OnConnected",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.OnConnected(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "OnDisconnected",
        Bridge.CreateFunction(
          "OnDisconnected",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.OnDisconnected(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkServerSimplePrototype.SetProperty(
        "OnData",
        Bridge.CreateFunction(
          "OnData",
          WithExternal<UnityEngine.Networking.NetworkServerSimple>((o, args) => o.OnData(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), args[2].ToInt32(), args[3].ToInt32()))
        )
      );


    }
  }
}
