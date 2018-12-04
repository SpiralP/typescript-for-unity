declare namespace UnityEngine {
  namespace Networking {
    class Utility {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      static GetSourceID(): UnityEngine.Networking.Types.SourceID;

      static SetAccessTokenForNetwork(
        netId: UnityEngine.Networking.Types.NetworkID,
        accessToken: UnityEngine.Networking.Types.NetworkAccessToken
      ): void;

      static GetAccessTokenForNetwork(
        netId: UnityEngine.Networking.Types.NetworkID
      ): UnityEngine.Networking.Types.NetworkAccessToken;

      // Instance Fields

      // Instance Property Accessors

      // Instance Methods
    }
  }
}
