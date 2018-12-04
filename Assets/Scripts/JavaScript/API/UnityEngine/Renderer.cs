using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSRenderer {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RendererPrototype;
      JavaScriptValue RendererConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Renderer),
        (args) => { throw new System.NotImplementedException(); },
        out RendererPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Renderer", RendererConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        RendererPrototype,
        "bounds",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.bounds))
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "enabled",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromBoolean(o.enabled)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.enabled = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        RendererPrototype,
        "isVisible",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromBoolean(o.isVisible))
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "shadowCastingMode",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.shadowCastingMode)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.shadowCastingMode = Bridge.GetExternal<UnityEngine.Rendering.ShadowCastingMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "receiveShadows",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromBoolean(o.receiveShadows)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.receiveShadows = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "motionVectorGenerationMode",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.motionVectorGenerationMode)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.motionVectorGenerationMode = Bridge.GetExternal<UnityEngine.MotionVectorGenerationMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "lightProbeUsage",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.lightProbeUsage)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.lightProbeUsage = Bridge.GetExternal<UnityEngine.Rendering.LightProbeUsage>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "reflectionProbeUsage",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.reflectionProbeUsage)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.reflectionProbeUsage = Bridge.GetExternal<UnityEngine.Rendering.ReflectionProbeUsage>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "renderingLayerMask",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.renderingLayerMask)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.renderingLayerMask = Bridge.GetBoxedExternal<System.UInt32>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "sortingLayerName",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromString(o.sortingLayerName)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.sortingLayerName = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "sortingLayerID",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromInt32(o.sortingLayerID)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.sortingLayerID = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "sortingOrder",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromInt32(o.sortingOrder)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.sortingOrder = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "allowOcclusionWhenDynamic",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromBoolean(o.allowOcclusionWhenDynamic)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.allowOcclusionWhenDynamic = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        RendererPrototype,
        "isPartOfStaticBatch",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromBoolean(o.isPartOfStaticBatch))
      );


      Bridge.DefineGetter(
        RendererPrototype,
        "worldToLocalMatrix",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.worldToLocalMatrix))
      );


      Bridge.DefineGetter(
        RendererPrototype,
        "localToWorldMatrix",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.localToWorldMatrix))
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "lightProbeProxyVolumeOverride",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.lightProbeProxyVolumeOverride)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.lightProbeProxyVolumeOverride = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "probeAnchor",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.probeAnchor)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.probeAnchor = Bridge.GetExternal<UnityEngine.Transform>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "lightmapIndex",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromInt32(o.lightmapIndex)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.lightmapIndex = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "realtimeLightmapIndex",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromInt32(o.realtimeLightmapIndex)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.realtimeLightmapIndex = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "lightmapScaleOffset",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.lightmapScaleOffset)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.lightmapScaleOffset = Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "realtimeLightmapScaleOffset",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.realtimeLightmapScaleOffset)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.realtimeLightmapScaleOffset = Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "materials",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.materials)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.materials = Bridge.GetExternal<UnityEngine.Material[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "material",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.material)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.material = Bridge.GetExternal<UnityEngine.Material>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "sharedMaterial",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.sharedMaterial)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.sharedMaterial = Bridge.GetExternal<UnityEngine.Material>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RendererPrototype,
        "sharedMaterials",
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => Bridge.CreateExternalWithPrototype(o.sharedMaterials)),
        Bridge.WithExternal<UnityEngine.Renderer>((o, args) => { o.sharedMaterials = Bridge.GetExternal<UnityEngine.Material[]>(args[1]); })
      );


      // Instance Methods

      RendererPrototype.SetProperty(
        "HasPropertyBlock",
        Bridge.CreateFunction(
          "HasPropertyBlock",
          Bridge.WithExternal<UnityEngine.Renderer>((o, args) => JavaScriptValue.FromBoolean(o.HasPropertyBlock()))
        )
      );


      RendererPrototype.SetProperty(
        "SetPropertyBlock",
        Bridge.CreateFunction(
          "SetPropertyBlock",
          Bridge.WithExternal<UnityEngine.Renderer>((o, args) => o.SetPropertyBlock(Bridge.GetExternal<UnityEngine.MaterialPropertyBlock>(args[1])))
        )
      );


      RendererPrototype.SetProperty(
        "SetPropertyBlock",
        Bridge.CreateFunction(
          "SetPropertyBlock",
          Bridge.WithExternal<UnityEngine.Renderer>((o, args) => o.SetPropertyBlock(Bridge.GetExternal<UnityEngine.MaterialPropertyBlock>(args[1]), args[2].ToInt32()))
        )
      );


      RendererPrototype.SetProperty(
        "GetPropertyBlock",
        Bridge.CreateFunction(
          "GetPropertyBlock",
          Bridge.WithExternal<UnityEngine.Renderer>((o, args) => o.GetPropertyBlock(Bridge.GetExternal<UnityEngine.MaterialPropertyBlock>(args[1])))
        )
      );


      RendererPrototype.SetProperty(
        "GetPropertyBlock",
        Bridge.CreateFunction(
          "GetPropertyBlock",
          Bridge.WithExternal<UnityEngine.Renderer>((o, args) => o.GetPropertyBlock(Bridge.GetExternal<UnityEngine.MaterialPropertyBlock>(args[1]), args[2].ToInt32()))
        )
      );


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
}
