using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkServer {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkServerPrototype;
      JavaScriptValue NetworkServerConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkServer),
        (args) => { throw new NotImplementedException(); },
        out NetworkServerPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkServer", NetworkServerConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetter(
        NetworkServerConstructor,
        "localConnections",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.localConnections)
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "listenPort",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkServer.listenPort)
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "serverHostId",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkServer.serverHostId)
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "connections",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.connections)
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "handlers",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.handlers)
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "hostTopology",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.hostTopology)
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "objects",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.objects)
      );


      Bridge.DefineGetterSetter(
        NetworkServerConstructor,
        "dontListen",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.dontListen),
        (args) => { UnityEngine.Networking.NetworkServer.dontListen = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        NetworkServerConstructor,
        "useWebSockets",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.useWebSockets),
        (args) => { UnityEngine.Networking.NetworkServer.useWebSockets = args[1].ToBoolean(); }
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "active",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.active)
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "localClientActive",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.localClientActive)
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "numChannels",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkServer.numChannels)
      );


      Bridge.DefineGetterSetter(
        NetworkServerConstructor,
        "maxDelay",
        (args) => JavaScriptValue.FromDouble(UnityEngine.Networking.NetworkServer.maxDelay),
        (args) => { UnityEngine.Networking.NetworkServer.maxDelay = (float) args[1].ToDouble(); }
      );


      Bridge.DefineGetter(
        NetworkServerConstructor,
        "networkConnectionClass",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.networkConnectionClass)
      );


      // Static Methods

      /*
        NetworkServer SetNetworkConnectionClass
        method has generics
      */


      NetworkServerConstructor.SetProperty(
        "Configure",
        Bridge.CreateFunction(
          "Configure",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.Configure(Bridge.GetExternal<UnityEngine.Networking.ConnectionConfig>(args[1]), args[2].ToInt32()))
        )
      );


      NetworkServerConstructor.SetProperty(
        "Configure",
        Bridge.CreateFunction(
          "Configure",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.Configure(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "Reset",
        Bridge.CreateFunction(
          "Reset",
          (args) => UnityEngine.Networking.NetworkServer.Reset()
        )
      );


      NetworkServerConstructor.SetProperty(
        "Shutdown",
        Bridge.CreateFunction(
          "Shutdown",
          (args) => UnityEngine.Networking.NetworkServer.Shutdown()
        )
      );


      NetworkServerConstructor.SetProperty(
        "Listen",
        Bridge.CreateFunction(
          "Listen",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.Listen(Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[1]), args[2].ToInt32()))
        )
      );


      NetworkServerConstructor.SetProperty(
        "ListenRelay",
        Bridge.CreateFunction(
          "ListenRelay",
          (args) => UnityEngine.Networking.NetworkServer.ListenRelay(args[1].ToString(), args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.Types.NetworkID>(args[3]), Bridge.GetExternal<UnityEngine.Networking.Types.SourceID>(args[4]), Bridge.GetExternal<UnityEngine.Networking.Types.NodeID>(args[5]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "Listen",
        Bridge.CreateFunction(
          "Listen",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.Listen(args[1].ToInt32()))
        )
      );


      NetworkServerConstructor.SetProperty(
        "Listen",
        Bridge.CreateFunction(
          "Listen",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.Listen(args[1].ToString(), args[2].ToInt32()))
        )
      );


      NetworkServerConstructor.SetProperty(
        "BecomeHost",
        Bridge.CreateFunction(
          "BecomeHost",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.BecomeHost(Bridge.GetExternal<UnityEngine.Networking.NetworkClient>(args[1]), args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[3]), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.NetworkSystem.PeerInfoMessage[]>(args[5])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendToAll",
        Bridge.CreateFunction(
          "SendToAll",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SendToAll(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendToReady",
        Bridge.CreateFunction(
          "SendToReady",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SendToReady(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<System.Int16>(args[2]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[3])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendWriterToReady",
        Bridge.CreateFunction(
          "SendWriterToReady",
          (args) => UnityEngine.Networking.NetworkServer.SendWriterToReady(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[2]), args[3].ToInt32())
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendBytesToReady",
        Bridge.CreateFunction(
          "SendBytesToReady",
          (args) => UnityEngine.Networking.NetworkServer.SendBytesToReady(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<System.Byte[]>(args[2]), args[3].ToInt32(), args[4].ToInt32())
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendBytesToPlayer",
        Bridge.CreateFunction(
          "SendBytesToPlayer",
          (args) => UnityEngine.Networking.NetworkServer.SendBytesToPlayer(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<System.Byte[]>(args[2]), args[3].ToInt32(), args[4].ToInt32())
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendUnreliableToAll",
        Bridge.CreateFunction(
          "SendUnreliableToAll",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SendUnreliableToAll(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendUnreliableToReady",
        Bridge.CreateFunction(
          "SendUnreliableToReady",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SendUnreliableToReady(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<System.Int16>(args[2]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[3])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendByChannelToAll",
        Bridge.CreateFunction(
          "SendByChannelToAll",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SendByChannelToAll(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2]), args[3].ToInt32()))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendByChannelToReady",
        Bridge.CreateFunction(
          "SendByChannelToReady",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SendByChannelToReady(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<System.Int16>(args[2]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[3]), args[4].ToInt32()))
        )
      );


      NetworkServerConstructor.SetProperty(
        "DisconnectAll",
        Bridge.CreateFunction(
          "DisconnectAll",
          (args) => UnityEngine.Networking.NetworkServer.DisconnectAll()
        )
      );


      NetworkServerConstructor.SetProperty(
        "RegisterHandler",
        Bridge.CreateFunction(
          "RegisterHandler",
          (args) => UnityEngine.Networking.NetworkServer.RegisterHandler(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkMessageDelegate>(args[2]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "UnregisterHandler",
        Bridge.CreateFunction(
          "UnregisterHandler",
          (args) => UnityEngine.Networking.NetworkServer.UnregisterHandler(Bridge.GetExternal<System.Int16>(args[1]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "ClearHandlers",
        Bridge.CreateFunction(
          "ClearHandlers",
          (args) => UnityEngine.Networking.NetworkServer.ClearHandlers()
        )
      );


      NetworkServerConstructor.SetProperty(
        "ClearSpawners",
        Bridge.CreateFunction(
          "ClearSpawners",
          (args) => UnityEngine.Networking.NetworkServer.ClearSpawners()
        )
      );


      /*
        NetworkServer GetStatsOut
        parameter numMsgs is out
      */


      /*
        NetworkServer GetStatsIn
        parameter numMsgs is out
      */


      NetworkServerConstructor.SetProperty(
        "SendToClientOfPlayer",
        Bridge.CreateFunction(
          "SendToClientOfPlayer",
          (args) => UnityEngine.Networking.NetworkServer.SendToClientOfPlayer(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<System.Int16>(args[2]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[3]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SendToClient",
        Bridge.CreateFunction(
          "SendToClient",
          (args) => UnityEngine.Networking.NetworkServer.SendToClient(args[1].ToInt32(), Bridge.GetExternal<System.Int16>(args[2]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[3]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "ReplacePlayerForConnection",
        Bridge.CreateFunction(
          "ReplacePlayerForConnection",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.ReplacePlayerForConnection(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<UnityEngine.GameObject>(args[2]), Bridge.GetExternal<System.Int16>(args[3]), Bridge.GetExternal<UnityEngine.Networking.NetworkHash128>(args[4])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "ReplacePlayerForConnection",
        Bridge.CreateFunction(
          "ReplacePlayerForConnection",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.ReplacePlayerForConnection(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<UnityEngine.GameObject>(args[2]), Bridge.GetExternal<System.Int16>(args[3])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "AddPlayerForConnection",
        Bridge.CreateFunction(
          "AddPlayerForConnection",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.AddPlayerForConnection(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<UnityEngine.GameObject>(args[2]), Bridge.GetExternal<System.Int16>(args[3]), Bridge.GetExternal<UnityEngine.Networking.NetworkHash128>(args[4])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "AddPlayerForConnection",
        Bridge.CreateFunction(
          "AddPlayerForConnection",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.AddPlayerForConnection(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<UnityEngine.GameObject>(args[2]), Bridge.GetExternal<System.Int16>(args[3])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SetClientReady",
        Bridge.CreateFunction(
          "SetClientReady",
          (args) => UnityEngine.Networking.NetworkServer.SetClientReady(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SetAllClientsNotReady",
        Bridge.CreateFunction(
          "SetAllClientsNotReady",
          (args) => UnityEngine.Networking.NetworkServer.SetAllClientsNotReady()
        )
      );


      NetworkServerConstructor.SetProperty(
        "SetClientNotReady",
        Bridge.CreateFunction(
          "SetClientNotReady",
          (args) => UnityEngine.Networking.NetworkServer.SetClientNotReady(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "DestroyPlayersForConnection",
        Bridge.CreateFunction(
          "DestroyPlayersForConnection",
          (args) => UnityEngine.Networking.NetworkServer.DestroyPlayersForConnection(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "ClearLocalObjects",
        Bridge.CreateFunction(
          "ClearLocalObjects",
          (args) => UnityEngine.Networking.NetworkServer.ClearLocalObjects()
        )
      );


      NetworkServerConstructor.SetProperty(
        "Spawn",
        Bridge.CreateFunction(
          "Spawn",
          (args) => UnityEngine.Networking.NetworkServer.Spawn(Bridge.GetExternal<UnityEngine.GameObject>(args[1]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SpawnWithClientAuthority",
        Bridge.CreateFunction(
          "SpawnWithClientAuthority",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SpawnWithClientAuthority(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<UnityEngine.GameObject>(args[2])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SpawnWithClientAuthority",
        Bridge.CreateFunction(
          "SpawnWithClientAuthority",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SpawnWithClientAuthority(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[2])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "SpawnWithClientAuthority",
        Bridge.CreateFunction(
          "SpawnWithClientAuthority",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SpawnWithClientAuthority(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkHash128>(args[2]), Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[3])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "Spawn",
        Bridge.CreateFunction(
          "Spawn",
          (args) => UnityEngine.Networking.NetworkServer.Spawn(Bridge.GetExternal<UnityEngine.GameObject>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkHash128>(args[2]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "Destroy",
        Bridge.CreateFunction(
          "Destroy",
          (args) => UnityEngine.Networking.NetworkServer.Destroy(Bridge.GetExternal<UnityEngine.GameObject>(args[1]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "UnSpawn",
        Bridge.CreateFunction(
          "UnSpawn",
          (args) => UnityEngine.Networking.NetworkServer.UnSpawn(Bridge.GetExternal<UnityEngine.GameObject>(args[1]))
        )
      );


      NetworkServerConstructor.SetProperty(
        "FindLocalObject",
        Bridge.CreateFunction(
          "FindLocalObject",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.FindLocalObject(Bridge.GetExternal<UnityEngine.Networking.NetworkInstanceId>(args[1])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "GetConnectionStats",
        Bridge.CreateFunction(
          "GetConnectionStats",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkServer.GetConnectionStats())
        )
      );


      NetworkServerConstructor.SetProperty(
        "ResetConnectionStats",
        Bridge.CreateFunction(
          "ResetConnectionStats",
          (args) => UnityEngine.Networking.NetworkServer.ResetConnectionStats()
        )
      );


      NetworkServerConstructor.SetProperty(
        "AddExternalConnection",
        Bridge.CreateFunction(
          "AddExternalConnection",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.AddExternalConnection(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkServerConstructor.SetProperty(
        "RemoveExternalConnection",
        Bridge.CreateFunction(
          "RemoveExternalConnection",
          (args) => UnityEngine.Networking.NetworkServer.RemoveExternalConnection(args[1].ToInt32())
        )
      );


      NetworkServerConstructor.SetProperty(
        "SpawnObjects",
        Bridge.CreateFunction(
          "SpawnObjects",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkServer.SpawnObjects())
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
