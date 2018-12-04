using ChakraCore.API;

namespace JavaScript.API.JSSystem {
  class JSSystem {
    public static void Register(JavaScriptContext context) {
      var SystemGlobal = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.SetProperty("System", SystemGlobal);

      // things that don't extend
      JSObject.Register(context);

      Collections.JSSystemCollections.Register(context);

    }
  }
}
