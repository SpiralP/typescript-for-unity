declare namespace UnityEngine {
  namespace Networking {
    class NetworkInstanceId {
      // Static Fields

      static Invalid: UnityEngine.Networking.NetworkInstanceId;

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      // Instance Property Accessors

      readonly Value: System.UInt32;

      // Instance Methods

      IsEmpty(): boolean;

      GetHashCode(): number;

      Equals(obj: System.Object): boolean;

      Equals(other: UnityEngine.Networking.NetworkInstanceId): boolean;

      toString(): string;
    }
  }
}
