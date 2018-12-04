declare namespace UnityEngine {
  namespace Networking {
    class NetworkWriter {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      // Instance Property Accessors

      readonly Position: System.Int16;

      // Instance Methods

      ToArray(): System.Byte[];

      AsArray(): System.Byte[];

      WritePackedUInt32(value: System.UInt32): void;

      WritePackedUInt64(value: System.UInt64): void;

      Write(value: UnityEngine.Networking.NetworkInstanceId): void;

      Write(value: UnityEngine.Networking.NetworkSceneId): void;

      Write(value: System.Char): void;

      Write(value: System.Byte): void;

      Write(value: System.SByte): void;

      Write(value: System.Int16): void;

      Write(value: System.UInt16): void;

      Write(value: number): void;

      Write(value: System.UInt32): void;

      Write(value: System.Int64): void;

      Write(value: System.UInt64): void;

      Write(value: number): void;

      Write(value: number): void;

      Write(value: System.Decimal): void;

      Write(value: string): void;

      Write(value: boolean): void;

      Write(buffer: System.Byte[], count: number): void;

      Write(buffer: System.Byte[], offset: number, count: number): void;

      WriteBytesAndSize(buffer: System.Byte[], count: number): void;

      WriteBytesFull(buffer: System.Byte[]): void;

      Write(value: UnityEngine.Vector2): void;

      Write(value: UnityEngine.Vector3): void;

      Write(value: UnityEngine.Vector4): void;

      Write(value: UnityEngine.Color): void;

      Write(value: UnityEngine.Color32): void;

      Write(value: UnityEngine.Quaternion): void;

      Write(value: UnityEngine.Rect): void;

      Write(value: UnityEngine.Plane): void;

      Write(value: UnityEngine.Ray): void;

      Write(value: UnityEngine.Matrix4x4): void;

      Write(value: UnityEngine.Networking.NetworkHash128): void;

      Write(value: UnityEngine.Networking.NetworkIdentity): void;

      Write(value: UnityEngine.Transform): void;

      Write(value: UnityEngine.GameObject): void;

      Write(msg: UnityEngine.Networking.MessageBase): void;

      SeekZero(): void;

      StartMessage(msgType: System.Int16): void;

      FinishMessage(): void;
    }
  }
}
