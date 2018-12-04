declare namespace UnityEngine {
  namespace Networking {
    class NetworkCRC {
      // Static Fields

      // Static Property Accessors

      static scriptCRCCheck: boolean;

      // Static Methods

      static ReinitializeScriptCRCs(
        callingAssembly: System.Reflection.Assembly
      ): void;

      static RegisterBehaviour(name: string, channel: number): void;

      // Instance Fields

      // Instance Property Accessors

      /*
            NetworkCRC scripts
            System.Collections.Generic.Dictionary`2[System.String,System.Int32] has generics
          */

      // Instance Methods
    }
  }
}
