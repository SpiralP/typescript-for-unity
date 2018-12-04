declare namespace UnityEngine {
  namespace Networking {
    class NetworkTransformChild {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      // Instance Property Accessors

      target: UnityEngine.Transform;

      readonly childIndex: System.UInt32;

      sendInterval: number;

      syncRotationAxis: UnityEngine.Networking.NetworkTransform.AxisSyncMode;

      rotationSyncCompression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode;

      movementThreshold: number;

      interpolateRotation: number;

      interpolateMovement: number;

      clientMoveCallback3D: UnityEngine.Networking.NetworkTransform.ClientMoveCallback3D;

      readonly lastSyncTime: number;

      readonly targetSyncPosition: UnityEngine.Vector3;

      readonly targetSyncRotation3D: UnityEngine.Quaternion;

      // Instance Methods

      OnSerialize(
        writer: UnityEngine.Networking.NetworkWriter,
        initialState: boolean
      ): boolean;

      OnDeserialize(
        reader: UnityEngine.Networking.NetworkReader,
        initialState: boolean
      ): void;

      GetNetworkChannel(): number;

      GetNetworkSendInterval(): number;
    }
  }
}
