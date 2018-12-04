declare namespace UnityEngine {
  class Quaternion {
    constructor();
    constructor(x: number, y: number, z: number, w: number);
    // Static Fields

    static readonly kEpsilon: number;

    // Static Property Accessors

    static readonly identity: UnityEngine.Quaternion;

    // Static Methods

    static FromToRotation(
      fromDirection: UnityEngine.Vector3,
      toDirection: UnityEngine.Vector3
    ): UnityEngine.Quaternion;

    static Inverse(rotation: UnityEngine.Quaternion): UnityEngine.Quaternion;

    static Slerp(
      a: UnityEngine.Quaternion,
      b: UnityEngine.Quaternion,
      t: number
    ): UnityEngine.Quaternion;

    static SlerpUnclamped(
      a: UnityEngine.Quaternion,
      b: UnityEngine.Quaternion,
      t: number
    ): UnityEngine.Quaternion;

    static Lerp(
      a: UnityEngine.Quaternion,
      b: UnityEngine.Quaternion,
      t: number
    ): UnityEngine.Quaternion;

    static LerpUnclamped(
      a: UnityEngine.Quaternion,
      b: UnityEngine.Quaternion,
      t: number
    ): UnityEngine.Quaternion;

    static AngleAxis(
      angle: number,
      axis: UnityEngine.Vector3
    ): UnityEngine.Quaternion;

    static LookRotation(
      forward: UnityEngine.Vector3,
      upwards: UnityEngine.Vector3
    ): UnityEngine.Quaternion;

    static LookRotation(forward: UnityEngine.Vector3): UnityEngine.Quaternion;

    static Dot(a: UnityEngine.Quaternion, b: UnityEngine.Quaternion): number;

    static Angle(a: UnityEngine.Quaternion, b: UnityEngine.Quaternion): number;

    static Euler(x: number, y: number, z: number): UnityEngine.Quaternion;

    static Euler(euler: UnityEngine.Vector3): UnityEngine.Quaternion;

    static RotateTowards(
      from: UnityEngine.Quaternion,
      to: UnityEngine.Quaternion,
      maxDegreesDelta: number
    ): UnityEngine.Quaternion;

    static Normalize(q: UnityEngine.Quaternion): UnityEngine.Quaternion;

    // Instance Fields

    x: number;

    y: number;

    z: number;

    w: number;

    // Instance Property Accessors

    eulerAngles: UnityEngine.Vector3;

    readonly normalized: UnityEngine.Quaternion;

    // Instance Methods

    Set(newX: number, newY: number, newZ: number, newW: number): void;

    SetLookRotation(view: UnityEngine.Vector3): void;

    SetLookRotation(view: UnityEngine.Vector3, up: UnityEngine.Vector3): void;

    /*
            Quaternion ToAngleAxis
            parameter angle is out
          */

    SetFromToRotation(
      fromDirection: UnityEngine.Vector3,
      toDirection: UnityEngine.Vector3
    ): void;

    Normalize(): void;

    GetHashCode(): number;

    Equals(other: System.Object): boolean;

    Equals(other: UnityEngine.Quaternion): boolean;

    toString(): string;

    ToString(format: string): string;
  }
}
