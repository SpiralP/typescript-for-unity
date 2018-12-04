declare namespace UnityEngine {
  class Vector2 extends System.Object {
    // Static Fields

    static readonly kEpsilon: number;

    static readonly kEpsilonNormalSqrt: number;

    // Static Property Accessors

    static readonly zero: UnityEngine.Vector2;

    static readonly one: UnityEngine.Vector2;

    static readonly up: UnityEngine.Vector2;

    static readonly down: UnityEngine.Vector2;

    static readonly left: UnityEngine.Vector2;

    static readonly right: UnityEngine.Vector2;

    static readonly positiveInfinity: UnityEngine.Vector2;

    static readonly negativeInfinity: UnityEngine.Vector2;

    // Static Methods

    static Lerp(
      a: UnityEngine.Vector2,
      b: UnityEngine.Vector2,
      t: number
    ): UnityEngine.Vector2;

    static LerpUnclamped(
      a: UnityEngine.Vector2,
      b: UnityEngine.Vector2,
      t: number
    ): UnityEngine.Vector2;

    static MoveTowards(
      current: UnityEngine.Vector2,
      target: UnityEngine.Vector2,
      maxDistanceDelta: number
    ): UnityEngine.Vector2;

    static Scale(
      a: UnityEngine.Vector2,
      b: UnityEngine.Vector2
    ): UnityEngine.Vector2;

    static Reflect(
      inDirection: UnityEngine.Vector2,
      inNormal: UnityEngine.Vector2
    ): UnityEngine.Vector2;

    static Perpendicular(inDirection: UnityEngine.Vector2): UnityEngine.Vector2;

    static Dot(lhs: UnityEngine.Vector2, rhs: UnityEngine.Vector2): number;

    static Angle(from: UnityEngine.Vector2, to: UnityEngine.Vector2): number;

    static SignedAngle(
      from: UnityEngine.Vector2,
      to: UnityEngine.Vector2
    ): number;

    static Distance(a: UnityEngine.Vector2, b: UnityEngine.Vector2): number;

    static ClampMagnitude(
      vector: UnityEngine.Vector2,
      maxLength: number
    ): UnityEngine.Vector2;

    static SqrMagnitude(a: UnityEngine.Vector2): number;

    static Min(
      lhs: UnityEngine.Vector2,
      rhs: UnityEngine.Vector2
    ): UnityEngine.Vector2;

    static Max(
      lhs: UnityEngine.Vector2,
      rhs: UnityEngine.Vector2
    ): UnityEngine.Vector2;

    /*
            Vector2 SmoothDamp
            parameter currentVelocity is ref
          */

    /*
            Vector2 SmoothDamp
            parameter currentVelocity is ref
          */

    /*
            Vector2 SmoothDamp
            parameter currentVelocity is ref
          */

    // Instance Fields

    x: number;

    y: number;

    // Instance Property Accessors

    readonly normalized: UnityEngine.Vector2;

    readonly magnitude: number;

    readonly sqrMagnitude: number;

    // Instance Methods

    Set(newX: number, newY: number): void;

    Scale(scale: UnityEngine.Vector2): void;

    Normalize(): void;

    toString(): string;

    ToString(format: string): string;

    GetHashCode(): number;

    Equals(other: System.Object): boolean;

    Equals(other: UnityEngine.Vector2): boolean;

    SqrMagnitude(): number;
  }
}
