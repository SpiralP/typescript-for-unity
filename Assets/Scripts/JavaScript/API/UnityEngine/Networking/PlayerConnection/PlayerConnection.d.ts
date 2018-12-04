declare namespace UnityEngine {
  namespace Networking {
    namespace PlayerConnection {
      class PlayerConnection {
        // Static Fields

        // Static Property Accessors

        static readonly instance: UnityEngine.Networking.PlayerConnection.PlayerConnection;

        // Static Methods

        // Instance Fields

        // Instance Property Accessors

        readonly isConnected: boolean;

        // Instance Methods

        OnEnable(): void;

        /*
            PlayerConnection Register
            UnityEngine.Events.UnityAction`1[UnityEngine.Networking.PlayerConnection.MessageEventArgs] has generics
          */

        /*
            PlayerConnection Unregister
            UnityEngine.Events.UnityAction`1[UnityEngine.Networking.PlayerConnection.MessageEventArgs] has generics
          */

        /*
            PlayerConnection RegisterConnection
            UnityEngine.Events.UnityAction`1[System.Int32] has generics
          */

        /*
            PlayerConnection RegisterDisconnection
            UnityEngine.Events.UnityAction`1[System.Int32] has generics
          */

        Send(messageId: System.Guid, data: System.Byte[]): void;

        BlockUntilRecvMsg(messageId: System.Guid, timeout: number): boolean;

        DisconnectAll(): void;
      }
    }
  }
}
