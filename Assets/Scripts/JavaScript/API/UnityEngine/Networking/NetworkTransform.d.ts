declare namespace UnityEngine {
  namespace Networking {
    class NetworkTransform {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      static HandleTransform(
        netMsg: UnityEngine.Networking.NetworkMessage
      ): void;

      static SerializeVelocity3D(
        writer: UnityEngine.Networking.NetworkWriter,
        velocity: UnityEngine.Vector3,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): void;

      static SerializeVelocity2D(
        writer: UnityEngine.Networking.NetworkWriter,
        velocity: UnityEngine.Vector2,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): void;

      static SerializeRotation3D(
        writer: UnityEngine.Networking.NetworkWriter,
        rot: UnityEngine.Quaternion,
        mode: UnityEngine.Networking.NetworkTransform.AxisSyncMode,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): void;

      static SerializeRotation2D(
        writer: UnityEngine.Networking.NetworkWriter,
        rot: number,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): void;

      static SerializeSpin3D(
        writer: UnityEngine.Networking.NetworkWriter,
        angularVelocity: UnityEngine.Vector3,
        mode: UnityEngine.Networking.NetworkTransform.AxisSyncMode,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): void;

      static SerializeSpin2D(
        writer: UnityEngine.Networking.NetworkWriter,
        angularVelocity: number,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): void;

      static UnserializeVelocity3D(
        reader: UnityEngine.Networking.NetworkReader,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): UnityEngine.Vector3;

      static UnserializeVelocity2D(
        reader: UnityEngine.Networking.NetworkReader,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): UnityEngine.Vector3;

      static UnserializeRotation3D(
        reader: UnityEngine.Networking.NetworkReader,
        mode: UnityEngine.Networking.NetworkTransform.AxisSyncMode,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): UnityEngine.Quaternion;

      static UnserializeRotation2D(
        reader: UnityEngine.Networking.NetworkReader,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): number;

      static UnserializeSpin3D(
        reader: UnityEngine.Networking.NetworkReader,
        mode: UnityEngine.Networking.NetworkTransform.AxisSyncMode,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): UnityEngine.Vector3;

      static UnserializeSpin2D(
        reader: UnityEngine.Networking.NetworkReader,
        compression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode
      ): number;

      // Instance Fields

      // Instance Property Accessors

      transformSyncMode: UnityEngine.Networking.NetworkTransform.TransformSyncMode;

      sendInterval: number;

      syncRotationAxis: UnityEngine.Networking.NetworkTransform.AxisSyncMode;

      rotationSyncCompression: UnityEngine.Networking.NetworkTransform.CompressionSyncMode;

      syncSpin: boolean;

      movementTheshold: number;

      velocityThreshold: number;

      snapThreshold: number;

      interpolateRotation: number;

      interpolateMovement: number;

      clientMoveCallback3D: UnityEngine.Networking.NetworkTransform.ClientMoveCallback3D;

      clientMoveCallback2D: UnityEngine.Networking.NetworkTransform.ClientMoveCallback2D;

      readonly characterContoller: UnityEngine.CharacterController;

      readonly rigidbody3D: UnityEngine.Rigidbody;

      readonly rigidbody2D: UnityEngine.Rigidbody2D;

      readonly lastSyncTime: number;

      readonly targetSyncPosition: UnityEngine.Vector3;

      readonly targetSyncVelocity: UnityEngine.Vector3;

      readonly targetSyncRotation3D: UnityEngine.Quaternion;

      readonly targetSyncRotation2D: number;

      grounded: boolean;

      // Instance Methods

      OnStartServer(): void;

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

      OnStartAuthority(): void;
    }
  }
}
