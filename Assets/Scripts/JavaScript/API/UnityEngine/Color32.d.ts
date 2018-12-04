declare namespace UnityEngine {
  class Color32 extends System.Object {
    constructor(r: byte, g: byte, b: byte, a: byte);
    // Static Fields

    // Static Property Accessors

    // Static Methods

    static Lerp(
      a: UnityEngine.Color32,
      b: UnityEngine.Color32,
      t: number
    ): UnityEngine.Color32;

    static LerpUnclamped(
      a: UnityEngine.Color32,
      b: UnityEngine.Color32,
      t: number
    ): UnityEngine.Color32;

    // Instance Fields

    r: System.Byte;

    g: System.Byte;

    b: System.Byte;

    a: System.Byte;

    // Instance Property Accessors

    // Instance Methods

    toString(): string;

    toString(format: string): string;

    ToColor(): UnityEngine.Color;
  }
}
