using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSMeshTopology {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue MeshTopologyPrototype;
      JavaScriptValue MeshTopologyConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.MeshTopology),
        (args) => { throw new System.NotImplementedException(); },
        out MeshTopologyPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("MeshTopology", MeshTopologyConstructor);


      // Static Fields

      MeshTopologyConstructor.SetProperty(
        "Triangles",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshTopology.Triangles)
      );


      MeshTopologyConstructor.SetProperty(
        "Quads",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshTopology.Quads)
      );


      MeshTopologyConstructor.SetProperty(
        "Lines",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshTopology.Lines)
      );


      MeshTopologyConstructor.SetProperty(
        "LineStrip",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshTopology.LineStrip)
      );


      MeshTopologyConstructor.SetProperty(
        "Points",
        Bridge.CreateExternalWithPrototype(UnityEngine.MeshTopology.Points)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
