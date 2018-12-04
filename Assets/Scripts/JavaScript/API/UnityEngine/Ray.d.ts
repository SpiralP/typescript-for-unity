declare namespace UnityEngine {
  class Ray {
    constructor(origin: Vector3, direction: Vector3);
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    origin: UnityEngine.Vector3;

    direction: UnityEngine.Vector3;

    // Instance Methods

    GetPoint(distance: number): UnityEngine.Vector3;

    toString(): string;

    ToString(format: string): string;
  }
}
