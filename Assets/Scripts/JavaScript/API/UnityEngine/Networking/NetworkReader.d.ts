declare namespace UnityEngine {
  namespace Networking {
    class NetworkReader {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      // Instance Property Accessors

      readonly Position: System.UInt32;

      readonly Length: number;

      // Instance Methods

      SeekZero(): void;

      ReadPackedUInt32(): System.UInt32;

      ReadPackedUInt64(): System.UInt64;

      ReadNetworkId(): UnityEngine.Networking.NetworkInstanceId;

      ReadSceneId(): UnityEngine.Networking.NetworkSceneId;

      ReadByte(): System.Byte;

      ReadSByte(): System.SByte;

      ReadInt16(): System.Int16;

      ReadUInt16(): System.UInt16;

      ReadInt32(): number;

      ReadUInt32(): System.UInt32;

      ReadInt64(): System.Int64;

      ReadUInt64(): System.UInt64;

      ReadDecimal(): System.Decimal;

      ReadSingle(): number;

      ReadDouble(): number;

      ReadString(): string;

      ReadChar(): System.Char;

      ReadBoolean(): boolean;

      ReadBytes(count: number): System.Byte[];

      ReadBytesAndSize(): System.Byte[];

      ReadVector2(): UnityEngine.Vector2;

      ReadVector3(): UnityEngine.Vector3;

      ReadVector4(): UnityEngine.Vector4;

      ReadColor(): UnityEngine.Color;

      ReadColor32(): UnityEngine.Color32;

      ReadQuaternion(): UnityEngine.Quaternion;

      ReadRect(): UnityEngine.Rect;

      ReadPlane(): UnityEngine.Plane;

      ReadRay(): UnityEngine.Ray;

      ReadMatrix4x4(): UnityEngine.Matrix4x4;

      ReadNetworkHash128(): UnityEngine.Networking.NetworkHash128;

      ReadTransform(): UnityEngine.Transform;

      ReadGameObject(): UnityEngine.GameObject;

      ReadNetworkIdentity(): UnityEngine.Networking.NetworkIdentity;

      toString(): string;

      /*
            NetworkReader ReadMessage
            method has generics
          */
    }
  }
}
