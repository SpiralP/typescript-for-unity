declare namespace UnityEngine {
  class CharacterController extends Collider {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    readonly velocity: UnityEngine.Vector3;

    readonly isGrounded: boolean;

    readonly collisionFlags: UnityEngine.CollisionFlags;

    radius: number;

    height: number;

    center: UnityEngine.Vector3;

    slopeLimit: number;

    stepOffset: number;

    skinWidth: number;

    minMoveDistance: number;

    detectCollisions: boolean;

    enableOverlapRecovery: boolean;

    // Instance Methods

    SimpleMove(speed: UnityEngine.Vector3): boolean;

    Move(motion: UnityEngine.Vector3): UnityEngine.CollisionFlags;
  }
}
