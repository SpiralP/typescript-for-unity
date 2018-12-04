declare namespace UnityEngine {
  class Plane {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    static Translate(
      plane: UnityEngine.Plane,
      translation: UnityEngine.Vector3
    ): UnityEngine.Plane;

    // Instance Fields

    // Instance Property Accessors

    normal: UnityEngine.Vector3;

    distance: number;

    readonly flipped: UnityEngine.Plane;

    // Instance Methods

    SetNormalAndPosition(
      inNormal: UnityEngine.Vector3,
      inPoint: UnityEngine.Vector3
    ): void;

    Set3Points(
      a: UnityEngine.Vector3,
      b: UnityEngine.Vector3,
      c: UnityEngine.Vector3
    ): void;

    Flip(): void;

    Translate(translation: UnityEngine.Vector3): void;

    ClosestPointOnPlane(point: UnityEngine.Vector3): UnityEngine.Vector3;

    GetDistanceToPoint(point: UnityEngine.Vector3): number;

    GetSide(point: UnityEngine.Vector3): boolean;

    SameSide(inPt0: UnityEngine.Vector3, inPt1: UnityEngine.Vector3): boolean;

    /*
            Plane Raycast
            parameter enter is out
          */

    toString(): string;

    ToString(format: string): string;
  }
}
