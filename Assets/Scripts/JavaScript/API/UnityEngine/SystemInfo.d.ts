declare namespace UnityEngine {
  class SystemInfo {
    // Static Fields

    static readonly unsupportedIdentifier: string;

    // Static Property Accessors

    static readonly batteryLevel: number;

    static readonly batteryStatus: UnityEngine.BatteryStatus;

    static readonly operatingSystem: string;

    static readonly operatingSystemFamily: UnityEngine.OperatingSystemFamily;

    static readonly processorType: string;

    static readonly processorFrequency: number;

    static readonly processorCount: number;

    static readonly systemMemorySize: number;

    static readonly deviceUniqueIdentifier: string;

    static readonly deviceName: string;

    static readonly deviceModel: string;

    static readonly supportsAccelerometer: boolean;

    static readonly supportsGyroscope: boolean;

    static readonly supportsLocationService: boolean;

    static readonly supportsVibration: boolean;

    static readonly supportsAudio: boolean;

    static readonly deviceType: UnityEngine.DeviceType;

    static readonly graphicsMemorySize: number;

    static readonly graphicsDeviceName: string;

    static readonly graphicsDeviceVendor: string;

    static readonly graphicsDeviceID: number;

    static readonly graphicsDeviceVendorID: number;

    static readonly graphicsDeviceType: UnityEngine.Rendering.GraphicsDeviceType;

    static readonly graphicsUVStartsAtTop: boolean;

    static readonly graphicsDeviceVersion: string;

    static readonly graphicsShaderLevel: number;

    static readonly graphicsMultiThreaded: boolean;

    static readonly supportsShadows: boolean;

    static readonly supportsRawShadowDepthSampling: boolean;

    static readonly supportsMotionVectors: boolean;

    static readonly supportsRenderToCubemap: boolean;

    static readonly supportsImageEffects: boolean;

    static readonly supports3DTextures: boolean;

    static readonly supports2DArrayTextures: boolean;

    static readonly supports3DRenderTextures: boolean;

    static readonly supportsCubemapArrayTextures: boolean;

    static readonly copyTextureSupport: UnityEngine.Rendering.CopyTextureSupport;

    static readonly supportsComputeShaders: boolean;

    static readonly supportsInstancing: boolean;

    static readonly supportsHardwareQuadTopology: boolean;

    static readonly supports32bitsIndexBuffer: boolean;

    static readonly supportsSparseTextures: boolean;

    static readonly supportedRenderTargetCount: number;

    static readonly supportsMultisampledTextures: number;

    static readonly supportsMultisampleAutoResolve: boolean;

    static readonly supportsTextureWrapMirrorOnce: number;

    static readonly usesReversedZBuffer: boolean;

    static readonly npotSupport: UnityEngine.NPOTSupport;

    static readonly maxTextureSize: number;

    static readonly maxCubemapSize: number;

    static readonly supportsAsyncCompute: boolean;

    static readonly supportsGPUFence: boolean;

    static readonly supportsAsyncGPUReadback: boolean;

    static readonly supportsMipStreaming: boolean;

    // Static Methods

    static SupportsRenderTextureFormat(
      format: UnityEngine.RenderTextureFormat
    ): boolean;

    static SupportsBlendingOnRenderTextureFormat(
      format: UnityEngine.RenderTextureFormat
    ): boolean;

    static SupportsTextureFormat(format: UnityEngine.TextureFormat): boolean;

    static IsFormatSupported(
      format: UnityEngine.Experimental.Rendering.GraphicsFormat,
      usage: UnityEngine.Experimental.Rendering.FormatUsage
    ): boolean;

    // Instance Fields

    // Instance Property Accessors

    // Instance Methods
  }
}
