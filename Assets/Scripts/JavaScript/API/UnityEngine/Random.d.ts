declare namespace UnityEngine {
  class Random {
    // Static Fields

    // Static Property Accessors

    static state: UnityEngine.Random.State;

    static readonly value: number;

    static readonly insideUnitSphere: UnityEngine.Vector3;

    static readonly insideUnitCircle: UnityEngine.Vector2;

    static readonly onUnitSphere: UnityEngine.Vector3;

    static readonly rotation: UnityEngine.Quaternion;

    static readonly rotationUniform: UnityEngine.Quaternion;

    // Static Methods

    static InitState(seed: number): void;

    static Range(min: number, max: number): number;

    static Range(min: number, max: number): number;

    static ColorHSV(): UnityEngine.Color;

    static ColorHSV(hueMin: number, hueMax: number): UnityEngine.Color;

    static ColorHSV(
      hueMin: number,
      hueMax: number,
      saturationMin: number,
      saturationMax: number
    ): UnityEngine.Color;

    static ColorHSV(
      hueMin: number,
      hueMax: number,
      saturationMin: number,
      saturationMax: number,
      valueMin: number,
      valueMax: number
    ): UnityEngine.Color;

    static ColorHSV(
      hueMin: number,
      hueMax: number,
      saturationMin: number,
      saturationMax: number,
      valueMin: number,
      valueMax: number,
      alphaMin: number,
      alphaMax: number
    ): UnityEngine.Color;

    // Instance Fields

    // Instance Property Accessors

    // Instance Methods
  }
}
