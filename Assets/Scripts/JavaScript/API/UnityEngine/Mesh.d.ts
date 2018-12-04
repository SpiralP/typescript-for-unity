declare namespace UnityEngine {
  class Mesh extends UnityEngine.Object {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    // indexFormat: UnityEngine.Rendering.IndexFormat;

    readonly vertexBufferCount: number;

    readonly blendShapeCount: number;

    boneWeights: UnityEngine.BoneWeight[];

    bindposes: UnityEngine.Matrix4x4[];

    readonly isReadable: boolean;

    readonly vertexCount: number;

    subMeshCount: number;

    bounds: UnityEngine.Bounds;

    vertices: UnityEngine.Vector3[];

    normals: UnityEngine.Vector3[];

    tangents: UnityEngine.Vector4[];

    uv: UnityEngine.Vector2[];

    uv2: UnityEngine.Vector2[];

    uv3: UnityEngine.Vector2[];

    uv4: UnityEngine.Vector2[];

    uv5: UnityEngine.Vector2[];

    uv6: UnityEngine.Vector2[];

    uv7: UnityEngine.Vector2[];

    uv8: UnityEngine.Vector2[];

    colors: UnityEngine.Color[];

    colors32: UnityEngine.Color32[];

    triangles: System.Int32[];

    // Instance Methods

    GetNativeVertexBufferPtr(index: number): System.IntPtr;

    GetNativeIndexBufferPtr(): System.IntPtr;

    ClearBlendShapes(): void;

    GetBlendShapeName(shapeIndex: number): string;

    GetBlendShapeIndex(blendShapeName: string): number;

    GetBlendShapeFrameCount(shapeIndex: number): number;

    GetBlendShapeFrameWeight(shapeIndex: number, frameIndex: number): number;

    GetBlendShapeFrameVertices(
      shapeIndex: number,
      frameIndex: number,
      deltaVertices: UnityEngine.Vector3[],
      deltaNormals: UnityEngine.Vector3[],
      deltaTangents: UnityEngine.Vector3[]
    ): void;

    AddBlendShapeFrame(
      shapeName: string,
      frameWeight: number,
      deltaVertices: UnityEngine.Vector3[],
      deltaNormals: UnityEngine.Vector3[],
      deltaTangents: UnityEngine.Vector3[]
    ): void;

    GetUVDistributionMetric(uvSetIndex: number): number;

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

    GetTriangles(submesh: number): System.Int32[];

    GetTriangles(submesh: number, applyBaseVertex: boolean): System.Int32[];

    /*
            Mesh GetTriangles
            System.Collections.Generic.List`1[System.Int32] has generics
          */

    /*
            Mesh GetTriangles
            System.Collections.Generic.List`1[System.Int32] has generics
          */

    GetIndices(submesh: number): System.Int32[];

    GetIndices(submesh: number, applyBaseVertex: boolean): System.Int32[];

    /*
            Mesh GetIndices
            System.Collections.Generic.List`1[System.Int32] has generics
          */

    /*
            Mesh GetIndices
            System.Collections.Generic.List`1[System.Int32] has generics
          */

    GetIndexStart(submesh: number): System.UInt32;

    GetIndexCount(submesh: number): System.UInt32;

    GetBaseVertex(submesh: number): System.UInt32;

    SetTriangles(triangles: System.Int32[], submesh: number): void;

    SetTriangles(
      triangles: System.Int32[],
      submesh: number,
      calculateBounds: boolean
    ): void;

    SetTriangles(
      triangles: System.Int32[],
      submesh: number,
      calculateBounds: boolean,
      baseVertex: number
    ): void;

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

    SetIndices(
      indices: System.Int32[],
      topology: UnityEngine.MeshTopology,
      submesh: number
    ): void;

    SetIndices(
      indices: System.Int32[],
      topology: UnityEngine.MeshTopology,
      submesh: number,
      calculateBounds: boolean
    ): void;

    SetIndices(
      indices: System.Int32[],
      topology: UnityEngine.MeshTopology,
      submesh: number,
      calculateBounds: boolean,
      baseVertex: number
    ): void;

    /*
            Mesh GetBindposes
            System.Collections.Generic.List`1[UnityEngine.Matrix4x4] has generics
          */

    /*
            Mesh GetBoneWeights
            System.Collections.Generic.List`1[UnityEngine.BoneWeight] has generics
          */

    Clear(keepVertexLayout: boolean): void;

    Clear(): void;

    RecalculateBounds(): void;

    RecalculateNormals(): void;

    RecalculateTangents(): void;

    MarkDynamic(): void;

    UploadMeshData(markNoLongerReadable: boolean): void;

    GetTopology(submesh: number): UnityEngine.MeshTopology;

    CombineMeshes(
      combine: UnityEngine.CombineInstance[],
      mergeSubMeshes: boolean,
      useMatrices: boolean,
      hasLightmapData: boolean
    ): void;

    CombineMeshes(
      combine: UnityEngine.CombineInstance[],
      mergeSubMeshes: boolean,
      useMatrices: boolean
    ): void;

    CombineMeshes(
      combine: UnityEngine.CombineInstance[],
      mergeSubMeshes: boolean
    ): void;

    CombineMeshes(combine: UnityEngine.CombineInstance[]): void;
  }
}
