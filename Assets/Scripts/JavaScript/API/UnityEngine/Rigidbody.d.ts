declare namespace UnityEngine {
  class Rigidbody extends Component {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    velocity: UnityEngine.Vector3;

    angularVelocity: UnityEngine.Vector3;

    drag: number;

    angularDrag: number;

    mass: number;

    useGravity: boolean;

    maxDepenetrationVelocity: number;

    isKinematic: boolean;

    freezeRotation: boolean;

    constraints: UnityEngine.RigidbodyConstraints;

    collisionDetectionMode: UnityEngine.CollisionDetectionMode;

    centerOfMass: UnityEngine.Vector3;

    readonly worldCenterOfMass: UnityEngine.Vector3;

    inertiaTensorRotation: UnityEngine.Quaternion;

    inertiaTensor: UnityEngine.Vector3;

    detectCollisions: boolean;

    position: UnityEngine.Vector3;

    rotation: UnityEngine.Quaternion;

    interpolation: UnityEngine.RigidbodyInterpolation;

    solverIterations: number;

    sleepThreshold: number;

    maxAngularVelocity: number;

    solverVelocityIterations: number;

    // Instance Methods

    SetDensity(density: number): void;

    MovePosition(position: UnityEngine.Vector3): void;

    MoveRotation(rot: UnityEngine.Quaternion): void;

    Sleep(): void;

    IsSleeping(): boolean;

    WakeUp(): void;

    ResetCenterOfMass(): void;

    ResetInertiaTensor(): void;

    GetRelativePointVelocity(
      relativePoint: UnityEngine.Vector3
    ): UnityEngine.Vector3;

    GetPointVelocity(worldPoint: UnityEngine.Vector3): UnityEngine.Vector3;

    AddForce(force: UnityEngine.Vector3, mode: UnityEngine.ForceMode): void;

    AddForce(force: UnityEngine.Vector3): void;

    AddForce(
      x: number,
      y: number,
      z: number,
      mode: UnityEngine.ForceMode
    ): void;

    AddForce(x: number, y: number, z: number): void;

    AddRelativeForce(
      force: UnityEngine.Vector3,
      mode: UnityEngine.ForceMode
    ): void;

    AddRelativeForce(force: UnityEngine.Vector3): void;

    AddRelativeForce(
      x: number,
      y: number,
      z: number,
      mode: UnityEngine.ForceMode
    ): void;

    AddRelativeForce(x: number, y: number, z: number): void;

    AddTorque(torque: UnityEngine.Vector3, mode: UnityEngine.ForceMode): void;

    AddTorque(torque: UnityEngine.Vector3): void;

    AddTorque(
      x: number,
      y: number,
      z: number,
      mode: UnityEngine.ForceMode
    ): void;

    AddTorque(x: number, y: number, z: number): void;

    AddRelativeTorque(
      torque: UnityEngine.Vector3,
      mode: UnityEngine.ForceMode
    ): void;

    AddRelativeTorque(torque: UnityEngine.Vector3): void;

    AddRelativeTorque(
      x: number,
      y: number,
      z: number,
      mode: UnityEngine.ForceMode
    ): void;

    AddRelativeTorque(x: number, y: number, z: number): void;

    AddForceAtPosition(
      force: UnityEngine.Vector3,
      position: UnityEngine.Vector3,
      mode: UnityEngine.ForceMode
    ): void;

    AddForceAtPosition(
      force: UnityEngine.Vector3,
      position: UnityEngine.Vector3
    ): void;

    AddExplosionForce(
      explosionForce: number,
      explosionPosition: UnityEngine.Vector3,
      explosionRadius: number,
      upwardsModifier: number,
      mode: UnityEngine.ForceMode
    ): void;

    AddExplosionForce(
      explosionForce: number,
      explosionPosition: UnityEngine.Vector3,
      explosionRadius: number,
      upwardsModifier: number
    ): void;

    AddExplosionForce(
      explosionForce: number,
      explosionPosition: UnityEngine.Vector3,
      explosionRadius: number
    ): void;

    ClosestPointOnBounds(position: UnityEngine.Vector3): UnityEngine.Vector3;

    /*
            Rigidbody SweepTest
            parameter hitInfo is out
          */

    /*
            Rigidbody SweepTest
            parameter hitInfo is out
          */

    /*
            Rigidbody SweepTest
            parameter hitInfo is out
          */

    SweepTestAll(
      direction: UnityEngine.Vector3,
      maxDistance: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.RaycastHit[];

    SweepTestAll(
      direction: UnityEngine.Vector3,
      maxDistance: number
    ): UnityEngine.RaycastHit[];

    SweepTestAll(direction: UnityEngine.Vector3): UnityEngine.RaycastHit[];
  }
}
