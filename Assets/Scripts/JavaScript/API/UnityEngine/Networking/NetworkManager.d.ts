declare namespace UnityEngine {
  namespace Networking {
    class NetworkManager {
      // Static Fields

      static networkSceneName: string;

      static singleton: UnityEngine.Networking.NetworkManager;

      // Static Property Accessors

      // Static Methods

      static RegisterStartPosition(start: UnityEngine.Transform): void;

      static UnRegisterStartPosition(start: UnityEngine.Transform): void;

      static Shutdown(): void;

      // Instance Fields

      matchName: string;

      matchSize: System.UInt32;

      isNetworkActive: boolean;

      client: UnityEngine.Networking.NetworkClient;

      matchInfo: UnityEngine.Networking.Match.MatchInfo;

      matchMaker: UnityEngine.Networking.Match.NetworkMatch;

      /*
            NetworkManager matches
            System.Collections.Generic.List`1[UnityEngine.Networking.Match.MatchInfoSnapshot] has generics
          */

      // Instance Property Accessors

      networkPort: number;

      serverBindToIP: boolean;

      serverBindAddress: string;

      networkAddress: string;

      dontDestroyOnLoad: boolean;

      runInBackground: boolean;

      scriptCRCCheck: boolean;

      maxDelay: number;

      logLevel: UnityEngine.Networking.LogFilter.FilterLevel;

      playerPrefab: UnityEngine.GameObject;

      autoCreatePlayer: boolean;

      playerSpawnMethod: UnityEngine.Networking.PlayerSpawnMethod;

      offlineScene: string;

      onlineScene: string;

      /*
            NetworkManager spawnPrefabs
            System.Collections.Generic.List`1[UnityEngine.GameObject] has generics
          */

      /*
            NetworkManager startPositions
            System.Collections.Generic.List`1[UnityEngine.Transform] has generics
          */

      customConfig: boolean;

      readonly connectionConfig: UnityEngine.Networking.ConnectionConfig;

      readonly globalConfig: UnityEngine.Networking.GlobalConfig;

      maxConnections: number;

      /*
            NetworkManager channels
            System.Collections.Generic.List`1[UnityEngine.Networking.QosType] has generics
          */

      secureTunnelEndpoint: System.Net.EndPoint;

      useWebSockets: boolean;

      useSimulator: boolean;

      simulatedLatency: number;

      packetLossPercentage: number;

      matchHost: string;

      matchPort: number;

      clientLoadedScene: boolean;

      readonly migrationManager: UnityEngine.Networking.NetworkMigrationManager;

      readonly numPlayers: number;

      // Instance Methods

      SetupMigrationManager(
        man: UnityEngine.Networking.NetworkMigrationManager
      ): void;

      StartServer(
        config: UnityEngine.Networking.ConnectionConfig,
        maxConnections: number
      ): boolean;

      StartServer(): boolean;

      StartServer(info: UnityEngine.Networking.Match.MatchInfo): boolean;

      UseExternalClient(
        externalClient: UnityEngine.Networking.NetworkClient
      ): void;

      StartClient(
        info: UnityEngine.Networking.Match.MatchInfo,
        config: UnityEngine.Networking.ConnectionConfig,
        hostPort: number
      ): UnityEngine.Networking.NetworkClient;

      StartClient(
        matchInfo: UnityEngine.Networking.Match.MatchInfo
      ): UnityEngine.Networking.NetworkClient;

      StartClient(): UnityEngine.Networking.NetworkClient;

      StartClient(
        info: UnityEngine.Networking.Match.MatchInfo,
        config: UnityEngine.Networking.ConnectionConfig
      ): UnityEngine.Networking.NetworkClient;

      StartHost(
        config: UnityEngine.Networking.ConnectionConfig,
        maxConnections: number
      ): UnityEngine.Networking.NetworkClient;

      StartHost(
        info: UnityEngine.Networking.Match.MatchInfo
      ): UnityEngine.Networking.NetworkClient;

      StartHost(): UnityEngine.Networking.NetworkClient;

      StopHost(): void;

      StopServer(): void;

      StopClient(): void;

      ServerChangeScene(newSceneName: string): void;

      IsClientConnected(): boolean;

      OnServerConnect(conn: UnityEngine.Networking.NetworkConnection): void;

      OnServerDisconnect(conn: UnityEngine.Networking.NetworkConnection): void;

      OnServerReady(conn: UnityEngine.Networking.NetworkConnection): void;

      OnServerAddPlayer(
        conn: UnityEngine.Networking.NetworkConnection,
        playerControllerId: System.Int16,
        extraMessageReader: UnityEngine.Networking.NetworkReader
      ): void;

      OnServerAddPlayer(
        conn: UnityEngine.Networking.NetworkConnection,
        playerControllerId: System.Int16
      ): void;

      GetStartPosition(): UnityEngine.Transform;

      OnServerRemovePlayer(
        conn: UnityEngine.Networking.NetworkConnection,
        player: UnityEngine.Networking.PlayerController
      ): void;

      OnServerError(
        conn: UnityEngine.Networking.NetworkConnection,
        errorCode: number
      ): void;

      OnServerSceneChanged(sceneName: string): void;

      OnClientConnect(conn: UnityEngine.Networking.NetworkConnection): void;

      OnClientDisconnect(conn: UnityEngine.Networking.NetworkConnection): void;

      OnClientError(
        conn: UnityEngine.Networking.NetworkConnection,
        errorCode: number
      ): void;

      OnClientNotReady(conn: UnityEngine.Networking.NetworkConnection): void;

      OnClientSceneChanged(
        conn: UnityEngine.Networking.NetworkConnection
      ): void;

      StartMatchMaker(): void;

      StopMatchMaker(): void;

      SetMatchHost(newHost: string, port: number, https: boolean): void;

      OnStartHost(): void;

      OnStartServer(): void;

      OnStartClient(client: UnityEngine.Networking.NetworkClient): void;

      OnStopServer(): void;

      OnStopClient(): void;

      OnStopHost(): void;

      OnMatchCreate(
        success: boolean,
        extendedInfo: string,
        matchInfo: UnityEngine.Networking.Match.MatchInfo
      ): void;

      /*
            NetworkManager OnMatchList
            System.Collections.Generic.List`1[UnityEngine.Networking.Match.MatchInfoSnapshot] has generics
          */

      OnMatchJoined(
        success: boolean,
        extendedInfo: string,
        matchInfo: UnityEngine.Networking.Match.MatchInfo
      ): void;

      OnDestroyMatch(success: boolean, extendedInfo: string): void;

      OnDropConnection(success: boolean, extendedInfo: string): void;

      OnSetMatchAttributes(success: boolean, extendedInfo: string): void;
    }
  }
}
