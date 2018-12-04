declare namespace UnityEngine {
  class Component extends UnityEngine.Object {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    readonly transform: UnityEngine.Transform;

    readonly gameObject: UnityEngine.GameObject;

    tag: string;

    // Instance Methods

    GetComponent<T extends { prototype: {} }>(
      constructor: T
    ): T["prototype"] | null;
    GetComponent(name: string): UnityEngine.Component;

    GetComponentInChildren<T extends { prototype: {} }>(
      constructor: T,
      includeInactive?: boolean
    ): T["prototype"] | null;

    GetComponentInParent<T extends { prototype: {} }>(
      constructor: T
    ): T["prototype"] | null;

    GetComponents<T extends { prototype: {} }>(
      constructor: T
    ): Array<T["prototype"]>;

    GetComponentsInChildren<T extends { prototype: {} }>(
      constructor: T,
      includeInactive?: boolean
    ): Array<T["prototype"]>;

    GetComponentsInParent<T extends { prototype: {} }>(
      constructor: T,
      includeInactive?: boolean
    ): Array<T["prototype"]>;

    CompareTag(tag: string): boolean;

    SendMessageUpwards(
      methodName: string,
      value: System.Object,
      options: UnityEngine.SendMessageOptions
    ): void;

    SendMessageUpwards(methodName: string, value: System.Object): void;

    SendMessageUpwards(methodName: string): void;

    SendMessageUpwards(
      methodName: string,
      options: UnityEngine.SendMessageOptions
    ): void;

    SendMessage(methodName: string, value: System.Object): void;

    SendMessage(methodName: string): void;

    SendMessage(
      methodName: string,
      value: System.Object,
      options: UnityEngine.SendMessageOptions
    ): void;

    SendMessage(
      methodName: string,
      options: UnityEngine.SendMessageOptions
    ): void;

    BroadcastMessage(
      methodName: string,
      parameter: System.Object,
      options: UnityEngine.SendMessageOptions
    ): void;

    BroadcastMessage(methodName: string, parameter: System.Object): void;

    BroadcastMessage(methodName: string): void;

    BroadcastMessage(
      methodName: string,
      options: UnityEngine.SendMessageOptions
    ): void;
  }
}
