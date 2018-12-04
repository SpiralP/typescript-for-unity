declare namespace UnityEngine {
  namespace EventSystems {
    class RaycastResult {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      readonly module: UnityEngine.EventSystems.BaseRaycaster;

      distance: number;

      index: number;

      depth: number;

      sortingLayer: number;

      sortingOrder: number;

      worldPosition: UnityEngine.Vector3;

      worldNormal: UnityEngine.Vector3;

      screenPosition: UnityEngine.Vector2;

      // Instance Property Accessors

      gameObject: UnityEngine.GameObject;

      readonly isValid: boolean;

      // Instance Methods

      Clear(): void;

      toString(): string;
    }
  }
}
