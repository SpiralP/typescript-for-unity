declare namespace UnityEngine {
  class GameObject extends UnityEngine.Object {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    static CreatePrimitive(
      type: UnityEngine.PrimitiveType
    ): UnityEngine.GameObject;

    static FindWithTag(tag: string): UnityEngine.GameObject;

    static FindGameObjectWithTag(tag: string): UnityEngine.GameObject;

    static FindGameObjectsWithTag(tag: string): UnityEngine.GameObject[];

    static Find(name: string): UnityEngine.GameObject;

    // Instance Fields

    // Instance Property Accessors

    readonly transform: UnityEngine.Transform;

    layer: number;

    readonly activeSelf: boolean;

    readonly activeInHierarchy: boolean;

    isStatic: boolean;

    tag: string;

    // readonly scene: UnityEngine.SceneManagement.Scene;

    readonly gameObject: UnityEngine.GameObject;

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

    SendMessageUpwards(
      methodName: string,
      options: UnityEngine.SendMessageOptions
    ): void;

    SendMessage(
      methodName: string,
      options: UnityEngine.SendMessageOptions
    ): void;

    BroadcastMessage(
      methodName: string,
      options: UnityEngine.SendMessageOptions
    ): void;

    AddComponent<T extends { prototype: {} }>(
      componentConstructor: T
    ): T["prototype"];

    SetActive(value: boolean): void;

    CompareTag(tag: string): boolean;

    SendMessageUpwards(
      methodName: string,
      value: System.Object,
      options: UnityEngine.SendMessageOptions
    ): void;

    SendMessageUpwards(methodName: string, value: System.Object): void;

    SendMessageUpwards(methodName: string): void;

    SendMessage(
      methodName: string,
      value: System.Object,
      options: UnityEngine.SendMessageOptions
    ): void;

    SendMessage(methodName: string, value: System.Object): void;

    SendMessage(methodName: string): void;

    BroadcastMessage(
      methodName: string,
      parameter: System.Object,
      options: UnityEngine.SendMessageOptions
    ): void;

    BroadcastMessage(methodName: string, parameter: System.Object): void;

    BroadcastMessage(methodName: string): void;
  }
}
