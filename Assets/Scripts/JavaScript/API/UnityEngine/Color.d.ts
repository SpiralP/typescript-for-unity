declare namespace UnityEngine {
  class Color extends System.Object {
    // Static Fields

    // Static Property Accessors

    static readonly red: UnityEngine.Color;

    static readonly green: UnityEngine.Color;

    static readonly blue: UnityEngine.Color;

    static readonly white: UnityEngine.Color;

    static readonly black: UnityEngine.Color;

    static readonly yellow: UnityEngine.Color;

    static readonly cyan: UnityEngine.Color;

    static readonly magenta: UnityEngine.Color;

    static readonly gray: UnityEngine.Color;

    static readonly grey: UnityEngine.Color;

    static readonly clear: UnityEngine.Color;

    // Static Methods

    static Lerp(
      a: UnityEngine.Color,
      b: UnityEngine.Color,
      t: number
    ): UnityEngine.Color;

    static LerpUnclamped(
      a: UnityEngine.Color,
      b: UnityEngine.Color,
      t: number
    ): UnityEngine.Color;

    /*
            Color RGBToHSV
            parameter H is out
          */

    static HSVToRGB(H: number, S: number, V: number): UnityEngine.Color;

    static HSVToRGB(
      H: number,
      S: number,
      V: number,
      hdr: boolean
    ): UnityEngine.Color;

    // Instance Fields

    r: number;

    g: number;

    b: number;

    a: number;

    // Instance Property Accessors

    readonly grayscale: number;

    readonly linear: UnityEngine.Color;

    readonly gamma: UnityEngine.Color;

    readonly maxColorComponent: number;

    // Instance Methods

    toString(): string;

    toString(format: string): string;

    GetHashCode(): number;

    Equals(other: System.Object): boolean;

    Equals(other: UnityEngine.Color): boolean;

    ToColor32(): UnityEngine.Color32;
  }
}
