using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSUnityEngine {
    public static void Register(JavaScriptContext context) {
      var UnityEngineGlobal = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.SetProperty("UnityEngine", UnityEngineGlobal);

      // things that don't extend
      JSInput.Register(context);
      JSVector2.Register(context);
      JSVector3.Register(context);
      JSVector4.Register(context);
      JSQuaternion.Register(context);
      JSColor.Register(context);
      JSColor32.Register(context);
      JSSpace.Register(context);
      JSMesh.Register(context);
      JSMatrix4x4.Register(context);
      JSRigidbodyConstraints.Register(context);
      JSRigidbodyInterpolation.Register(context);
      JSPlane.Register(context);
      JSCollisionDetectionMode.Register(context);
      JSHideFlags.Register(context);
      JSBoneWeight.Register(context);
      JSBounds.Register(context);
      JSCombineInstance.Register(context);
      JSForceMode.Register(context);
      JSFrustumPlanes.Register(context);
      JSMeshColliderCookingOptions.Register(context);
      JSMeshTopology.Register(context);
      JSPhysicMaterialCombine.Register(context);
      JSPrimitiveType.Register(context);
      JSQueryTriggerInteraction.Register(context);
      JSSendMessageOptions.Register(context);
      JSCollisionFlags.Register(context);
      JSCursor.Register(context);
      JSCursorLockMode.Register(context);
      JSGUI.Register(context);
      JSRandom.Register(context);
      JSResolution.Register(context);
      JSScreen.Register(context);
      JSSystemInfo.Register(context);
      JSResources.Register(context);
      JSApplication.Register(context);
      JSRuntimePlatform.Register(context);
      JSKeyCode.Register(context);


      JSYieldInstruction.Register(context);
      JSCoroutine.Register(context);
      JSAsyncOperation.Register(context);
      JSAssetBundleRequest.Register(context);
      JSAssetBundleCreateRequest.Register(context);
      JSResourceRequest.Register(context);

      JSPhysics.Register(context);
      JSRay.Register(context); // struct
      JSRaycastHit.Register(context); // struct

      JSObject.Register(context);
      JSComponent.Register(context); // Object
      JSMaterial.Register(context); // Object
      JSGameObject.Register(context); // Object
      JSPhysicMaterial.Register(context); // Object
      JSAssetBundle.Register(context); // Object

      JSBehaviour.Register(context); // Component
      JSMonoBehaviour.Register(context); // Behaviour
      JSCamera.Register(context); // Behaviour

      JSCollider.Register(context); // Component
      JSTransform.Register(context); // Component
      JSRigidbody.Register(context); // Component
      JSRenderer.Register(context); // Component
      JSMeshCollider.Register(context); // Collider
      JSBoxCollider.Register(context); // Collider
      JSCharacterController.Register(context); // Collider

      JavaScript.API.JSUnityEngine.Networking.JSUnityEngineNetworking.Register(context);
      JavaScript.API.JSUnityEngine.EventSystems.Root.Register(context);
    }
  }
}
