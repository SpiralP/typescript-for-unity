using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine.Networking.PlayerConnection {
  class JSUnityEngineNetworkingPlayerConnection {
    public static void Register(JavaScriptContext context) {
      var UnityEngineNetworkingGlobal = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.GetProperty("UnityEngine").GetProperty("Networking").SetProperty("PlayerConnection", UnityEngineNetworkingGlobal);

      JSMessageEventArgs.Register(context);
      JSPlayerConnection.Register(context);

    }
  }
}
