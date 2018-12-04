using ChakraCore.API;

namespace JavaScript.API {
  class ChakraInternals {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ChakraGlobal = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.SetProperty("chakra", ChakraGlobal);

      ChakraGlobal.SetProperty(
        "CollectGarbage",
        Bridge.CreateFunction("CollectGarbage", (args) => {
          context.GetRuntime().CollectGarbage();
        })
      );
    }
  }
}
