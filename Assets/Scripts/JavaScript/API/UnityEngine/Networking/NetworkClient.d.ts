declare namespace UnityEngine {
  namespace Networking {
    class NetworkClient {
      // Static Fields

      // Static Property Accessors

      /*
            NetworkClient allClients
            System.Collections.Generic.List`1[UnityEngine.Networking.NetworkClient] has generics
          */

      static readonly active: boolean;

      // Static Methods

      /*
            NetworkClient GetTotalConnectionStats
            System.Collections.Generic.Dictionary`2[System.Int16,UnityEngine.Networking.NetworkConnection+PacketStat] has generics
          */

      static ShutdownAll(): void;

      // Instance Fields

      // Instance Property Accessors

      readonly serverIp: string;

      readonly serverPort: number;

      readonly connection: UnityEngine.Networking.NetworkConnection;

      /*
            NetworkClient handlers
            System.Collections.Generic.Dictionary`2[System.Int16,UnityEngine.Networking.NetworkMessageDelegate] has generics
          */

      readonly numChannels: number;

      readonly hostTopology: UnityEngine.Networking.HostTopology;

      hostPort: number;

      readonly isConnected: boolean;

      readonly networkConnectionClass: System.Type;

      // Instance Methods

      /*
            NetworkClient SetNetworkConnectionClass
            method has generics
          */

      Configure(
        config: UnityEngine.Networking.ConnectionConfig,
        maxConnections: number
      ): boolean;

      Configure(topology: UnityEngine.Networking.HostTopology): boolean;

      Connect(matchInfo: UnityEngine.Networking.Match.MatchInfo): void;

      ReconnectToNewHost(serverIp: string, serverPort: number): boolean;

      ReconnectToNewHost(secureTunnelEndPoint: System.Net.EndPoint): boolean;

      ConnectWithSimulator(
        serverIp: string,
        serverPort: number,
        latency: number,
        packetLoss: number
      ): void;

      Connect(serverIp: string, serverPort: number): void;

      Connect(secureTunnelEndPoint: System.Net.EndPoint): void;

      Disconnect(): void;

      Send(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): boolean;

      SendWriter(
        writer: UnityEngine.Networking.NetworkWriter,
        channelId: number
      ): boolean;

      SendBytes(
        data: System.Byte[],
        numBytes: number,
        channelId: number
      ): boolean;

      SendUnreliable(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): boolean;

      SendByChannel(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase,
        channelId: number
      ): boolean;

      SetMaxDelay(seconds: number): void;

      Shutdown(): void;

      /*
            NetworkClient GetStatsOut
            parameter numMsgs is out
          */

      /*
            NetworkClient GetStatsIn
            parameter numMsgs is out
          */

      /*
            NetworkClient GetConnectionStats
            System.Collections.Generic.Dictionary`2[System.Int16,UnityEngine.Networking.NetworkConnection+PacketStat] has generics
          */

      ResetConnectionStats(): void;

      GetRTT(): number;

      RegisterHandler(
        msgType: System.Int16,
        handler: UnityEngine.Networking.NetworkMessageDelegate
      ): void;

      RegisterHandlerSafe(
        msgType: System.Int16,
        handler: UnityEngine.Networking.NetworkMessageDelegate
      ): void;

      UnregisterHandler(msgType: System.Int16): void;
    }
  }
}
