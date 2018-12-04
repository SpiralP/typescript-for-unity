using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkTransport {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkTransportPrototype;
      JavaScriptValue NetworkTransportConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkTransport),
        (args) => { throw new NotImplementedException(); },
        out NetworkTransportPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkTransport", NetworkTransportConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetter(
        NetworkTransportConstructor,
        "IsStarted",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkTransport.IsStarted)
      );


      // Static Methods

      NetworkTransportConstructor.SetProperty(
        "Init",
        Bridge.CreateFunction(
          "Init",
          (args) => UnityEngine.Networking.NetworkTransport.Init()
        )
      );


      NetworkTransportConstructor.SetProperty(
        "Shutdown",
        Bridge.CreateFunction(
          "Shutdown",
          (args) => UnityEngine.Networking.NetworkTransport.Shutdown()
        )
      );


      NetworkTransportConstructor.SetProperty(
        "AddSceneId",
        Bridge.CreateFunction(
          "AddSceneId",
          (args) => UnityEngine.Networking.NetworkTransport.AddSceneId(args[1].ToInt32())
        )
      );


      NetworkTransportConstructor.SetProperty(
        "GetNextSceneId",
        Bridge.CreateFunction(
          "GetNextSceneId",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetNextSceneId())
        )
      );


      /*
        NetworkTransport ConnectAsNetworkHost
        parameter error is out
      */


      /*
        NetworkTransport DisconnectNetworkHost
        parameter error is out
      */


      /*
        NetworkTransport ReceiveRelayEventFromHost
        parameter error is out
      */


      /*
        NetworkTransport ConnectToNetworkPeer
        parameter error is out
      */


      /*
        NetworkTransport ConnectToNetworkPeer
        parameter error is out
      */


      /*
        NetworkTransport GetIncomingMessageQueueSize
        parameter error is out
      */


      /*
        NetworkTransport GetOutgoingMessageQueueSize
        parameter error is out
      */


      /*
        NetworkTransport GetCurrentRTT
        parameter error is out
      */


      /*
        NetworkTransport GetIncomingPacketLossCount
        parameter error is out
      */


      /*
        NetworkTransport GetIncomingPacketCount
        parameter error is out
      */


      /*
        NetworkTransport GetOutgoingPacketNetworkLossPercent
        parameter error is out
      */


      /*
        NetworkTransport GetOutgoingPacketOverflowLossPercent
        parameter error is out
      */


      /*
        NetworkTransport GetMaxAllowedBandwidth
        parameter error is out
      */


      /*
        NetworkTransport GetAckBufferCount
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "GetIncomingPacketDropCountForAllHosts",
        Bridge.CreateFunction(
          "GetIncomingPacketDropCountForAllHosts",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetIncomingPacketDropCountForAllHosts())
        )
      );


      NetworkTransportConstructor.SetProperty(
        "GetIncomingPacketCountForAllHosts",
        Bridge.CreateFunction(
          "GetIncomingPacketCountForAllHosts",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetIncomingPacketCountForAllHosts())
        )
      );


      NetworkTransportConstructor.SetProperty(
        "GetOutgoingPacketCount",
        Bridge.CreateFunction(
          "GetOutgoingPacketCount",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetOutgoingPacketCount())
        )
      );


      /*
        NetworkTransport GetOutgoingPacketCountForHost
        parameter error is out
      */


      /*
        NetworkTransport GetOutgoingPacketCountForConnection
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "GetOutgoingMessageCount",
        Bridge.CreateFunction(
          "GetOutgoingMessageCount",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetOutgoingMessageCount())
        )
      );


      /*
        NetworkTransport GetOutgoingMessageCountForHost
        parameter error is out
      */


      /*
        NetworkTransport GetOutgoingMessageCountForConnection
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "GetOutgoingUserBytesCount",
        Bridge.CreateFunction(
          "GetOutgoingUserBytesCount",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetOutgoingUserBytesCount())
        )
      );


      /*
        NetworkTransport GetOutgoingUserBytesCountForHost
        parameter error is out
      */


      /*
        NetworkTransport GetOutgoingUserBytesCountForConnection
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "GetOutgoingSystemBytesCount",
        Bridge.CreateFunction(
          "GetOutgoingSystemBytesCount",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetOutgoingSystemBytesCount())
        )
      );


      /*
        NetworkTransport GetOutgoingSystemBytesCountForHost
        parameter error is out
      */


      /*
        NetworkTransport GetOutgoingSystemBytesCountForConnection
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "GetOutgoingFullBytesCount",
        Bridge.CreateFunction(
          "GetOutgoingFullBytesCount",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetOutgoingFullBytesCount())
        )
      );


      /*
        NetworkTransport GetOutgoingFullBytesCountForHost
        parameter error is out
      */


      /*
        NetworkTransport GetOutgoingFullBytesCountForConnection
        parameter error is out
      */


      /*
        NetworkTransport GetConnectionInfo
        parameter address is out
      */


      /*
        NetworkTransport GetConnectionInfo
        parameter port is out
      */


      NetworkTransportConstructor.SetProperty(
        "GetNetworkTimestamp",
        Bridge.CreateFunction(
          "GetNetworkTimestamp",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetNetworkTimestamp())
        )
      );


      /*
        NetworkTransport GetRemoteDelayTimeMS
        parameter error is out
      */


      /*
        NetworkTransport StartSendMulticast
        parameter error is out
      */


      /*
        NetworkTransport SendMulticast
        parameter error is out
      */


      /*
        NetworkTransport FinishSendMulticast
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "AddWebsocketHost",
        Bridge.CreateFunction(
          "AddWebsocketHost",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.AddWebsocketHost(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]), args[2].ToInt32()))
        )
      );


      NetworkTransportConstructor.SetProperty(
        "AddWebsocketHost",
        Bridge.CreateFunction(
          "AddWebsocketHost",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.AddWebsocketHost(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]), args[2].ToInt32(), args[3].ToString()))
        )
      );


      NetworkTransportConstructor.SetProperty(
        "AddHost",
        Bridge.CreateFunction(
          "AddHost",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.AddHost(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]), args[2].ToInt32()))
        )
      );


      NetworkTransportConstructor.SetProperty(
        "AddHost",
        Bridge.CreateFunction(
          "AddHost",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.AddHost(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1])))
        )
      );


      NetworkTransportConstructor.SetProperty(
        "AddHost",
        Bridge.CreateFunction(
          "AddHost",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.AddHost(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]), args[2].ToInt32(), args[3].ToString()))
        )
      );


      NetworkTransportConstructor.SetProperty(
        "AddHostWithSimulator",
        Bridge.CreateFunction(
          "AddHostWithSimulator",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.AddHostWithSimulator(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]), args[2].ToInt32(), args[3].ToInt32(), args[4].ToInt32()))
        )
      );


      NetworkTransportConstructor.SetProperty(
        "AddHostWithSimulator",
        Bridge.CreateFunction(
          "AddHostWithSimulator",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.AddHostWithSimulator(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]), args[2].ToInt32(), args[3].ToInt32()))
        )
      );


      NetworkTransportConstructor.SetProperty(
        "AddHostWithSimulator",
        Bridge.CreateFunction(
          "AddHostWithSimulator",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.AddHostWithSimulator(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]), args[2].ToInt32(), args[3].ToInt32(), args[4].ToInt32(), args[5].ToString()))
        )
      );


      NetworkTransportConstructor.SetProperty(
        "RemoveHost",
        Bridge.CreateFunction(
          "RemoveHost",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkTransport.RemoveHost(args[1].ToInt32()))
        )
      );


      /*
        NetworkTransport Connect
        parameter error is out
      */


      /*
        NetworkTransport ConnectWithSimulator
        parameter error is out
      */


      /*
        NetworkTransport Disconnect
        parameter error is out
      */


      /*
        NetworkTransport Send
        parameter error is out
      */


      /*
        NetworkTransport QueueMessageForSending
        parameter error is out
      */


      /*
        NetworkTransport SendQueuedMessages
        parameter error is out
      */


      /*
        NetworkTransport Receive
        parameter hostId is out
      */


      /*
        NetworkTransport ReceiveFromHost
        parameter connectionId is out
      */


      NetworkTransportConstructor.SetProperty(
        "SetPacketStat",
        Bridge.CreateFunction(
          "SetPacketStat",
          (args) => UnityEngine.Networking.NetworkTransport.SetPacketStat(args[1].ToInt32(), args[2].ToInt32(), args[3].ToInt32(), args[4].ToInt32())
        )
      );


      /*
        NetworkTransport StartBroadcastDiscovery
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "StopBroadcastDiscovery",
        Bridge.CreateFunction(
          "StopBroadcastDiscovery",
          (args) => UnityEngine.Networking.NetworkTransport.StopBroadcastDiscovery()
        )
      );


      NetworkTransportConstructor.SetProperty(
        "IsBroadcastDiscoveryRunning",
        Bridge.CreateFunction(
          "IsBroadcastDiscoveryRunning",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkTransport.IsBroadcastDiscoveryRunning())
        )
      );


      /*
        NetworkTransport SetBroadcastCredentials
        parameter error is out
      */


      /*
        NetworkTransport GetBroadcastConnectionInfo
        parameter port is out
      */


      /*
        NetworkTransport GetBroadcastConnectionInfo
        parameter address is out
      */


      /*
        NetworkTransport GetBroadcastConnectionMessage
        parameter receivedSize is out
      */


      /*
        NetworkTransport ConnectEndPoint
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "Init",
        Bridge.CreateFunction(
          "Init",
          (args) => UnityEngine.Networking.NetworkTransport.Init(Bridge.GetExternal<UnityEngine.Networking.GlobalConfig>(args[1]))
        )
      );


      /*
        NetworkTransport NotifyWhenConnectionReadyForSend
        parameter error is out
      */


      NetworkTransportConstructor.SetProperty(
        "GetHostPort",
        Bridge.CreateFunction(
          "GetHostPort",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkTransport.GetHostPort(args[1].ToInt32()))
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
