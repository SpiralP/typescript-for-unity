declare namespace UnityEngine {
  class Matrix4x4 extends System.Object {
    // Static Fields

    // Static Property Accessors

    static readonly zero: UnityEngine.Matrix4x4;

    static readonly identity: UnityEngine.Matrix4x4;

    // Static Methods

    static Determinant(m: UnityEngine.Matrix4x4): number;

    static TRS(
      pos: UnityEngine.Vector3,
      q: UnityEngine.Quaternion,
      s: UnityEngine.Vector3
    ): UnityEngine.Matrix4x4;

    static Inverse(m: UnityEngine.Matrix4x4): UnityEngine.Matrix4x4;

    static Transpose(m: UnityEngine.Matrix4x4): UnityEngine.Matrix4x4;

    static Ortho(
      left: number,
      right: number,
      bottom: number,
      top: number,
      zNear: number,
      zFar: number
    ): UnityEngine.Matrix4x4;

    static Perspective(
      fov: number,
      aspect: number,
      zNear: number,
      zFar: number
    ): UnityEngine.Matrix4x4;

    static LookAt(
      from: UnityEngine.Vector3,
      to: UnityEngine.Vector3,
      up: UnityEngine.Vector3
    ): UnityEngine.Matrix4x4;

    static Frustum(
      left: number,
      right: number,
      bottom: number,
      top: number,
      zNear: number,
      zFar: number
    ): UnityEngine.Matrix4x4;

    static Frustum(fp: UnityEngine.FrustumPlanes): UnityEngine.Matrix4x4;

    static Scale(vector: UnityEngine.Vector3): UnityEngine.Matrix4x4;

    static Translate(vector: UnityEngine.Vector3): UnityEngine.Matrix4x4;

    static Rotate(q: UnityEngine.Quaternion): UnityEngine.Matrix4x4;

    // Instance Fields

    m00: number;

    m10: number;

    m20: number;

    m30: number;

    m01: number;

    m11: number;

    m21: number;

    m31: number;

    m02: number;

    m12: number;

    m22: number;

    m32: number;

    m03: number;

    m13: number;

    m23: number;

    m33: number;

    // Instance Property Accessors

    readonly rotation: UnityEngine.Quaternion;

    readonly lossyScale: UnityEngine.Vector3;

    readonly isIdentity: boolean;

    readonly determinant: number;

    readonly decomposeProjection: UnityEngine.FrustumPlanes;

    readonly inverse: UnityEngine.Matrix4x4;

    readonly transpose: UnityEngine.Matrix4x4;

    // Instance Methods

    ValidTRS(): boolean;

    SetTRS(
      pos: UnityEngine.Vector3,
      q: UnityEngine.Quaternion,
      s: UnityEngine.Vector3
    ): void;

    GetHashCode(): number;

    Equals(other: System.Object): boolean;

    Equals(other: UnityEngine.Matrix4x4): boolean;

    GetColumn(index: number): UnityEngine.Vector4;

    GetRow(index: number): UnityEngine.Vector4;

    SetColumn(index: number, column: UnityEngine.Vector4): void;

    SetRow(index: number, row: UnityEngine.Vector4): void;

    MultiplyPoint(point: UnityEngine.Vector3): UnityEngine.Vector3;

    MultiplyPoint3x4(point: UnityEngine.Vector3): UnityEngine.Vector3;

    MultiplyVector(vector: UnityEngine.Vector3): UnityEngine.Vector3;

    TransformPlane(plane: UnityEngine.Plane): UnityEngine.Plane;

    toString(): string;

    ToString(format: string): string;
  }
}
