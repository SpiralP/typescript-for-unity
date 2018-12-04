declare namespace UnityEngine {
  namespace Networking {
    class NetworkAnimator {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      param0: string;

      param1: string;

      param2: string;

      param3: string;

      param4: string;

      param5: string;

      // Instance Property Accessors

      animator: UnityEngine.Animator;

      // Instance Methods

      SetParameterAutoSend(index: number, value: boolean): void;

      GetParameterAutoSend(index: number): boolean;

      OnSerialize(
        writer: UnityEngine.Networking.NetworkWriter,
        forceAll: boolean
      ): boolean;

      OnDeserialize(
        reader: UnityEngine.Networking.NetworkReader,
        initialState: boolean
      ): void;

      SetTrigger(triggerName: string): void;

      SetTrigger(hash: number): void;
    }
  }
}
