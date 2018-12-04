declare namespace UnityEngine {
  namespace Networking {
    class NetworkConnection {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      hostId: number;

      connectionId: number;

      isReady: boolean;

      address: string;

      lastMessageTime: number;

      logNetworkMessages: boolean;

      // Instance Property Accessors

      /*
            NetworkConnection playerControllers
            System.Collections.Generic.List`1[UnityEngine.Networking.PlayerController] has generics
          */

      /*
            NetworkConnection clientOwnedObjects
            System.Collections.Generic.HashSet`1[UnityEngine.Networking.NetworkInstanceId] has generics
          */

      readonly isConnected: boolean;

      lastError: UnityEngine.Networking.NetworkError;

      // Instance Methods

      Initialize(
        networkAddress: string,
        networkHostId: number,
        networkConnectionId: number,
        hostTopology: UnityEngine.Networking.HostTopology
      ): void;

      Dispose(): void;

      SetChannelOption(
        channelId: number,
        option: UnityEngine.Networking.ChannelOption,
        value: number
      ): boolean;

      Disconnect(): void;

      CheckHandler(msgType: System.Int16): boolean;

      InvokeHandlerNoData(msgType: System.Int16): boolean;

      InvokeHandler(
        msgType: System.Int16,
        reader: UnityEngine.Networking.NetworkReader,
        channelId: number
      ): boolean;

      InvokeHandler(netMsg: UnityEngine.Networking.NetworkMessage): boolean;

      RegisterHandler(
        msgType: System.Int16,
        handler: UnityEngine.Networking.NetworkMessageDelegate
      ): void;

      UnregisterHandler(msgType: System.Int16): void;

      FlushChannels(): void;

      SetMaxDelay(seconds: number): void;

      Send(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): boolean;

      SendUnreliable(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase
      ): boolean;

      SendByChannel(
        msgType: System.Int16,
        msg: UnityEngine.Networking.MessageBase,
        channelId: number
      ): boolean;

      SendBytes(
        bytes: System.Byte[],
        numBytes: number,
        channelId: number
      ): boolean;

      SendWriter(
        writer: UnityEngine.Networking.NetworkWriter,
        channelId: number
      ): boolean;

      ResetStats(): void;

      /*
            NetworkConnection GetStatsOut
            parameter numMsgs is out
          */

      /*
            NetworkConnection GetStatsIn
            parameter numMsgs is out
          */

      toString(): string;

      TransportReceive(
        bytes: System.Byte[],
        numBytes: number,
        channelId: number
      ): void;

      /*
            NetworkConnection TransportSend
            parameter error is out
          */
    }
  }
}
