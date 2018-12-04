declare class JSBehaviour {
  monoBehaviour: UnityEngine.MonoBehaviour;

  constructor(monoBehaviour: UnityEngine.MonoBehaviour);

  AddDelegate(delegate: JSBehaviour): void;
}
