declare namespace UnityEngine {
  namespace EventSystems {
    class PointerEventData extends BaseEventData {
      // Static Fields

      // Static Property Accessors

      // Static Methods

      // Instance Fields

      /*
            PointerEventData hovered
            System.Collections.Generic.List`1[UnityEngine.GameObject] has generics
          */

      // Instance Property Accessors

      pointerEnter: UnityEngine.GameObject;

      lastPress: UnityEngine.GameObject;

      rawPointerPress: UnityEngine.GameObject;

      pointerDrag: UnityEngine.GameObject;

      pointerCurrentRaycast: UnityEngine.EventSystems.RaycastResult;

      pointerPressRaycast: UnityEngine.EventSystems.RaycastResult;

      eligibleForClick: boolean;

      pointerId: number;

      position: UnityEngine.Vector2;

      delta: UnityEngine.Vector2;

      pressPosition: UnityEngine.Vector2;

      clickTime: number;

      clickCount: number;

      scrollDelta: UnityEngine.Vector2;

      useDragThreshold: boolean;

      dragging: boolean;

      button: UnityEngine.EventSystems.PointerEventData.InputButton;

      readonly enterEventCamera: UnityEngine.Camera;

      readonly pressEventCamera: UnityEngine.Camera;

      pointerPress: UnityEngine.GameObject;

      // Instance Methods

      IsPointerMoving(): boolean;

      IsScrolling(): boolean;

      toString(): string;
    }
  }
}
