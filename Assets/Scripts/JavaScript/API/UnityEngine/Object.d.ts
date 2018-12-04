declare namespace UnityEngine {
  class Object extends System.Object {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    static Instantiate<T extends UnityEngine.Object>(original: T): T;

    static Instantiate(
      original: UnityEngine.Object,
      parent: UnityEngine.Transform
    ): UnityEngine.Object;

    static Instantiate(
      original: UnityEngine.Object,
      parent: UnityEngine.Transform,
      instantiateInWorldSpace: boolean
    ): UnityEngine.Object;

    static Instantiate(
      original: UnityEngine.Object,
      position: UnityEngine.Vector3,
      rotation: UnityEngine.Quaternion
    ): UnityEngine.Object;

    static Instantiate(
      original: UnityEngine.Object,
      position: UnityEngine.Vector3,
      rotation: UnityEngine.Quaternion,
      parent: UnityEngine.Transform
    ): UnityEngine.Object;

    /*
            Object Instantiate
            method has generics
          */

    /*
            Object Instantiate
            method has generics
          */

    /*
            Object Instantiate
            method has generics
          */

    /*
            Object Instantiate
            method has generics
          */

    /*
            Object Instantiate
            method has generics
          */

    static Destroy(obj: UnityEngine.Object, t: number): void;

    static Destroy(obj: UnityEngine.Object): void;

    static DestroyImmediate(
      obj: UnityEngine.Object,
      allowDestroyingAssets: boolean
    ): void;

    static DestroyImmediate(obj: UnityEngine.Object): void;

    static FindObjectsOfType(type: System.Type): UnityEngine.Object[];

    static DontDestroyOnLoad(target: UnityEngine.Object): void;

    /*
            Object FindObjectsOfType
            method has generics
          */

    /*
            Object FindObjectOfType
            method has generics
          */

    static FindObjectOfType(type: System.Type): UnityEngine.Object;

    // Instance Fields

    // Instance Property Accessors

    name: string;

    hideFlags: UnityEngine.HideFlags;

    // Instance Methods

    GetInstanceID(): number;

    GetHashCode(): number;

    Equals(other: System.Object): boolean;

    toString(): string;
  }
}
