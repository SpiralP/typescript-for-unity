using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSUnityEngineNetworking {
    public static void Register(JavaScriptContext context) {
      var UnityEngineNetworkingGlobal = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.GetProperty("UnityEngine").SetProperty("Networking", UnityEngineNetworkingGlobal);

      // things that don't extend
      JSGlobalConfig.Register(context);
      JSNetworkBroadcastResult.Register(context); // struct
      JSNetworkCRC.Register(context);
      JSNetworkClient.Register(context);
      JSNetworkConnection.Register(context);
      JSNetworkReader.Register(context);
      JSNetworkServer.Register(context);
      JSNetworkInstanceId.Register(context); // struct
      JSNetworkError.Register(context); // enum
      JSNetworkEventType.Register(context); // enum
      JSNetworkHash128.Register(context); // struct
      JSNetworkMessage.Register(context);
      JSNetworkServerSimple.Register(context);
      JSNetworkTransport.Register(context);
      JSNetworkWriter.Register(context);
      JSPlayerController.Register(context);
      JSPlayerSpawnMethod.Register(context); // enum
      JSQosType.Register(context); // enum
      JSUtility.Register(context);
      JSReactorModel.Register(context); // enum

      JSNetworkBehaviour.Register(context); // MonoBehaviour
      JSNetworkDiscovery.Register(context); // MonoBehaviour
      JSNetworkIdentity.Register(context); // MonoBehaviour
      JSNetworkManager.Register(context); // MonoBehaviour
      JSNetworkStartPosition.Register(context); // MonoBehaviour
      JSNetworkAnimator.Register(context); // NetworkBehaviour
      JSNetworkTransform.Register(context); // NetworkBehaviour
      JSNetworkTransformChild.Register(context); // NetworkBehaviour

      PlayerConnection.JSUnityEngineNetworkingPlayerConnection.Register(context);

    }
  }
}
