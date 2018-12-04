using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSSystemInfo {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue SystemInfoPrototype;
      JavaScriptValue SystemInfoConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.SystemInfo),
        (args) => { throw new System.NotImplementedException(); },
        out SystemInfoPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("SystemInfo", SystemInfoConstructor);


      // Static Fields

      SystemInfoConstructor.SetProperty(
        "unsupportedIdentifier",
        JavaScriptValue.FromString(UnityEngine.SystemInfo.unsupportedIdentifier)
      );


      // Static Property Accessors

      Bridge.DefineGetter(
        SystemInfoConstructor,
        "batteryLevel",
        (args) => JavaScriptValue.FromDouble(UnityEngine.SystemInfo.batteryLevel)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "batteryStatus",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.SystemInfo.batteryStatus)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "operatingSystem",
        (args) => JavaScriptValue.FromString(UnityEngine.SystemInfo.operatingSystem)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "operatingSystemFamily",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.SystemInfo.operatingSystemFamily)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "processorType",
        (args) => JavaScriptValue.FromString(UnityEngine.SystemInfo.processorType)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "processorFrequency",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.processorFrequency)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "processorCount",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.processorCount)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "systemMemorySize",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.systemMemorySize)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "deviceUniqueIdentifier",
        (args) => JavaScriptValue.FromString(UnityEngine.SystemInfo.deviceUniqueIdentifier)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "deviceName",
        (args) => JavaScriptValue.FromString(UnityEngine.SystemInfo.deviceName)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "deviceModel",
        (args) => JavaScriptValue.FromString(UnityEngine.SystemInfo.deviceModel)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsAccelerometer",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsAccelerometer)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsGyroscope",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsGyroscope)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsLocationService",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsLocationService)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsVibration",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsVibration)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsAudio",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsAudio)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "deviceType",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.SystemInfo.deviceType)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsMemorySize",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.graphicsMemorySize)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsDeviceName",
        (args) => JavaScriptValue.FromString(UnityEngine.SystemInfo.graphicsDeviceName)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsDeviceVendor",
        (args) => JavaScriptValue.FromString(UnityEngine.SystemInfo.graphicsDeviceVendor)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsDeviceID",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.graphicsDeviceID)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsDeviceVendorID",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.graphicsDeviceVendorID)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsDeviceType",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.SystemInfo.graphicsDeviceType)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsUVStartsAtTop",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.graphicsUVStartsAtTop)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsDeviceVersion",
        (args) => JavaScriptValue.FromString(UnityEngine.SystemInfo.graphicsDeviceVersion)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsShaderLevel",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.graphicsShaderLevel)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "graphicsMultiThreaded",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.graphicsMultiThreaded)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsShadows",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsShadows)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsRawShadowDepthSampling",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsRawShadowDepthSampling)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsMotionVectors",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsMotionVectors)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsRenderToCubemap",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsRenderToCubemap)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsImageEffects",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsImageEffects)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supports3DTextures",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supports3DTextures)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supports2DArrayTextures",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supports2DArrayTextures)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supports3DRenderTextures",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supports3DRenderTextures)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsCubemapArrayTextures",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsCubemapArrayTextures)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "copyTextureSupport",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.SystemInfo.copyTextureSupport)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsComputeShaders",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsComputeShaders)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsInstancing",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsInstancing)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsHardwareQuadTopology",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsHardwareQuadTopology)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supports32bitsIndexBuffer",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supports32bitsIndexBuffer)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsSparseTextures",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsSparseTextures)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportedRenderTargetCount",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.supportedRenderTargetCount)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsMultisampledTextures",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.supportsMultisampledTextures)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsMultisampleAutoResolve",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsMultisampleAutoResolve)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsTextureWrapMirrorOnce",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.supportsTextureWrapMirrorOnce)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "usesReversedZBuffer",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.usesReversedZBuffer)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "npotSupport",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.SystemInfo.npotSupport)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "maxTextureSize",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.maxTextureSize)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "maxCubemapSize",
        (args) => JavaScriptValue.FromInt32(UnityEngine.SystemInfo.maxCubemapSize)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsAsyncCompute",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsAsyncCompute)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsGPUFence",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsGPUFence)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsAsyncGPUReadback",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsAsyncGPUReadback)
      );


      Bridge.DefineGetter(
        SystemInfoConstructor,
        "supportsMipStreaming",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.supportsMipStreaming)
      );


      // Static Methods

      SystemInfoConstructor.SetProperty(
        "SupportsRenderTextureFormat",
        Bridge.CreateFunction(
          "SupportsRenderTextureFormat",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.SupportsRenderTextureFormat(Bridge.GetExternal<UnityEngine.RenderTextureFormat>(args[1])))
        )
      );


      SystemInfoConstructor.SetProperty(
        "SupportsBlendingOnRenderTextureFormat",
        Bridge.CreateFunction(
          "SupportsBlendingOnRenderTextureFormat",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.SupportsBlendingOnRenderTextureFormat(Bridge.GetExternal<UnityEngine.RenderTextureFormat>(args[1])))
        )
      );


      SystemInfoConstructor.SetProperty(
        "SupportsTextureFormat",
        Bridge.CreateFunction(
          "SupportsTextureFormat",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.SupportsTextureFormat(Bridge.GetExternal<UnityEngine.TextureFormat>(args[1])))
        )
      );


      SystemInfoConstructor.SetProperty(
        "IsFormatSupported",
        Bridge.CreateFunction(
          "IsFormatSupported",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.SystemInfo.IsFormatSupported(Bridge.GetExternal<UnityEngine.Experimental.Rendering.GraphicsFormat>(args[1]), Bridge.GetExternal<UnityEngine.Experimental.Rendering.FormatUsage>(args[2])))
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
