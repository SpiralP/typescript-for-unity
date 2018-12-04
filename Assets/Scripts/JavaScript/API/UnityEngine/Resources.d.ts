declare namespace UnityEngine {
  class Resources {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    static FindObjectsOfTypeAll(type: System.Type): UnityEngine.Object[];

    /*
            Resources FindObjectsOfTypeAll
            method has generics
          */

    static Load(path: string): UnityEngine.Object;

    /*
            Resources Load
            method has generics
          */

    static Load(
      path: string,
      systemTypeInstance: System.Type
    ): UnityEngine.Object;

    static LoadAsync(path: string): UnityEngine.ResourceRequest;

    /*
            Resources LoadAsync
            method has generics
          */

    static LoadAsync(
      path: string,
      type: System.Type
    ): UnityEngine.ResourceRequest;

    static LoadAll(
      path: string,
      systemTypeInstance: System.Type
    ): UnityEngine.Object[];

    static LoadAll(path: string): UnityEngine.Object[];

    /*
            Resources LoadAll
            method has generics
          */

    static GetBuiltinResource(
      type: System.Type,
      path: string
    ): UnityEngine.Object;

    /*
            Resources GetBuiltinResource
            method has generics
          */

    static UnloadAsset(assetToUnload: UnityEngine.Object): void;

    static UnloadUnusedAssets(): UnityEngine.AsyncOperation;

    // Instance Fields

    // Instance Property Accessors

    // Instance Methods
  }
}
