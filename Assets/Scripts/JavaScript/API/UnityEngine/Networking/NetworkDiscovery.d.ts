declare namespace UnityEngine {
  namespace Networking {
    class NetworkDiscovery {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      // Instance Property Accessors

      broadcastPort: number;

      broadcastKey: number;

      broadcastVersion: number;

      broadcastSubVersion: number;

      broadcastInterval: number;

      useNetworkManager: boolean;

      broadcastData: string;

      showGUI: boolean;

      offsetX: number;

      offsetY: number;

      hostId: number;

      running: boolean;

      isServer: boolean;

      isClient: boolean;

      /*
            NetworkDiscovery broadcastsReceived
            System.Collections.Generic.Dictionary`2[System.String,UnityEngine.Networking.NetworkBroadcastResult] has generics
          */

      // Instance Methods

      Initialize(): boolean;

      StartAsClient(): boolean;

      StartAsServer(): boolean;

      StopBroadcast(): void;

      OnReceivedBroadcast(fromAddress: string, data: string): void;
    }
  }
}
