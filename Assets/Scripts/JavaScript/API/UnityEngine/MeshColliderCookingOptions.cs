using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSMeshColliderCookingOptions {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue MeshColliderCookingOptionsPrototype;
      JavaScriptValue MeshColliderCookingOptionsConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.MeshColliderCookingOptions),
        (args) => { throw new System.NotImplementedException(); },
        out MeshColliderCookingOptionsPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("MeshColliderCookingOptions", MeshColliderCookingOptionsConstructor);


      // Static Fields

      MeshColliderCookingOptionsConstructor.SetProperty(
        "None",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshColliderCookingOptions.None)
      );


      MeshColliderCookingOptionsConstructor.SetProperty(
        "InflateConvexMesh",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshColliderCookingOptions.InflateConvexMesh)
      );


      MeshColliderCookingOptionsConstructor.SetProperty(
        "CookForFasterSimulation",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshColliderCookingOptions.CookForFasterSimulation)
      );


      MeshColliderCookingOptionsConstructor.SetProperty(
        "EnableMeshCleaning",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshColliderCookingOptions.EnableMeshCleaning)
      );


      MeshColliderCookingOptionsConstructor.SetProperty(
        "WeldColocatedVertices",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshColliderCookingOptions.WeldColocatedVertices)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
