declare namespace UnityEngine {
  class Camera extends Behaviour {
    // Static Fields

    static onPreCull: UnityEngine.Camera.CameraCallback;

    static onPreRender: UnityEngine.Camera.CameraCallback;

    static onPostRender: UnityEngine.Camera.CameraCallback;

    // Static Property Accessors

    static readonly main: UnityEngine.Camera;

    static readonly current: UnityEngine.Camera;

    static readonly allCamerasCount: number;

    static readonly allCameras: UnityEngine.Camera[];

    // Static Methods

    static FocalLengthToFOV(focalLength: number, sensorSize: number): number;

    static FOVToFocalLength(fov: number, sensorSize: number): number;

    static GetAllCameras(cameras: UnityEngine.Camera[]): number;

    static SetupCurrent(cur: UnityEngine.Camera): void;

    // Instance Fields

    // Instance Property Accessors

    nearClipPlane: number;

    farClipPlane: number;

    fieldOfView: number;

    renderingPath: UnityEngine.RenderingPath;

    readonly actualRenderingPath: UnityEngine.RenderingPath;

    allowHDR: boolean;

    allowMSAA: boolean;

    allowDynamicResolution: boolean;

    forceIntoRenderTexture: boolean;

    orthographicSize: number;

    orthographic: boolean;

    opaqueSortMode: UnityEngine.Rendering.OpaqueSortMode;

    transparencySortMode: UnityEngine.TransparencySortMode;

    transparencySortAxis: UnityEngine.Vector3;

    depth: number;

    aspect: number;

    readonly velocity: UnityEngine.Vector3;

    cullingMask: number;

    eventMask: number;

    layerCullSpherical: boolean;

    cameraType: UnityEngine.CameraType;

    layerCullDistances: System.Single[];

    useOcclusionCulling: boolean;

    cullingMatrix: UnityEngine.Matrix4x4;

    backgroundColor: UnityEngine.Color;

    clearFlags: UnityEngine.CameraClearFlags;

    depthTextureMode: UnityEngine.DepthTextureMode;

    clearStencilAfterLightingPass: boolean;

    usePhysicalProperties: boolean;

    sensorSize: UnityEngine.Vector2;

    lensShift: UnityEngine.Vector2;

    focalLength: number;

    rect: UnityEngine.Rect;

    pixelRect: UnityEngine.Rect;

    readonly pixelWidth: number;

    readonly pixelHeight: number;

    readonly scaledPixelWidth: number;

    readonly scaledPixelHeight: number;

    targetTexture: UnityEngine.RenderTexture;

    readonly activeTexture: UnityEngine.RenderTexture;

    targetDisplay: number;

    readonly cameraToWorldMatrix: UnityEngine.Matrix4x4;

    worldToCameraMatrix: UnityEngine.Matrix4x4;

    projectionMatrix: UnityEngine.Matrix4x4;

    nonJitteredProjectionMatrix: UnityEngine.Matrix4x4;

    useJitteredProjectionMatrixForTransparentRendering: boolean;

    readonly previousViewProjectionMatrix: UnityEngine.Matrix4x4;

    scene: UnityEngine.SceneManagement.Scene;

    readonly stereoEnabled: boolean;

    stereoSeparation: number;

    stereoConvergence: number;

    readonly areVRStereoViewMatricesWithinSingleCullTolerance: boolean;

    stereoTargetEye: UnityEngine.StereoTargetEyeMask;

    readonly stereoActiveEye: UnityEngine.Camera.MonoOrStereoscopicEye;

    readonly commandBufferCount: number;

    // Instance Methods

    GetCommandBuffers(
      evt: UnityEngine.Rendering.CameraEvent
    ): UnityEngine.Rendering.CommandBuffer[];

    Reset(): void;

    ResetTransparencySortSettings(): void;

    ResetAspect(): void;

    ResetCullingMatrix(): void;

    SetReplacementShader(
      shader: UnityEngine.Shader,
      replacementTag: string
    ): void;

    ResetReplacementShader(): void;

    SetTargetBuffers(
      colorBuffer: UnityEngine.RenderBuffer,
      depthBuffer: UnityEngine.RenderBuffer
    ): void;

    SetTargetBuffers(
      colorBuffer: UnityEngine.RenderBuffer[],
      depthBuffer: UnityEngine.RenderBuffer
    ): void;

    ResetWorldToCameraMatrix(): void;

    ResetProjectionMatrix(): void;

    CalculateObliqueMatrix(
      clipPlane: UnityEngine.Vector4
    ): UnityEngine.Matrix4x4;

    WorldToScreenPoint(
      position: UnityEngine.Vector3,
      eye: UnityEngine.Camera.MonoOrStereoscopicEye
    ): UnityEngine.Vector3;

    WorldToViewportPoint(
      position: UnityEngine.Vector3,
      eye: UnityEngine.Camera.MonoOrStereoscopicEye
    ): UnityEngine.Vector3;

    ViewportToWorldPoint(
      position: UnityEngine.Vector3,
      eye: UnityEngine.Camera.MonoOrStereoscopicEye
    ): UnityEngine.Vector3;

    ScreenToWorldPoint(
      position: UnityEngine.Vector3,
      eye: UnityEngine.Camera.MonoOrStereoscopicEye
    ): UnityEngine.Vector3;

    WorldToScreenPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;

    WorldToViewportPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;

    ViewportToWorldPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;

    ScreenToWorldPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;

    ScreenToViewportPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;

    ViewportToScreenPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;

    ViewportPointToRay(
      pos: UnityEngine.Vector3,
      eye: UnityEngine.Camera.MonoOrStereoscopicEye
    ): UnityEngine.Ray;

    ViewportPointToRay(pos: UnityEngine.Vector3): UnityEngine.Ray;

    ScreenPointToRay(
      pos: UnityEngine.Vector3,
      eye: UnityEngine.Camera.MonoOrStereoscopicEye
    ): UnityEngine.Ray;

    ScreenPointToRay(pos: UnityEngine.Vector3): UnityEngine.Ray;

    CalculateFrustumCorners(
      viewport: UnityEngine.Rect,
      z: number,
      eye: UnityEngine.Camera.MonoOrStereoscopicEye,
      outCorners: UnityEngine.Vector3[]
    ): void;

    GetStereoNonJitteredProjectionMatrix(
      eye: UnityEngine.Camera.StereoscopicEye
    ): UnityEngine.Matrix4x4;

    GetStereoViewMatrix(
      eye: UnityEngine.Camera.StereoscopicEye
    ): UnityEngine.Matrix4x4;

    CopyStereoDeviceProjectionMatrixToNonJittered(
      eye: UnityEngine.Camera.StereoscopicEye
    ): void;

    GetStereoProjectionMatrix(
      eye: UnityEngine.Camera.StereoscopicEye
    ): UnityEngine.Matrix4x4;

    SetStereoProjectionMatrix(
      eye: UnityEngine.Camera.StereoscopicEye,
      matrix: UnityEngine.Matrix4x4
    ): void;

    ResetStereoProjectionMatrices(): void;

    SetStereoViewMatrix(
      eye: UnityEngine.Camera.StereoscopicEye,
      matrix: UnityEngine.Matrix4x4
    ): void;

    ResetStereoViewMatrices(): void;

    RenderToCubemap(cubemap: UnityEngine.Cubemap, faceMask: number): boolean;

    RenderToCubemap(cubemap: UnityEngine.Cubemap): boolean;

    RenderToCubemap(
      cubemap: UnityEngine.RenderTexture,
      faceMask: number
    ): boolean;

    RenderToCubemap(cubemap: UnityEngine.RenderTexture): boolean;

    RenderToCubemap(
      cubemap: UnityEngine.RenderTexture,
      faceMask: number,
      stereoEye: UnityEngine.Camera.MonoOrStereoscopicEye
    ): boolean;

    Render(): void;

    RenderWithShader(shader: UnityEngine.Shader, replacementTag: string): void;

    RenderDontRestore(): void;

    CopyFrom(other: UnityEngine.Camera): void;

    RemoveCommandBuffers(evt: UnityEngine.Rendering.CameraEvent): void;

    RemoveAllCommandBuffers(): void;

    AddCommandBuffer(
      evt: UnityEngine.Rendering.CameraEvent,
      buffer: UnityEngine.Rendering.CommandBuffer
    ): void;

    AddCommandBufferAsync(
      evt: UnityEngine.Rendering.CameraEvent,
      buffer: UnityEngine.Rendering.CommandBuffer,
      queueType: UnityEngine.Rendering.ComputeQueueType
    ): void;

    RemoveCommandBuffer(
      evt: UnityEngine.Rendering.CameraEvent,
      buffer: UnityEngine.Rendering.CommandBuffer
    ): void;
  }
}
