declare namespace UnityEngine {
  namespace Networking {
    class NetworkIdentity {
      // Static Fields

      static clientAuthorityCallback: UnityEngine.Networking.NetworkIdentity.ClientAuthorityCallback;

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      // Instance Property Accessors

      readonly isClient: boolean;

      readonly isServer: boolean;

      readonly hasAuthority: boolean;

      readonly netId: UnityEngine.Networking.NetworkInstanceId;

      readonly sceneId: UnityEngine.Networking.NetworkSceneId;

      serverOnly: boolean;

      localPlayerAuthority: boolean;

      readonly clientAuthorityOwner: UnityEngine.Networking.NetworkConnection;

      readonly assetId: UnityEngine.Networking.NetworkHash128;

      readonly isLocalPlayer: boolean;

      readonly playerControllerId: System.Int16;

      readonly connectionToServer: UnityEngine.Networking.NetworkConnection;

      readonly connectionToClient: UnityEngine.Networking.NetworkConnection;

      /*
            NetworkIdentity observers
            System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEngine.Networking.NetworkConnection] has generics
          */

      // Instance Methods

      ForceSceneId(newSceneId: number): void;

      RebuildObservers(initialize: boolean): void;

      RemoveClientAuthority(
        conn: UnityEngine.Networking.NetworkConnection
      ): boolean;

      AssignClientAuthority(
        conn: UnityEngine.Networking.NetworkConnection
      ): boolean;
    }
  }
}
