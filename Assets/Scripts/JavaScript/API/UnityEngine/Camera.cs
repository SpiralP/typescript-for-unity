using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCamera {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue CameraPrototype;
      JavaScriptValue CameraConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Camera),
        (args) => { throw new System.NotImplementedException(); },
        out CameraPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Camera", CameraConstructor);


      // Static Fields

      Bridge.DefineGetterSetter(
        CameraConstructor,
        "onPreCull",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Camera.onPreCull),
        (args) => { UnityEngine.Camera.onPreCull = Bridge.GetExternal<UnityEngine.Camera.CameraCallback>(args[1]); }
      );


      Bridge.DefineGetterSetter(
        CameraConstructor,
        "onPreRender",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Camera.onPreRender),
        (args) => { UnityEngine.Camera.onPreRender = Bridge.GetExternal<UnityEngine.Camera.CameraCallback>(args[1]); }
      );


      Bridge.DefineGetterSetter(
        CameraConstructor,
        "onPostRender",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Camera.onPostRender),
        (args) => { UnityEngine.Camera.onPostRender = Bridge.GetExternal<UnityEngine.Camera.CameraCallback>(args[1]); }
      );


      // Static Property Accessors

      Bridge.DefineGetter(
        CameraConstructor,
        "main",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Camera.main)
      );


      Bridge.DefineGetter(
        CameraConstructor,
        "current",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Camera.current)
      );


      Bridge.DefineGetter(
        CameraConstructor,
        "allCamerasCount",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Camera.allCamerasCount)
      );


      Bridge.DefineGetter(
        CameraConstructor,
        "allCameras",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Camera.allCameras)
      );


      // Static Methods

      CameraConstructor.SetProperty(
        "FocalLengthToFOV",
        Bridge.CreateFunction(
          "FocalLengthToFOV",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Camera.FocalLengthToFOV((float) args[1].ToDouble(), (float) args[2].ToDouble()))
        )
      );


      CameraConstructor.SetProperty(
        "FOVToFocalLength",
        Bridge.CreateFunction(
          "FOVToFocalLength",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Camera.FOVToFocalLength((float) args[1].ToDouble(), (float) args[2].ToDouble()))
        )
      );


      CameraConstructor.SetProperty(
        "GetAllCameras",
        Bridge.CreateFunction(
          "GetAllCameras",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Camera.GetAllCameras(Bridge.GetExternal<UnityEngine.Camera[]>(args[1])))
        )
      );


      CameraConstructor.SetProperty(
        "SetupCurrent",
        Bridge.CreateFunction(
          "SetupCurrent",
          (args) => UnityEngine.Camera.SetupCurrent(Bridge.GetExternal<UnityEngine.Camera>(args[1]))
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        CameraPrototype,
        "nearClipPlane",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.nearClipPlane)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.nearClipPlane = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "farClipPlane",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.farClipPlane)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.farClipPlane = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "fieldOfView",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.fieldOfView)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.fieldOfView = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "renderingPath",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.renderingPath)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.renderingPath = Bridge.GetExternal<UnityEngine.RenderingPath>(args[1]); })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "actualRenderingPath",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.actualRenderingPath))
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "allowHDR",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.allowHDR)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.allowHDR = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "allowMSAA",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.allowMSAA)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.allowMSAA = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "allowDynamicResolution",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.allowDynamicResolution)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.allowDynamicResolution = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "forceIntoRenderTexture",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.forceIntoRenderTexture)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.forceIntoRenderTexture = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "orthographicSize",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.orthographicSize)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.orthographicSize = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "orthographic",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.orthographic)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.orthographic = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "opaqueSortMode",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.opaqueSortMode)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.opaqueSortMode = Bridge.GetExternal<UnityEngine.Rendering.OpaqueSortMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "transparencySortMode",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.transparencySortMode)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.transparencySortMode = Bridge.GetExternal<UnityEngine.TransparencySortMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "transparencySortAxis",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.transparencySortAxis)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.transparencySortAxis = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "depth",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.depth)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.depth = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "aspect",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.aspect)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.aspect = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "velocity",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.velocity))
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "cullingMask",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromInt32(o.cullingMask)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.cullingMask = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "eventMask",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromInt32(o.eventMask)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.eventMask = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "layerCullSpherical",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.layerCullSpherical)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.layerCullSpherical = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "cameraType",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.cameraType)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.cameraType = Bridge.GetExternal<UnityEngine.CameraType>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "layerCullDistances",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.layerCullDistances)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.layerCullDistances = Bridge.GetExternal<System.Single[]>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "useOcclusionCulling",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.useOcclusionCulling)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.useOcclusionCulling = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "cullingMatrix",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.cullingMatrix)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.cullingMatrix = Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "backgroundColor",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.backgroundColor)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.backgroundColor = Bridge.GetBoxedExternal<UnityEngine.Color>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "clearFlags",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.clearFlags)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.clearFlags = Bridge.GetExternal<UnityEngine.CameraClearFlags>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "depthTextureMode",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.depthTextureMode)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.depthTextureMode = Bridge.GetExternal<UnityEngine.DepthTextureMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "clearStencilAfterLightingPass",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.clearStencilAfterLightingPass)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.clearStencilAfterLightingPass = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "usePhysicalProperties",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.usePhysicalProperties)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.usePhysicalProperties = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "sensorSize",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.sensorSize)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.sensorSize = Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "lensShift",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.lensShift)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.lensShift = Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "focalLength",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.focalLength)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.focalLength = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "rect",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.rect)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.rect = Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "pixelRect",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.pixelRect)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.pixelRect = Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped; })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "pixelWidth",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromInt32(o.pixelWidth))
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "pixelHeight",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromInt32(o.pixelHeight))
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "scaledPixelWidth",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromInt32(o.scaledPixelWidth))
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "scaledPixelHeight",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromInt32(o.scaledPixelHeight))
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "targetTexture",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.targetTexture)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.targetTexture = Bridge.GetExternal<UnityEngine.RenderTexture>(args[1]); })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "activeTexture",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.activeTexture))
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "targetDisplay",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromInt32(o.targetDisplay)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.targetDisplay = args[1].ToInt32(); })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "cameraToWorldMatrix",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.cameraToWorldMatrix))
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "worldToCameraMatrix",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.worldToCameraMatrix)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.worldToCameraMatrix = Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "projectionMatrix",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.projectionMatrix)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.projectionMatrix = Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "nonJitteredProjectionMatrix",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.nonJitteredProjectionMatrix)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.nonJitteredProjectionMatrix = Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "useJitteredProjectionMatrixForTransparentRendering",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.useJitteredProjectionMatrixForTransparentRendering)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.useJitteredProjectionMatrixForTransparentRendering = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "previousViewProjectionMatrix",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.previousViewProjectionMatrix))
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "scene",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.scene)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.scene = Bridge.GetBoxedExternal<UnityEngine.SceneManagement.Scene>(args[1]).wrapped; })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "stereoEnabled",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.stereoEnabled))
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "stereoSeparation",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.stereoSeparation)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.stereoSeparation = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "stereoConvergence",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromDouble(o.stereoConvergence)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.stereoConvergence = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "areVRStereoViewMatricesWithinSingleCullTolerance",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.areVRStereoViewMatricesWithinSingleCullTolerance))
      );


      Bridge.DefineGetterSetter(
        CameraPrototype,
        "stereoTargetEye",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.stereoTargetEye)),
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => { o.stereoTargetEye = Bridge.GetExternal<UnityEngine.StereoTargetEyeMask>(args[1]); })
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "stereoActiveEye",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.stereoActiveEye))
      );


      Bridge.DefineGetter(
        CameraPrototype,
        "commandBufferCount",
        Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromInt32(o.commandBufferCount))
      );


      // Instance Methods

      CameraPrototype.SetProperty(
        "GetCommandBuffers",
        Bridge.CreateFunction(
          "GetCommandBuffers",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.GetCommandBuffers(Bridge.GetExternal<UnityEngine.Rendering.CameraEvent>(args[1]))))
        )
      );


      CameraPrototype.SetProperty(
        "Reset",
        Bridge.CreateFunction(
          "Reset",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.Reset())
        )
      );


      CameraPrototype.SetProperty(
        "ResetTransparencySortSettings",
        Bridge.CreateFunction(
          "ResetTransparencySortSettings",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.ResetTransparencySortSettings())
        )
      );


      CameraPrototype.SetProperty(
        "ResetAspect",
        Bridge.CreateFunction(
          "ResetAspect",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.ResetAspect())
        )
      );


      CameraPrototype.SetProperty(
        "ResetCullingMatrix",
        Bridge.CreateFunction(
          "ResetCullingMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.ResetCullingMatrix())
        )
      );


      CameraPrototype.SetProperty(
        "SetReplacementShader",
        Bridge.CreateFunction(
          "SetReplacementShader",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.SetReplacementShader(Bridge.GetExternal<UnityEngine.Shader>(args[1]), args[2].ToString()))
        )
      );


      CameraPrototype.SetProperty(
        "ResetReplacementShader",
        Bridge.CreateFunction(
          "ResetReplacementShader",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.ResetReplacementShader())
        )
      );


      CameraPrototype.SetProperty(
        "SetTargetBuffers",
        Bridge.CreateFunction(
          "SetTargetBuffers",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.SetTargetBuffers(Bridge.GetBoxedExternal<UnityEngine.RenderBuffer>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.RenderBuffer>(args[2]).wrapped))
        )
      );


      CameraPrototype.SetProperty(
        "SetTargetBuffers",
        Bridge.CreateFunction(
          "SetTargetBuffers",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.SetTargetBuffers(Bridge.GetExternal<UnityEngine.RenderBuffer[]>(args[1]), Bridge.GetBoxedExternal<UnityEngine.RenderBuffer>(args[2]).wrapped))
        )
      );


      CameraPrototype.SetProperty(
        "ResetWorldToCameraMatrix",
        Bridge.CreateFunction(
          "ResetWorldToCameraMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.ResetWorldToCameraMatrix())
        )
      );


      CameraPrototype.SetProperty(
        "ResetProjectionMatrix",
        Bridge.CreateFunction(
          "ResetProjectionMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.ResetProjectionMatrix())
        )
      );


      CameraPrototype.SetProperty(
        "CalculateObliqueMatrix",
        Bridge.CreateFunction(
          "CalculateObliqueMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.CalculateObliqueMatrix(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "WorldToScreenPoint",
        Bridge.CreateFunction(
          "WorldToScreenPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.WorldToScreenPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Camera.MonoOrStereoscopicEye>(args[2]))))
        )
      );


      CameraPrototype.SetProperty(
        "WorldToViewportPoint",
        Bridge.CreateFunction(
          "WorldToViewportPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.WorldToViewportPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Camera.MonoOrStereoscopicEye>(args[2]))))
        )
      );


      CameraPrototype.SetProperty(
        "ViewportToWorldPoint",
        Bridge.CreateFunction(
          "ViewportToWorldPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ViewportToWorldPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Camera.MonoOrStereoscopicEye>(args[2]))))
        )
      );


      CameraPrototype.SetProperty(
        "ScreenToWorldPoint",
        Bridge.CreateFunction(
          "ScreenToWorldPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ScreenToWorldPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Camera.MonoOrStereoscopicEye>(args[2]))))
        )
      );


      CameraPrototype.SetProperty(
        "WorldToScreenPoint",
        Bridge.CreateFunction(
          "WorldToScreenPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.WorldToScreenPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "WorldToViewportPoint",
        Bridge.CreateFunction(
          "WorldToViewportPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.WorldToViewportPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "ViewportToWorldPoint",
        Bridge.CreateFunction(
          "ViewportToWorldPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ViewportToWorldPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "ScreenToWorldPoint",
        Bridge.CreateFunction(
          "ScreenToWorldPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ScreenToWorldPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "ScreenToViewportPoint",
        Bridge.CreateFunction(
          "ScreenToViewportPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ScreenToViewportPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "ViewportToScreenPoint",
        Bridge.CreateFunction(
          "ViewportToScreenPoint",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ViewportToScreenPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "ViewportPointToRay",
        Bridge.CreateFunction(
          "ViewportPointToRay",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ViewportPointToRay(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Camera.MonoOrStereoscopicEye>(args[2]))))
        )
      );


      CameraPrototype.SetProperty(
        "ViewportPointToRay",
        Bridge.CreateFunction(
          "ViewportPointToRay",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ViewportPointToRay(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "ScreenPointToRay",
        Bridge.CreateFunction(
          "ScreenPointToRay",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ScreenPointToRay(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Camera.MonoOrStereoscopicEye>(args[2]))))
        )
      );


      CameraPrototype.SetProperty(
        "ScreenPointToRay",
        Bridge.CreateFunction(
          "ScreenPointToRay",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.ScreenPointToRay(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      CameraPrototype.SetProperty(
        "CalculateFrustumCorners",
        Bridge.CreateFunction(
          "CalculateFrustumCorners",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.CalculateFrustumCorners(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.Camera.MonoOrStereoscopicEye>(args[3]), Bridge.GetExternal<UnityEngine.Vector3[]>(args[4])))
        )
      );


      CameraPrototype.SetProperty(
        "GetStereoNonJitteredProjectionMatrix",
        Bridge.CreateFunction(
          "GetStereoNonJitteredProjectionMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.GetStereoNonJitteredProjectionMatrix(Bridge.GetExternal<UnityEngine.Camera.StereoscopicEye>(args[1]))))
        )
      );


      CameraPrototype.SetProperty(
        "GetStereoViewMatrix",
        Bridge.CreateFunction(
          "GetStereoViewMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.GetStereoViewMatrix(Bridge.GetExternal<UnityEngine.Camera.StereoscopicEye>(args[1]))))
        )
      );


      CameraPrototype.SetProperty(
        "CopyStereoDeviceProjectionMatrixToNonJittered",
        Bridge.CreateFunction(
          "CopyStereoDeviceProjectionMatrixToNonJittered",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.CopyStereoDeviceProjectionMatrixToNonJittered(Bridge.GetExternal<UnityEngine.Camera.StereoscopicEye>(args[1])))
        )
      );


      CameraPrototype.SetProperty(
        "GetStereoProjectionMatrix",
        Bridge.CreateFunction(
          "GetStereoProjectionMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => Bridge.CreateExternalWithPrototype(o.GetStereoProjectionMatrix(Bridge.GetExternal<UnityEngine.Camera.StereoscopicEye>(args[1]))))
        )
      );


      CameraPrototype.SetProperty(
        "SetStereoProjectionMatrix",
        Bridge.CreateFunction(
          "SetStereoProjectionMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.SetStereoProjectionMatrix(Bridge.GetExternal<UnityEngine.Camera.StereoscopicEye>(args[1]), Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[2]).wrapped))
        )
      );


      CameraPrototype.SetProperty(
        "ResetStereoProjectionMatrices",
        Bridge.CreateFunction(
          "ResetStereoProjectionMatrices",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.ResetStereoProjectionMatrices())
        )
      );


      CameraPrototype.SetProperty(
        "SetStereoViewMatrix",
        Bridge.CreateFunction(
          "SetStereoViewMatrix",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.SetStereoViewMatrix(Bridge.GetExternal<UnityEngine.Camera.StereoscopicEye>(args[1]), Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[2]).wrapped))
        )
      );


      CameraPrototype.SetProperty(
        "ResetStereoViewMatrices",
        Bridge.CreateFunction(
          "ResetStereoViewMatrices",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.ResetStereoViewMatrices())
        )
      );


      CameraPrototype.SetProperty(
        "RenderToCubemap",
        Bridge.CreateFunction(
          "RenderToCubemap",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.RenderToCubemap(Bridge.GetExternal<UnityEngine.Cubemap>(args[1]), args[2].ToInt32())))
        )
      );


      CameraPrototype.SetProperty(
        "RenderToCubemap",
        Bridge.CreateFunction(
          "RenderToCubemap",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.RenderToCubemap(Bridge.GetExternal<UnityEngine.Cubemap>(args[1]))))
        )
      );


      CameraPrototype.SetProperty(
        "RenderToCubemap",
        Bridge.CreateFunction(
          "RenderToCubemap",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.RenderToCubemap(Bridge.GetExternal<UnityEngine.RenderTexture>(args[1]), args[2].ToInt32())))
        )
      );


      CameraPrototype.SetProperty(
        "RenderToCubemap",
        Bridge.CreateFunction(
          "RenderToCubemap",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.RenderToCubemap(Bridge.GetExternal<UnityEngine.RenderTexture>(args[1]))))
        )
      );


      CameraPrototype.SetProperty(
        "RenderToCubemap",
        Bridge.CreateFunction(
          "RenderToCubemap",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => JavaScriptValue.FromBoolean(o.RenderToCubemap(Bridge.GetExternal<UnityEngine.RenderTexture>(args[1]), args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Camera.MonoOrStereoscopicEye>(args[3]))))
        )
      );


      CameraPrototype.SetProperty(
        "Render",
        Bridge.CreateFunction(
          "Render",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.Render())
        )
      );


      CameraPrototype.SetProperty(
        "RenderWithShader",
        Bridge.CreateFunction(
          "RenderWithShader",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.RenderWithShader(Bridge.GetExternal<UnityEngine.Shader>(args[1]), args[2].ToString()))
        )
      );


      CameraPrototype.SetProperty(
        "RenderDontRestore",
        Bridge.CreateFunction(
          "RenderDontRestore",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.RenderDontRestore())
        )
      );


      CameraPrototype.SetProperty(
        "CopyFrom",
        Bridge.CreateFunction(
          "CopyFrom",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.CopyFrom(Bridge.GetExternal<UnityEngine.Camera>(args[1])))
        )
      );


      CameraPrototype.SetProperty(
        "RemoveCommandBuffers",
        Bridge.CreateFunction(
          "RemoveCommandBuffers",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.RemoveCommandBuffers(Bridge.GetExternal<UnityEngine.Rendering.CameraEvent>(args[1])))
        )
      );


      CameraPrototype.SetProperty(
        "RemoveAllCommandBuffers",
        Bridge.CreateFunction(
          "RemoveAllCommandBuffers",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.RemoveAllCommandBuffers())
        )
      );


      CameraPrototype.SetProperty(
        "AddCommandBuffer",
        Bridge.CreateFunction(
          "AddCommandBuffer",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.AddCommandBuffer(Bridge.GetExternal<UnityEngine.Rendering.CameraEvent>(args[1]), Bridge.GetExternal<UnityEngine.Rendering.CommandBuffer>(args[2])))
        )
      );


      CameraPrototype.SetProperty(
        "AddCommandBufferAsync",
        Bridge.CreateFunction(
          "AddCommandBufferAsync",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.AddCommandBufferAsync(Bridge.GetExternal<UnityEngine.Rendering.CameraEvent>(args[1]), Bridge.GetExternal<UnityEngine.Rendering.CommandBuffer>(args[2]), Bridge.GetExternal<UnityEngine.Rendering.ComputeQueueType>(args[3])))
        )
      );


      CameraPrototype.SetProperty(
        "RemoveCommandBuffer",
        Bridge.CreateFunction(
          "RemoveCommandBuffer",
          Bridge.WithExternal<UnityEngine.Camera>((o, args) => o.RemoveCommandBuffer(Bridge.GetExternal<UnityEngine.Rendering.CameraEvent>(args[1]), Bridge.GetExternal<UnityEngine.Rendering.CommandBuffer>(args[2])))
        )
      );


    }
  }
}
