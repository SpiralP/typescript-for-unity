declare namespace UnityEngine {
  class Renderer {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    readonly bounds: UnityEngine.Bounds;

    enabled: boolean;

    readonly isVisible: boolean;

    shadowCastingMode: UnityEngine.Rendering.ShadowCastingMode;

    receiveShadows: boolean;

    motionVectorGenerationMode: UnityEngine.MotionVectorGenerationMode;

    lightProbeUsage: UnityEngine.Rendering.LightProbeUsage;

    reflectionProbeUsage: UnityEngine.Rendering.ReflectionProbeUsage;

    renderingLayerMask: System.UInt32;

    sortingLayerName: string;

    sortingLayerID: number;

    sortingOrder: number;

    allowOcclusionWhenDynamic: boolean;

    readonly isPartOfStaticBatch: boolean;

    readonly worldToLocalMatrix: UnityEngine.Matrix4x4;

    readonly localToWorldMatrix: UnityEngine.Matrix4x4;

    lightProbeProxyVolumeOverride: UnityEngine.GameObject;

    probeAnchor: UnityEngine.Transform;

    lightmapIndex: number;

    realtimeLightmapIndex: number;

    lightmapScaleOffset: UnityEngine.Vector4;

    realtimeLightmapScaleOffset: UnityEngine.Vector4;

    materials: UnityEngine.Material[];

    material: UnityEngine.Material;

    sharedMaterial: UnityEngine.Material;

    sharedMaterials: UnityEngine.Material[];

    // Instance Methods

    HasPropertyBlock(): boolean;

    SetPropertyBlock(properties: UnityEngine.MaterialPropertyBlock): void;

    SetPropertyBlock(
      properties: UnityEngine.MaterialPropertyBlock,
      materialIndex: number
    ): void;

    GetPropertyBlock(properties: UnityEngine.MaterialPropertyBlock): void;

    GetPropertyBlock(
      properties: UnityEngine.MaterialPropertyBlock,
      materialIndex: number
    ): void;

    /*
            Renderer GetMaterials
            System.Collections.Generic.List`1[UnityEngine.Material] has generics
          */

    /*
            Renderer GetSharedMaterials
            System.Collections.Generic.List`1[UnityEngine.Material] has generics
          */

    /*
            Renderer GetClosestReflectionProbes
            System.Collections.Generic.List`1[UnityEngine.Rendering.ReflectionProbeBlendInfo] has generics
          */
  }
}
