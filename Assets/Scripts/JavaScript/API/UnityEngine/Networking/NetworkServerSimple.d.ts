declare namespace UnityEngine {
  namespace Networking {
    class NetworkServerSimple {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      // Instance Property Accessors

      listenPort: number;

      serverHostId: number;

      readonly hostTopology: UnityEngine.Networking.HostTopology;

      useWebSockets: boolean;

      /*
            NetworkServerSimple connections
            System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEngine.Networking.NetworkConnection] has generics
          */

      /*
            NetworkServerSimple handlers
            System.Collections.Generic.Dictionary`2[System.Int16,UnityEngine.Networking.NetworkMessageDelegate] has generics
          */

      readonly messageBuffer: System.Byte[];

      readonly messageReader: UnityEngine.Networking.NetworkReader;

      readonly networkConnectionClass: System.Type;

      // Instance Methods

      /*
            NetworkServerSimple SetNetworkConnectionClass
            method has generics
          */

      Initialize(): void;

      Configure(
        config: UnityEngine.Networking.ConnectionConfig,
        maxConnections: number
      ): boolean;

      Configure(topology: UnityEngine.Networking.HostTopology): boolean;

      Listen(ipAddress: string, serverListenPort: number): boolean;

      Listen(serverListenPort: number): boolean;

      Listen(
        serverListenPort: number,
        topology: UnityEngine.Networking.HostTopology
      ): boolean;

      ListenRelay(
        relayIp: string,
        relayPort: number,
        netGuid: UnityEngine.Networking.Types.NetworkID,
        sourceId: UnityEngine.Networking.Types.SourceID,
        nodeId: UnityEngine.Networking.Types.NodeID
      ): void;

      Stop(): void;

      RegisterHandler(
        msgType: System.Int16,
        handler: UnityEngine.Networking.NetworkMessageDelegate
      ): void;

      UnregisterHandler(msgType: System.Int16): void;

      ClearHandlers(): void;

      UpdateConnections(): void;

      Update(): void;

      FindConnection(
        connectionId: number
      ): UnityEngine.Networking.NetworkConnection;

      SetConnectionAtIndex(
        conn: UnityEngine.Networking.NetworkConnection
      ): boolean;

      RemoveConnectionAtIndex(connectionId: number): boolean;

      SendBytesTo(
        connectionId: number,
        bytes: System.Byte[],
        numBytes: number,
        channelId: number
      ): void;

      SendWriterTo(
        connectionId: number,
        writer: UnityEngine.Networking.NetworkWriter,
        channelId: number
      ): void;

      Disconnect(connectionId: number): void;

      DisconnectAllConnections(): void;

      OnConnectError(connectionId: number, error: System.Byte): void;

      OnDataError(
        conn: UnityEngine.Networking.NetworkConnection,
        error: System.Byte
      ): void;

      OnDisconnectError(
        conn: UnityEngine.Networking.NetworkConnection,
        error: System.Byte
      ): void;

      OnConnected(conn: UnityEngine.Networking.NetworkConnection): void;

      OnDisconnected(conn: UnityEngine.Networking.NetworkConnection): void;

      OnData(
        conn: UnityEngine.Networking.NetworkConnection,
        receivedSize: number,
        channelId: number
      ): void;
    }
  }
}
