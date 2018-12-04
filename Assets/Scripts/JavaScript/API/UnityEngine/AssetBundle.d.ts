declare namespace UnityEngine {
  class AssetBundle {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    static UnloadAllAssetBundles(unloadAllObjects: boolean): void;

    /*
            AssetBundle GetAllLoadedAssetBundles
            System.Collections.Generic.IEnumerable`1[UnityEngine.AssetBundle] has generics
          */

    static LoadFromFileAsync(
      path: string
    ): UnityEngine.AssetBundleCreateRequest;

    static LoadFromFileAsync(
      path: string,
      crc: System.UInt32
    ): UnityEngine.AssetBundleCreateRequest;

    static LoadFromFileAsync(
      path: string,
      crc: System.UInt32,
      offset: System.UInt64
    ): UnityEngine.AssetBundleCreateRequest;

    static LoadFromFile(path: string): UnityEngine.AssetBundle;

    static LoadFromFile(
      path: string,
      crc: System.UInt32
    ): UnityEngine.AssetBundle;

    static LoadFromFile(
      path: string,
      crc: System.UInt32,
      offset: System.UInt64
    ): UnityEngine.AssetBundle;

    static LoadFromMemoryAsync(
      binary: System.Byte[]
    ): UnityEngine.AssetBundleCreateRequest;

    static LoadFromMemoryAsync(
      binary: System.Byte[],
      crc: System.UInt32
    ): UnityEngine.AssetBundleCreateRequest;

    static LoadFromMemory(binary: System.Byte[]): UnityEngine.AssetBundle;

    static LoadFromMemory(
      binary: System.Byte[],
      crc: System.UInt32
    ): UnityEngine.AssetBundle;

    static LoadFromStreamAsync(
      stream: System.IO.Stream,
      crc: System.UInt32,
      managedReadBufferSize: System.UInt32
    ): UnityEngine.AssetBundleCreateRequest;

    static LoadFromStreamAsync(
      stream: System.IO.Stream,
      crc: System.UInt32
    ): UnityEngine.AssetBundleCreateRequest;

    static LoadFromStreamAsync(
      stream: System.IO.Stream
    ): UnityEngine.AssetBundleCreateRequest;

    static LoadFromStream(
      stream: System.IO.Stream,
      crc: System.UInt32,
      managedReadBufferSize: System.UInt32
    ): UnityEngine.AssetBundle;

    static LoadFromStream(
      stream: System.IO.Stream,
      crc: System.UInt32
    ): UnityEngine.AssetBundle;

    static LoadFromStream(stream: System.IO.Stream): UnityEngine.AssetBundle;

    // Instance Fields

    // Instance Property Accessors

    readonly mainAsset: UnityEngine.Object;

    readonly isStreamedSceneAssetBundle: boolean;

    // Instance Methods

    Contains(name: string): boolean;

    LoadAsset(name: string): UnityEngine.Object;

    /*
            AssetBundle LoadAsset
            method has generics
          */

    LoadAsset(name: string, type: System.Type): UnityEngine.Object;

    LoadAssetAsync(name: string): UnityEngine.AssetBundleRequest;

    /*
            AssetBundle LoadAssetAsync
            method has generics
          */

    LoadAssetAsync(
      name: string,
      type: System.Type
    ): UnityEngine.AssetBundleRequest;

    LoadAssetWithSubAssets(name: string): UnityEngine.Object[];

    /*
            AssetBundle LoadAssetWithSubAssets
            method has generics
          */

    LoadAssetWithSubAssets(
      name: string,
      type: System.Type
    ): UnityEngine.Object[];

    LoadAssetWithSubAssetsAsync(name: string): UnityEngine.AssetBundleRequest;

    /*
            AssetBundle LoadAssetWithSubAssetsAsync
            method has generics
          */

    LoadAssetWithSubAssetsAsync(
      name: string,
      type: System.Type
    ): UnityEngine.AssetBundleRequest;

    LoadAllAssets(): UnityEngine.Object[];

    /*
            AssetBundle LoadAllAssets
            method has generics
          */

    LoadAllAssets(type: System.Type): UnityEngine.Object[];

    LoadAllAssetsAsync(): UnityEngine.AssetBundleRequest;

    /*
            AssetBundle LoadAllAssetsAsync
            method has generics
          */

    LoadAllAssetsAsync(type: System.Type): UnityEngine.AssetBundleRequest;

    Unload(unloadAllLoadedObjects: boolean): void;

    GetAllAssetNames(): System.String[];

    GetAllScenePaths(): System.String[];
  }
}
