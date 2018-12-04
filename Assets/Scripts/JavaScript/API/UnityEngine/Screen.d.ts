declare namespace UnityEngine {
  class Screen {
    // Static Fields

    // Static Property Accessors

    static readonly width: number;

    static readonly height: number;

    static readonly dpi: number;

    static orientation: UnityEngine.ScreenOrientation;

    static sleepTimeout: number;

    static autorotateToPortrait: boolean;

    static autorotateToPortraitUpsideDown: boolean;

    static autorotateToLandscapeLeft: boolean;

    static autorotateToLandscapeRight: boolean;

    static readonly currentResolution: UnityEngine.Resolution;

    static fullScreen: boolean;

    static fullScreenMode: UnityEngine.FullScreenMode;

    static readonly safeArea: UnityEngine.Rect;

    static readonly resolutions: UnityEngine.Resolution[];

    // Static Methods

    static SetResolution(
      width: number,
      height: number,
      fullscreenMode: UnityEngine.FullScreenMode,
      preferredRefreshRate: number
    ): void;

    static SetResolution(
      width: number,
      height: number,
      fullscreenMode: UnityEngine.FullScreenMode
    ): void;

    static SetResolution(
      width: number,
      height: number,
      fullscreen: boolean,
      preferredRefreshRate: number
    ): void;

    static SetResolution(
      width: number,
      height: number,
      fullscreen: boolean
    ): void;

    // Instance Fields

    // Instance Property Accessors

    // Instance Methods
  }
}
