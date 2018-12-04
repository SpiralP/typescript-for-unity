declare namespace UnityEngine {
  namespace Networking {
    class PlayerController {
      // Static Fields

      static readonly MaxPlayersPerClient: number;

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      playerControllerId: System.Int16;

      unetView: UnityEngine.Networking.NetworkIdentity;

      gameObject: UnityEngine.GameObject;

      // Instance Property Accessors

      readonly IsValid: boolean;

      // Instance Methods

      toString(): string;
    }
  }
}
