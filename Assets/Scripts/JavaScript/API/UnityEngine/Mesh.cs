using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSMesh {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue MeshPrototype;
      JavaScriptValue MeshConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Mesh),
        (args) => { throw new System.NotImplementedException(); },
        out MeshPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Mesh", MeshConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        MeshPrototype,
        "indexFormat",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.indexFormat)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.indexFormat = Bridge.GetExternal<UnityEngine.Rendering.IndexFormat>(args[1]); })
      );


      Bridge.DefineGetter(
        MeshPrototype,
        "vertexBufferCount",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromInt32(o.vertexBufferCount))
      );


      Bridge.DefineGetter(
        MeshPrototype,
        "blendShapeCount",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromInt32(o.blendShapeCount))
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "boneWeights",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.boneWeights)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.boneWeights = Bridge.GetExternal<UnityEngine.BoneWeight[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "bindposes",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.bindposes)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.bindposes = Bridge.GetExternal<UnityEngine.Matrix4x4[]>(args[1]); })
      );


      Bridge.DefineGetter(
        MeshPrototype,
        "isReadable",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromBoolean(o.isReadable))
      );


      Bridge.DefineGetter(
        MeshPrototype,
        "vertexCount",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromInt32(o.vertexCount))
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "subMeshCount",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromInt32(o.subMeshCount)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.subMeshCount = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "bounds",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.bounds)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.bounds = Bridge.GetBoxedExternal<UnityEngine.Bounds>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "vertices",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.vertices)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.vertices = Bridge.GetExternal<UnityEngine.Vector3[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "normals",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.normals)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.normals = Bridge.GetExternal<UnityEngine.Vector3[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "tangents",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.tangents)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.tangents = Bridge.GetExternal<UnityEngine.Vector4[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "uv",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.uv)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.uv = Bridge.GetExternal<UnityEngine.Vector2[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "uv2",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.uv2)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.uv2 = Bridge.GetExternal<UnityEngine.Vector2[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "uv3",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.uv3)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.uv3 = Bridge.GetExternal<UnityEngine.Vector2[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "uv4",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.uv4)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.uv4 = Bridge.GetExternal<UnityEngine.Vector2[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "uv5",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.uv5)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.uv5 = Bridge.GetExternal<UnityEngine.Vector2[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "uv6",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.uv6)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.uv6 = Bridge.GetExternal<UnityEngine.Vector2[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "uv7",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.uv7)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.uv7 = Bridge.GetExternal<UnityEngine.Vector2[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "uv8",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.uv8)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.uv8 = Bridge.GetExternal<UnityEngine.Vector2[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "colors",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.colors)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.colors = Bridge.GetExternal<UnityEngine.Color[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "colors32",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.colors32)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.colors32 = Bridge.GetExternal<UnityEngine.Color32[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshPrototype,
        "triangles",
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.triangles)),
        Bridge.WithExternal<UnityEngine.Mesh>((o, args) => { o.triangles = Bridge.GetExternal<System.Int32[]>(args[1]); })
      );


      // Instance Methods

      MeshPrototype.SetProperty(
        "GetNativeVertexBufferPtr",
        Bridge.CreateFunction(
          "GetNativeVertexBufferPtr",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetNativeVertexBufferPtr(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "GetNativeIndexBufferPtr",
        Bridge.CreateFunction(
          "GetNativeIndexBufferPtr",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetNativeIndexBufferPtr()))
        )
      );


      MeshPrototype.SetProperty(
        "ClearBlendShapes",
        Bridge.CreateFunction(
          "ClearBlendShapes",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.ClearBlendShapes())
        )
      );


      MeshPrototype.SetProperty(
        "GetBlendShapeName",
        Bridge.CreateFunction(
          "GetBlendShapeName",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromString(o.GetBlendShapeName(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "GetBlendShapeIndex",
        Bridge.CreateFunction(
          "GetBlendShapeIndex",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromInt32(o.GetBlendShapeIndex(args[1].ToString())))
        )
      );


      MeshPrototype.SetProperty(
        "GetBlendShapeFrameCount",
        Bridge.CreateFunction(
          "GetBlendShapeFrameCount",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromInt32(o.GetBlendShapeFrameCount(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "GetBlendShapeFrameWeight",
        Bridge.CreateFunction(
          "GetBlendShapeFrameWeight",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromDouble(o.GetBlendShapeFrameWeight(args[1].ToInt32(), args[2].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "GetBlendShapeFrameVertices",
        Bridge.CreateFunction(
          "GetBlendShapeFrameVertices",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.GetBlendShapeFrameVertices(args[1].ToInt32(), args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Vector3[]>(args[3]), Bridge.GetExternal<UnityEngine.Vector3[]>(args[4]), Bridge.GetExternal<UnityEngine.Vector3[]>(args[5])))
        )
      );


      MeshPrototype.SetProperty(
        "AddBlendShapeFrame",
        Bridge.CreateFunction(
          "AddBlendShapeFrame",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.AddBlendShapeFrame(args[1].ToString(), (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.Vector3[]>(args[3]), Bridge.GetExternal<UnityEngine.Vector3[]>(args[4]), Bridge.GetExternal<UnityEngine.Vector3[]>(args[5])))
        )
      );


      MeshPrototype.SetProperty(
        "GetUVDistributionMetric",
        Bridge.CreateFunction(
          "GetUVDistributionMetric",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => JavaScriptValue.FromDouble(o.GetUVDistributionMetric(args[1].ToInt32())))
        )
      );


      /*
        Mesh GetVertices
        System.Collections.Generic.List`1[UnityEngine.Vector3] has generics
      */


      /*
        Mesh SetVertices
        System.Collections.Generic.List`1[UnityEngine.Vector3] has generics
      */


      /*
        Mesh GetNormals
        System.Collections.Generic.List`1[UnityEngine.Vector3] has generics
      */


      /*
        Mesh SetNormals
        System.Collections.Generic.List`1[UnityEngine.Vector3] has generics
      */


      /*
        Mesh GetTangents
        System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
      */


      /*
        Mesh SetTangents
        System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
      */


      /*
        Mesh GetColors
        System.Collections.Generic.List`1[UnityEngine.Color] has generics
      */


      /*
        Mesh SetColors
        System.Collections.Generic.List`1[UnityEngine.Color] has generics
      */


      /*
        Mesh GetColors
        System.Collections.Generic.List`1[UnityEngine.Color32] has generics
      */


      /*
        Mesh SetColors
        System.Collections.Generic.List`1[UnityEngine.Color32] has generics
      */


      /*
        Mesh SetUVs
        System.Collections.Generic.List`1[UnityEngine.Vector2] has generics
      */


      /*
        Mesh SetUVs
        System.Collections.Generic.List`1[UnityEngine.Vector3] has generics
      */


      /*
        Mesh SetUVs
        System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
      */


      /*
        Mesh GetUVs
        System.Collections.Generic.List`1[UnityEngine.Vector2] has generics
      */


      /*
        Mesh GetUVs
        System.Collections.Generic.List`1[UnityEngine.Vector3] has generics
      */


      /*
        Mesh GetUVs
        System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
      */


      MeshPrototype.SetProperty(
        "GetTriangles",
        Bridge.CreateFunction(
          "GetTriangles",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTriangles(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "GetTriangles",
        Bridge.CreateFunction(
          "GetTriangles",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTriangles(args[1].ToInt32(), args[2].ToBoolean())))
        )
      );


      /*
        Mesh GetTriangles
        System.Collections.Generic.List`1[System.Int32] has generics
      */


      /*
        Mesh GetTriangles
        System.Collections.Generic.List`1[System.Int32] has generics
      */


      MeshPrototype.SetProperty(
        "GetIndices",
        Bridge.CreateFunction(
          "GetIndices",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetIndices(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "GetIndices",
        Bridge.CreateFunction(
          "GetIndices",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetIndices(args[1].ToInt32(), args[2].ToBoolean())))
        )
      );


      /*
        Mesh GetIndices
        System.Collections.Generic.List`1[System.Int32] has generics
      */


      /*
        Mesh GetIndices
        System.Collections.Generic.List`1[System.Int32] has generics
      */


      MeshPrototype.SetProperty(
        "GetIndexStart",
        Bridge.CreateFunction(
          "GetIndexStart",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetIndexStart(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "GetIndexCount",
        Bridge.CreateFunction(
          "GetIndexCount",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetIndexCount(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "GetBaseVertex",
        Bridge.CreateFunction(
          "GetBaseVertex",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetBaseVertex(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "SetTriangles",
        Bridge.CreateFunction(
          "SetTriangles",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.SetTriangles(Bridge.GetExternal<System.Int32[]>(args[1]), args[2].ToInt32()))
        )
      );


      MeshPrototype.SetProperty(
        "SetTriangles",
        Bridge.CreateFunction(
          "SetTriangles",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.SetTriangles(Bridge.GetExternal<System.Int32[]>(args[1]), args[2].ToInt32(), args[3].ToBoolean()))
        )
      );


      MeshPrototype.SetProperty(
        "SetTriangles",
        Bridge.CreateFunction(
          "SetTriangles",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.SetTriangles(Bridge.GetExternal<System.Int32[]>(args[1]), args[2].ToInt32(), args[3].ToBoolean(), args[4].ToInt32()))
        )
      );


      /*
        Mesh SetTriangles
        System.Collections.Generic.List`1[System.Int32] has generics
      */


      /*
        Mesh SetTriangles
        System.Collections.Generic.List`1[System.Int32] has generics
      */


      /*
        Mesh SetTriangles
        System.Collections.Generic.List`1[System.Int32] has generics
      */


      MeshPrototype.SetProperty(
        "SetIndices",
        Bridge.CreateFunction(
          "SetIndices",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.SetIndices(Bridge.GetExternal<System.Int32[]>(args[1]), Bridge.GetExternal<UnityEngine.MeshTopology>(args[2]), args[3].ToInt32()))
        )
      );


      MeshPrototype.SetProperty(
        "SetIndices",
        Bridge.CreateFunction(
          "SetIndices",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.SetIndices(Bridge.GetExternal<System.Int32[]>(args[1]), Bridge.GetExternal<UnityEngine.MeshTopology>(args[2]), args[3].ToInt32(), args[4].ToBoolean()))
        )
      );


      MeshPrototype.SetProperty(
        "SetIndices",
        Bridge.CreateFunction(
          "SetIndices",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.SetIndices(Bridge.GetExternal<System.Int32[]>(args[1]), Bridge.GetExternal<UnityEngine.MeshTopology>(args[2]), args[3].ToInt32(), args[4].ToBoolean(), args[5].ToInt32()))
        )
      );


      /*
        Mesh GetBindposes
        System.Collections.Generic.List`1[UnityEngine.Matrix4x4] has generics
      */


      /*
        Mesh GetBoneWeights
        System.Collections.Generic.List`1[UnityEngine.BoneWeight] has generics
      */


      MeshPrototype.SetProperty(
        "Clear",
        Bridge.CreateFunction(
          "Clear",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.Clear(args[1].ToBoolean()))
        )
      );


      MeshPrototype.SetProperty(
        "Clear",
        Bridge.CreateFunction(
          "Clear",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.Clear())
        )
      );


      MeshPrototype.SetProperty(
        "RecalculateBounds",
        Bridge.CreateFunction(
          "RecalculateBounds",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.RecalculateBounds())
        )
      );


      MeshPrototype.SetProperty(
        "RecalculateNormals",
        Bridge.CreateFunction(
          "RecalculateNormals",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.RecalculateNormals())
        )
      );


      MeshPrototype.SetProperty(
        "RecalculateTangents",
        Bridge.CreateFunction(
          "RecalculateTangents",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.RecalculateTangents())
        )
      );


      MeshPrototype.SetProperty(
        "MarkDynamic",
        Bridge.CreateFunction(
          "MarkDynamic",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.MarkDynamic())
        )
      );


      MeshPrototype.SetProperty(
        "UploadMeshData",
        Bridge.CreateFunction(
          "UploadMeshData",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.UploadMeshData(args[1].ToBoolean()))
        )
      );


      MeshPrototype.SetProperty(
        "GetTopology",
        Bridge.CreateFunction(
          "GetTopology",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTopology(args[1].ToInt32())))
        )
      );


      MeshPrototype.SetProperty(
        "CombineMeshes",
        Bridge.CreateFunction(
          "CombineMeshes",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.CombineMeshes(Bridge.GetExternal<UnityEngine.CombineInstance[]>(args[1]), args[2].ToBoolean(), args[3].ToBoolean(), args[4].ToBoolean()))
        )
      );


      MeshPrototype.SetProperty(
        "CombineMeshes",
        Bridge.CreateFunction(
          "CombineMeshes",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.CombineMeshes(Bridge.GetExternal<UnityEngine.CombineInstance[]>(args[1]), args[2].ToBoolean(), args[3].ToBoolean()))
        )
      );


      MeshPrototype.SetProperty(
        "CombineMeshes",
        Bridge.CreateFunction(
          "CombineMeshes",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.CombineMeshes(Bridge.GetExternal<UnityEngine.CombineInstance[]>(args[1]), args[2].ToBoolean()))
        )
      );


      MeshPrototype.SetProperty(
        "CombineMeshes",
        Bridge.CreateFunction(
          "CombineMeshes",
          Bridge.WithExternal<UnityEngine.Mesh>((o, args) => o.CombineMeshes(Bridge.GetExternal<UnityEngine.CombineInstance[]>(args[1])))
        )
      );


    }
  }
}
