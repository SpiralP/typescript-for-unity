declare namespace UnityEngine {
  class MonoBehaviour extends Behaviour {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    static print(message: System.Object): void;

    // Instance Fields

    // Instance Property Accessors

    useGUILayout: boolean;

    runInEditMode: boolean;

    // Instance Methods

    IsInvoking(): boolean;

    CancelInvoke(): void;

    Invoke(methodName: string, time: number): void;

    InvokeRepeating(methodName: string, time: number, repeatRate: number): void;

    CancelInvoke(methodName: string): void;

    IsInvoking(methodName: string): boolean;

    StartCoroutine(methodName: string): UnityEngine.Coroutine;

    StartCoroutine(
      methodName: string,
      value: System.Object
    ): UnityEngine.Coroutine;

    StartCoroutine(
      routine: System.Collections.IEnumerator
    ): UnityEngine.Coroutine;

    StopCoroutine(routine: System.Collections.IEnumerator): void;

    StopCoroutine(routine: UnityEngine.Coroutine): void;

    StopCoroutine(methodName: string): void;

    StopAllCoroutines(): void;
  }
}
