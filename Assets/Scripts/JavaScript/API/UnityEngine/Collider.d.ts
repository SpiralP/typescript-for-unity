declare namespace UnityEngine {
  class Collider extends Component {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    enabled: boolean;

    readonly attachedRigidbody: UnityEngine.Rigidbody;

    isTrigger: boolean;

    contactOffset: number;

    readonly bounds: UnityEngine.Bounds;

    sharedMaterial: UnityEngine.PhysicMaterial;

    material: UnityEngine.PhysicMaterial;

    // Instance Methods

    ClosestPoint(position: UnityEngine.Vector3): UnityEngine.Vector3;

    /*
            Collider Raycast
            parameter hitInfo is out
          */

    ClosestPointOnBounds(position: UnityEngine.Vector3): UnityEngine.Vector3;
  }
}
