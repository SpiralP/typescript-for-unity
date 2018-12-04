export default class JSCubeBehaviour extends JSBehaviour {
  _transform: UnityEngine.Transform;

  Start() {
    this._transform = this.monoBehaviour.gameObject.GetComponent(
      UnityEngine.Transform
    )!;
  }

  Update() {
    const movement = new UnityEngine.Vector3(0, 0, 0.1);
    const newPos = this._transform.position.add(movement);
    this._transform.position = newPos;
  }
}
