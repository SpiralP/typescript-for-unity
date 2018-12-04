using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEditor {
  class JSModelImporterMeshCompression {
    public static void Register(JavaScriptContext context) {

#if UNITY_EDITOR
      JavaScriptValue ModelImporterMeshCompressionPrototype;
      JavaScriptValue ModelImporterMeshCompressionConstructor = Bridge.CreateConstructor(
        typeof(UnityEditor.ModelImporterMeshCompression),
        (args) => { throw new NotImplementedException(); },
        out ModelImporterMeshCompressionPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEditor")
        .SetProperty("ModelImporterMeshCompression", ModelImporterMeshCompressionConstructor);


      // Static Fields

      ModelImporterMeshCompressionConstructor.SetProperty(
        "Off",
        Bridge.CreateExternalWithPrototype(UnityEditor.ModelImporterMeshCompression.Off)
      );


      ModelImporterMeshCompressionConstructor.SetProperty(
        "Low",
        Bridge.CreateExternalWithPrototype(UnityEditor.ModelImporterMeshCompression.Low)
      );


      ModelImporterMeshCompressionConstructor.SetProperty(
        "Medium",
        Bridge.CreateExternalWithPrototype(UnityEditor.ModelImporterMeshCompression.Medium)
      );


      ModelImporterMeshCompressionConstructor.SetProperty(
        "High",
        Bridge.CreateExternalWithPrototype(UnityEditor.ModelImporterMeshCompression.High)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

#endif

    }
  }
}
