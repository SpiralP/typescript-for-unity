using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSYieldInstruction {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue YieldInstructionPrototype;
      JavaScriptValue YieldInstructionConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.YieldInstruction),
        (args) => { throw new System.NotImplementedException(); },
        out YieldInstructionPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("YieldInstruction", YieldInstructionConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

      // YieldInstruction()

    }
  }
}
