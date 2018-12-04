using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSPhysicMaterialCombine {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PhysicMaterialCombinePrototype;
      JavaScriptValue PhysicMaterialCombineConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.PhysicMaterialCombine),
        (args) => { throw new System.NotImplementedException(); },
        out PhysicMaterialCombinePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("PhysicMaterialCombine", PhysicMaterialCombineConstructor);


      // Static Fields

      PhysicMaterialCombineConstructor.SetProperty(
        "Average",
        Bridge.CreateExternalWithPrototype(UnityEngine.PhysicMaterialCombine.Average)
      );


      PhysicMaterialCombineConstructor.SetProperty(
        "Minimum",
        Bridge.CreateExternalWithPrototype(UnityEngine.PhysicMaterialCombine.Minimum)
      );


      PhysicMaterialCombineConstructor.SetProperty(
        "Multiply",
        Bridge.CreateExternalWithPrototype(UnityEngine.PhysicMaterialCombine.Multiply)
      );


      PhysicMaterialCombineConstructor.SetProperty(
        "Maximum",
        Bridge.CreateExternalWithPrototype(UnityEngine.PhysicMaterialCombine.Maximum)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
