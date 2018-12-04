declare namespace UnityEngine {
  class Vector3 extends System.Object {
    constructor();
    constructor(x: number, y: number, z: number);
    // Static Fields

    static readonly kEpsilon: number;

    static readonly kEpsilonNormalSqrt: number;

    // Static Property Accessors

    static readonly zero: UnityEngine.Vector3;

    static readonly one: UnityEngine.Vector3;

    static readonly forward: UnityEngine.Vector3;

    static readonly back: UnityEngine.Vector3;

    static readonly up: UnityEngine.Vector3;

    static readonly down: UnityEngine.Vector3;

    static readonly left: UnityEngine.Vector3;

    static readonly right: UnityEngine.Vector3;

    static readonly positiveInfinity: UnityEngine.Vector3;

    static readonly negativeInfinity: UnityEngine.Vector3;

    // Static Methods

    static Slerp(
      a: UnityEngine.Vector3,
      b: UnityEngine.Vector3,
      t: number
    ): UnityEngine.Vector3;

    static SlerpUnclamped(
      a: UnityEngine.Vector3,
      b: UnityEngine.Vector3,
      t: number
    ): UnityEngine.Vector3;

    /*
            Vector3 OrthoNormalize
            parameter normal is ref
          */

    /*
            Vector3 OrthoNormalize
            parameter normal is ref
          */

    static RotateTowards(
      current: UnityEngine.Vector3,
      target: UnityEngine.Vector3,
      maxRadiansDelta: number,
      maxMagnitudeDelta: number
    ): UnityEngine.Vector3;

    static Lerp(
      a: UnityEngine.Vector3,
      b: UnityEngine.Vector3,
      t: number
    ): UnityEngine.Vector3;

    static LerpUnclamped(
      a: UnityEngine.Vector3,
      b: UnityEngine.Vector3,
      t: number
    ): UnityEngine.Vector3;

    static MoveTowards(
      current: UnityEngine.Vector3,
      target: UnityEngine.Vector3,
      maxDistanceDelta: number
    ): UnityEngine.Vector3;

    /*
            Vector3 SmoothDamp
            parameter currentVelocity is ref
          */

    /*
            Vector3 SmoothDamp
            parameter currentVelocity is ref
          */

    /*
            Vector3 SmoothDamp
            parameter currentVelocity is ref
          */

    static Scale(
      a: UnityEngine.Vector3,
      b: UnityEngine.Vector3
    ): UnityEngine.Vector3;

    static Cross(
      lhs: UnityEngine.Vector3,
      rhs: UnityEngine.Vector3
    ): UnityEngine.Vector3;

    static Reflect(
      inDirection: UnityEngine.Vector3,
      inNormal: UnityEngine.Vector3
    ): UnityEngine.Vector3;

    static Normalize(value: UnityEngine.Vector3): UnityEngine.Vector3;

    static Dot(lhs: UnityEngine.Vector3, rhs: UnityEngine.Vector3): number;

    static Project(
      vector: UnityEngine.Vector3,
      onNormal: UnityEngine.Vector3
    ): UnityEngine.Vector3;

    static ProjectOnPlane(
      vector: UnityEngine.Vector3,
      planeNormal: UnityEngine.Vector3
    ): UnityEngine.Vector3;

    static Angle(from: UnityEngine.Vector3, to: UnityEngine.Vector3): number;

    static SignedAngle(
      from: UnityEngine.Vector3,
      to: UnityEngine.Vector3,
      axis: UnityEngine.Vector3
    ): number;

    static Distance(a: UnityEngine.Vector3, b: UnityEngine.Vector3): number;

    static ClampMagnitude(
      vector: UnityEngine.Vector3,
      maxLength: number
    ): UnityEngine.Vector3;

    static Magnitude(vector: UnityEngine.Vector3): number;

    static SqrMagnitude(vector: UnityEngine.Vector3): number;

    static Min(
      lhs: UnityEngine.Vector3,
      rhs: UnityEngine.Vector3
    ): UnityEngine.Vector3;

    static Max(
      lhs: UnityEngine.Vector3,
      rhs: UnityEngine.Vector3
    ): UnityEngine.Vector3;

    // Instance Fields

    x: number;

    y: number;

    z: number;

    // Instance Property Accessors

    readonly normalized: UnityEngine.Vector3;

    readonly magnitude: number;

    readonly sqrMagnitude: number;

    // Instance Methods

    Set(newX: number, newY: number, newZ: number): void;

    Scale(scale: UnityEngine.Vector3): void;

    GetHashCode(): number;

    Equals(other: System.Object): boolean;

    Equals(other: UnityEngine.Vector3): boolean;

    Normalize(): void;

    toString(): string;

    ToString(format: string): string;

    add(other: Vector3): Vector3;
    neg(): Vector3;
    sub(other: Vector3): Vector3;
    mul(d: number): Vector3;
    div(d: number): Vector3;
  }
}
