declare namespace UnityEngine {
  namespace Networking {
    class NetworkTransport {
      // Static Fields

      // Static Property Accessors

      static readonly IsStarted: boolean;

      // Static Methods

      static Init(): void;

      static Shutdown(): void;

      static AddSceneId(id: number): void;

      static GetNextSceneId(): number;

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

      static GetIncomingPacketDropCountForAllHosts(): number;

      static GetIncomingPacketCountForAllHosts(): number;

      static GetOutgoingPacketCount(): number;

      /*
            NetworkTransport GetOutgoingPacketCountForHost
            parameter error is out
          */

      /*
            NetworkTransport GetOutgoingPacketCountForConnection
            parameter error is out
          */

      static GetOutgoingMessageCount(): number;

      /*
            NetworkTransport GetOutgoingMessageCountForHost
            parameter error is out
          */

      /*
            NetworkTransport GetOutgoingMessageCountForConnection
            parameter error is out
          */

      static GetOutgoingUserBytesCount(): number;

      /*
            NetworkTransport GetOutgoingUserBytesCountForHost
            parameter error is out
          */

      /*
            NetworkTransport GetOutgoingUserBytesCountForConnection
            parameter error is out
          */

      static GetOutgoingSystemBytesCount(): number;

      /*
            NetworkTransport GetOutgoingSystemBytesCountForHost
            parameter error is out
          */

      /*
            NetworkTransport GetOutgoingSystemBytesCountForConnection
            parameter error is out
          */

      static GetOutgoingFullBytesCount(): number;

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

      static GetNetworkTimestamp(): number;

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

      static AddWebsocketHost(
        topology: UnityEngine.Networking.HostTopology,
        port: number
      ): number;

      static AddWebsocketHost(
        topology: UnityEngine.Networking.HostTopology,
        port: number,
        ip: string
      ): number;

      static AddHost(
        topology: UnityEngine.Networking.HostTopology,
        port: number
      ): number;

      static AddHost(topology: UnityEngine.Networking.HostTopology): number;

      static AddHost(
        topology: UnityEngine.Networking.HostTopology,
        port: number,
        ip: string
      ): number;

      static AddHostWithSimulator(
        topology: UnityEngine.Networking.HostTopology,
        minTimeout: number,
        maxTimeout: number,
        port: number
      ): number;

      static AddHostWithSimulator(
        topology: UnityEngine.Networking.HostTopology,
        minTimeout: number,
        maxTimeout: number
      ): number;

      static AddHostWithSimulator(
        topology: UnityEngine.Networking.HostTopology,
        minTimeout: number,
        maxTimeout: number,
        port: number,
        ip: string
      ): number;

      static RemoveHost(hostId: number): boolean;

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

      static SetPacketStat(
        direction: number,
        packetStatId: number,
        numMsgs: number,
        numBytes: number
      ): void;

      /*
            NetworkTransport StartBroadcastDiscovery
            parameter error is out
          */

      static StopBroadcastDiscovery(): void;

      static IsBroadcastDiscoveryRunning(): boolean;

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

      static Init(config: UnityEngine.Networking.GlobalConfig): void;

      /*
            NetworkTransport NotifyWhenConnectionReadyForSend
            parameter error is out
          */

      static GetHostPort(hostId: number): number;

      // Instance Fields

      // Instance Property Accessors

      // Instance Methods
    }
  }
}
