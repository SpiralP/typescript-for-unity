declare namespace UnityEngine {
  namespace Networking {
    class NetworkMessage {
      // Static Fields

      static readonly MaxMessageSize: number;

      // Static Property Accessors

      // Static Methods

      static Dump(payload: System.Byte[], sz: number): string;

      // Instance Fields

      msgType: System.Int16;

      conn: UnityEngine.Networking.NetworkConnection;

      reader: UnityEngine.Networking.NetworkReader;

      channelId: number;

      // Instance Property Accessors

      // Instance Methods

      /*
            NetworkMessage ReadMessage
            method has generics
          */

      /*
            NetworkMessage ReadMessage
            method has generics
          */
    }
  }
}
