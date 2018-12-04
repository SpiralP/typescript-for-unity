declare namespace UnityEngine {
  namespace Networking {
    class NetworkBehaviour extends MonoBehaviour {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      // Instance Property Accessors

      readonly localPlayerAuthority: boolean;

      readonly isServer: boolean;

      readonly isClient: boolean;

      readonly isLocalPlayer: boolean;

      readonly hasAuthority: boolean;

      readonly netId: UnityEngine.Networking.NetworkInstanceId;

      readonly connectionToServer: UnityEngine.Networking.NetworkConnection;

      readonly connectionToClient: UnityEngine.Networking.NetworkConnection;

      readonly playerControllerId: System.Int16;

      // Instance Methods

      InvokeCommand(
        cmdHash: number,
        reader: UnityEngine.Networking.NetworkReader
      ): boolean;

      InvokeRPC(
        cmdHash: number,
        reader: UnityEngine.Networking.NetworkReader
      ): boolean;

      InvokeSyncEvent(
        cmdHash: number,
        reader: UnityEngine.Networking.NetworkReader
      ): boolean;

      InvokeSyncList(
        cmdHash: number,
        reader: UnityEngine.Networking.NetworkReader
      ): boolean;

      SetDirtyBit(dirtyBit: System.UInt32): void;

      ClearAllDirtyBits(): void;

      OnSerialize(
        writer: UnityEngine.Networking.NetworkWriter,
        initialState: boolean
      ): boolean;

      OnDeserialize(
        reader: UnityEngine.Networking.NetworkReader,
        initialState: boolean
      ): void;

      PreStartClient(): void;

      OnNetworkDestroy(): void;

      OnStartServer(): void;

      OnStartClient(): void;

      OnStartLocalPlayer(): void;

      OnStartAuthority(): void;

      OnStopAuthority(): void;

      /*
            NetworkBehaviour OnRebuildObservers
            System.Collections.Generic.HashSet`1[UnityEngine.Networking.NetworkConnection] has generics
          */

      OnSetLocalVisibility(vis: boolean): void;

      OnCheckObserver(conn: UnityEngine.Networking.NetworkConnection): boolean;

      GetNetworkChannel(): number;

      GetNetworkSendInterval(): number;
    }
  }
}
