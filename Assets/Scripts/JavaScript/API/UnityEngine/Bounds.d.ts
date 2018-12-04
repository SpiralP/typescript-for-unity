declare namespace UnityEngine {
  class Bounds {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    center: UnityEngine.Vector3;

    size: UnityEngine.Vector3;

    extents: UnityEngine.Vector3;

    min: UnityEngine.Vector3;

    max: UnityEngine.Vector3;

    // Instance Methods

    GetHashCode(): number;

    Equals(other: System.Object): boolean;

    Equals(other: UnityEngine.Bounds): boolean;

    SetMinMax(min: UnityEngine.Vector3, max: UnityEngine.Vector3): void;

    Encapsulate(point: UnityEngine.Vector3): void;

    Encapsulate(bounds: UnityEngine.Bounds): void;

    Expand(amount: number): void;

    Expand(amount: UnityEngine.Vector3): void;

    Intersects(bounds: UnityEngine.Bounds): boolean;

    IntersectRay(ray: UnityEngine.Ray): boolean;

    /*
            Bounds IntersectRay
            parameter distance is out
          */

    toString(): string;

    ToString(format: string): string;

    Contains(point: UnityEngine.Vector3): boolean;

    SqrDistance(point: UnityEngine.Vector3): number;

    ClosestPoint(point: UnityEngine.Vector3): UnityEngine.Vector3;
  }
}
