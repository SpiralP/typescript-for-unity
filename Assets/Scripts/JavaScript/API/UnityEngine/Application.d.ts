declare namespace UnityEngine {
  class Application {
    // Static Fields

    // Static Property Accessors

    static readonly isPlaying: boolean;

    static readonly isFocused: boolean;

    static readonly platform: UnityEngine.RuntimePlatform;

    static readonly buildGUID: string;

    static readonly isMobilePlatform: boolean;

    static readonly isConsolePlatform: boolean;

    static runInBackground: boolean;

    static readonly isBatchMode: boolean;

    static readonly dataPath: string;

    static readonly streamingAssetsPath: string;

    static readonly persistentDataPath: string;

    static readonly temporaryCachePath: string;

    static readonly absoluteURL: string;

    static readonly unityVersion: string;

    static readonly version: string;

    static readonly installerName: string;

    static readonly identifier: string;

    static readonly installMode: UnityEngine.ApplicationInstallMode;

    static readonly sandboxType: UnityEngine.ApplicationSandboxType;

    static readonly productName: string;

    static readonly companyName: string;

    static readonly cloudProjectId: string;

    static targetFrameRate: number;

    static readonly systemLanguage: UnityEngine.SystemLanguage;

    static backgroundLoadingPriority: UnityEngine.ThreadPriority;

    static readonly internetReachability: UnityEngine.NetworkReachability;

    static readonly genuine: boolean;

    static readonly genuineCheckAvailable: boolean;

    static readonly isEditor: boolean;

    // Static Methods

    static Quit(): void;

    static Unload(): void;

    static CanStreamedLevelBeLoaded(levelIndex: number): boolean;

    static CanStreamedLevelBeLoaded(levelName: string): boolean;

    static GetBuildTags(): System.String[];

    static SetBuildTags(buildTags: System.String[]): void;

    static HasProLicense(): boolean;

    static RequestAdvertisingIdentifierAsync(
      delegateMethod: UnityEngine.Application.AdvertisingIdentifierCallback
    ): boolean;

    static OpenURL(url: string): void;

    static GetStackTraceLogType(
      logType: UnityEngine.LogType
    ): UnityEngine.StackTraceLogType;

    static SetStackTraceLogType(
      logType: UnityEngine.LogType,
      stackTraceType: UnityEngine.StackTraceLogType
    ): void;

    static RequestUserAuthorization(
      mode: UnityEngine.UserAuthorization
    ): UnityEngine.AsyncOperation;

    static HasUserAuthorization(mode: UnityEngine.UserAuthorization): boolean;

    // Instance Fields

    // Instance Property Accessors

    // Instance Methods
  }
}
