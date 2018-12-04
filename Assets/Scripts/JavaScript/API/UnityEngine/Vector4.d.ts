declare namespace UnityEngine {
  class Vector4 extends System.Object {
    // Static Fields

    static readonly kEpsilon: number;

    // Static Property Accessors

    static readonly zero: UnityEngine.Vector4;

    static readonly one: UnityEngine.Vector4;

    static readonly positiveInfinity: UnityEngine.Vector4;

    static readonly negativeInfinity: UnityEngine.Vector4;

    // Static Methods

    static Lerp(
      a: UnityEngine.Vector4,
      b: UnityEngine.Vector4,
      t: number
    ): UnityEngine.Vector4;

    static LerpUnclamped(
      a: UnityEngine.Vector4,
      b: UnityEngine.Vector4,
      t: number
    ): UnityEngine.Vector4;

    static MoveTowards(
      current: UnityEngine.Vector4,
      target: UnityEngine.Vector4,
      maxDistanceDelta: number
    ): UnityEngine.Vector4;

    static Scale(
      a: UnityEngine.Vector4,
      b: UnityEngine.Vector4
    ): UnityEngine.Vector4;

    static Normalize(a: UnityEngine.Vector4): UnityEngine.Vector4;

    static Dot(a: UnityEngine.Vector4, b: UnityEngine.Vector4): number;

    static Project(
      a: UnityEngine.Vector4,
      b: UnityEngine.Vector4
    ): UnityEngine.Vector4;

    static Distance(a: UnityEngine.Vector4, b: UnityEngine.Vector4): number;

    static Magnitude(a: UnityEngine.Vector4): number;

    static Min(
      lhs: UnityEngine.Vector4,
      rhs: UnityEngine.Vector4
    ): UnityEngine.Vector4;

    static Max(
      lhs: UnityEngine.Vector4,
      rhs: UnityEngine.Vector4
    ): UnityEngine.Vector4;

    static SqrMagnitude(a: UnityEngine.Vector4): number;

    // Instance Fields

    x: number;

    y: number;

    z: number;

    w: number;

    // Instance Property Accessors

    readonly normalized: UnityEngine.Vector4;

    readonly magnitude: number;

    readonly sqrMagnitude: number;

    // Instance Methods

    Set(newX: number, newY: number, newZ: number, newW: number): void;

    Scale(scale: UnityEngine.Vector4): void;

    GetHashCode(): number;

    Equals(other: System.Object): boolean;

    Equals(other: UnityEngine.Vector4): boolean;

    Normalize(): void;

    toString(): string;

    ToString(format: string): string;

    SqrMagnitude(): number;
  }
}
