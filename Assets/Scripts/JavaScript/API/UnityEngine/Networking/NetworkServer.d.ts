declare namespace UnityEngine {
  namespace Networking {
    class NetworkServer {
      // Static Fields

      // Static Property Accessors

      /*
            NetworkServer localConnections
            System.Collections.Generic.List`1[UnityEngine.Networking.NetworkConnection] has generics
          */

      static readonly listenPort: number;

      static readonly serverHostId: number;

      /*
            NetworkServer connections
            System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEngine.Networking.NetworkConnection] has generics
          */

      /*
            NetworkServer handlers
            System.Collections.Generic.Dictionary`2[System.Int16,UnityEngine.Networking.NetworkMessageDelegate] has generics
          */

      static readonly hostTopology: UnityEngine.Networking.HostTopology;

      /*
            NetworkServer objects
            System.Collections.Generic.Dictionary`2[UnityEngine.Networking.NetworkInstanceId,UnityEngine.Networking.NetworkIdentity] has generics
          */

      static dontListen: boolean;

      static useWebSockets: boolean;

      static readonly active: boolean;

      static readonly localClientActive: boolean;

      static readonly numChannels: number;

      static maxDelay: number;

      static readonly networkConnectionClass: System.Type;

      // Static Methods

      /*
            NetworkServer SetNetworkConnectionClass
            method has generics
          */

      static Configure(
        config: UnityEngine.Networking.ConnectionConfig,
        maxConnections: number
      ): boolean;

      static Configure(topology: UnityEngine.Networking.HostTopology): boolean;

      static Reset(): void;

      static Shutdown(): void;

      static Listen(
        matchInfo: UnityEngine.Networking.Match.MatchInfo,
        listenPort: number
      ): boolean;

      static ListenRelay(
        relayIp: string,
        relayPort: number,
        netGuid: UnityEngine.Networking.Types.NetworkID,
        sourceId: UnityEngine.Networking.Types.SourceID,
        nodeId: UnityEngine.Networking.Types.NodeID
      ): void;

      static Listen(serverPort: number): boolean;

      static Listen(ipAddress: string, serverPort: number): boolean;

      static BecomeHost(
        oldClient: UnityEngine.Networking.NetworkClient,
        port: number,
        matchInfo: UnityEngine.Networking.Match.MatchInfo,
        oldConnectionId: number,
        peers: UnityEngine.Networking.NetworkSystem.PeerInfoMessage[]
      ): UnityEngine.Networking.NetworkClient;

      static SendToAll(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): boolean;

      static SendToReady(
        contextObj: UnityEngine.GameObject,
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): boolean;

      static SendWriterToReady(
        contextObj: UnityEngine.GameObject,
        writer: UnityEngine.Networking.NetworkWriter,
        channelId: number
      ): void;

      static SendBytesToReady(
        contextObj: UnityEngine.GameObject,
        buffer: System.Byte[],
        numBytes: number,
        channelId: number
      ): void;

      static SendBytesToPlayer(
        player: UnityEngine.GameObject,
        buffer: System.Byte[],
        numBytes: number,
        channelId: number
      ): void;

      static SendUnreliableToAll(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): boolean;

      static SendUnreliableToReady(
        contextObj: UnityEngine.GameObject,
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): boolean;

      static SendByChannelToAll(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase,
        channelId: number
      ): boolean;

      static SendByChannelToReady(
        contextObj: UnityEngine.GameObject,
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase,
        channelId: number
      ): boolean;

      static DisconnectAll(): void;

      static RegisterHandler(
        msgType: System.Int16,
        handler: UnityEngine.Networking.NetworkMessageDelegate
      ): void;

      static UnregisterHandler(msgType: System.Int16): void;

      static ClearHandlers(): void;

      static ClearSpawners(): void;

      /*
            NetworkServer GetStatsOut
            parameter numMsgs is out
          */

      /*
            NetworkServer GetStatsIn
            parameter numMsgs is out
          */

      static SendToClientOfPlayer(
        player: UnityEngine.GameObject,
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): void;

      static SendToClient(
        connectionId: number,
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): void;

      static ReplacePlayerForConnection(
        conn: UnityEngine.Networking.NetworkConnection,
        player: UnityEngine.GameObject,
        playerControllerId: System.Int16,
        assetId: UnityEngine.Networking.NetworkHash128
      ): boolean;

      static ReplacePlayerForConnection(
        conn: UnityEngine.Networking.NetworkConnection,
        player: UnityEngine.GameObject,
        playerControllerId: System.Int16
      ): boolean;

      static AddPlayerForConnection(
        conn: UnityEngine.Networking.NetworkConnection,
        player: UnityEngine.GameObject,
        playerControllerId: System.Int16,
        assetId: UnityEngine.Networking.NetworkHash128
      ): boolean;

      static AddPlayerForConnection(
        conn: UnityEngine.Networking.NetworkConnection,
        player: UnityEngine.GameObject,
        playerControllerId: System.Int16
      ): boolean;

      static SetClientReady(
        conn: UnityEngine.Networking.NetworkConnection
      ): void;

      static SetAllClientsNotReady(): void;

      static SetClientNotReady(
        conn: UnityEngine.Networking.NetworkConnection
      ): void;

      static DestroyPlayersForConnection(
        conn: UnityEngine.Networking.NetworkConnection
      ): void;

      static ClearLocalObjects(): void;

      static Spawn(obj: UnityEngine.GameObject): void;

      static SpawnWithClientAuthority(
        obj: UnityEngine.GameObject,
        player: UnityEngine.GameObject
      ): boolean;

      static SpawnWithClientAuthority(
        obj: UnityEngine.GameObject,
        conn: UnityEngine.Networking.NetworkConnection
      ): boolean;

      static SpawnWithClientAuthority(
        obj: UnityEngine.GameObject,
        assetId: UnityEngine.Networking.NetworkHash128,
        conn: UnityEngine.Networking.NetworkConnection
      ): boolean;

      static Spawn(
        obj: UnityEngine.GameObject,
        assetId: UnityEngine.Networking.NetworkHash128
      ): void;

      static Destroy(obj: UnityEngine.GameObject): void;

      static UnSpawn(obj: UnityEngine.GameObject): void;

      static FindLocalObject(
        netId: UnityEngine.Networking.NetworkInstanceId
      ): UnityEngine.GameObject;

      /*
            NetworkServer GetConnectionStats
            System.Collections.Generic.Dictionary`2[System.Int16,UnityEngine.Networking.NetworkConnection+PacketStat] has generics
          */

      static ResetConnectionStats(): void;

      static AddExternalConnection(
        conn: UnityEngine.Networking.NetworkConnection
      ): boolean;

      static RemoveExternalConnection(connectionId: number): void;

      static SpawnObjects(): boolean;

      // Instance Fields

      // Instance Property Accessors

      // Instance Methods
    }
  }
}
