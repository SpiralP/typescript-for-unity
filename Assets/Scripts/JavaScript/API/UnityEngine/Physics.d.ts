declare namespace UnityEngine {
  class Physics {
    // Static Fields

    static readonly IgnoreRaycastLayer: number;

    static readonly DefaultRaycastLayers: number;

    static readonly AllLayers: number;

    // Static Property Accessors

    static gravity: UnityEngine.Vector3;

    static defaultContactOffset: number;

    static sleepThreshold: number;

    static queriesHitTriggers: boolean;

    static queriesHitBackfaces: boolean;

    static bounceThreshold: number;

    static defaultSolverIterations: number;

    static defaultSolverVelocityIterations: number;

    static autoSimulation: boolean;

    static autoSyncTransforms: boolean;

    static interCollisionDistance: number;

    static interCollisionStiffness: number;

    static interCollisionSettingsToggle: boolean;

    // Static Methods

    static IgnoreCollision(
      collider1: UnityEngine.Collider,
      collider2: UnityEngine.Collider,
      ignore: boolean
    ): void;

    static IgnoreCollision(
      collider1: UnityEngine.Collider,
      collider2: UnityEngine.Collider
    ): void;

    static IgnoreLayerCollision(
      layer1: number,
      layer2: number,
      ignore: boolean
    ): void;

    static IgnoreLayerCollision(layer1: number, layer2: number): void;

    static GetIgnoreLayerCollision(layer1: number, layer2: number): boolean;

    // static Raycast(
    //   origin: UnityEngine.Vector3,
    //   direction: UnityEngine.Vector3,
    //   maxDistance: number,
    //   layerMask: number,
    //   queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    // ): boolean;

    // static Raycast(
    //   origin: UnityEngine.Vector3,
    //   direction: UnityEngine.Vector3,
    //   maxDistance: number,
    //   layerMask: number
    // ): boolean;

    // static Raycast(
    //   origin: UnityEngine.Vector3,
    //   direction: UnityEngine.Vector3,
    //   maxDistance: number
    // ): boolean;

    // static Raycast(
    //   origin: UnityEngine.Vector3,
    //   direction: UnityEngine.Vector3
    // ): boolean;

    /*
            Physics Raycast
            parameter hitInfo is out
          */

    /*
            Physics Raycast
            parameter hitInfo is out
          */

    /*
            Physics Raycast
            parameter hitInfo is out
          */

    /*
            Physics Raycast
            parameter hitInfo is out
          */

    // static Raycast(
    //   ray: UnityEngine.Ray,
    //   maxDistance: number,
    //   layerMask: number,
    //   queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    // ): boolean;

    // static Raycast(
    //   ray: UnityEngine.Ray,
    //   maxDistance: number,
    //   layerMask: number
    // ): boolean;

    // static Raycast(ray: UnityEngine.Ray, maxDistance: number): boolean;

    // static Raycast(ray: UnityEngine.Ray): boolean;

    // TODO
    static Raycast(ray: Ray): { hit: boolean; hitInfo: RaycastHit };
    static Raycast(
      origin: Vector3,
      direction: Vector3
    ): { hit: boolean; hitInfo: RaycastHit };

    /*
            Physics Raycast
            parameter hitInfo is out
          */

    /*
            Physics Raycast
            parameter hitInfo is out
          */

    /*
            Physics Raycast
            parameter hitInfo is out
          */

    /*
            Physics Raycast
            parameter hitInfo is out
          */

    static Linecast(
      start: UnityEngine.Vector3,
      end: UnityEngine.Vector3,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): boolean;

    static Linecast(
      start: UnityEngine.Vector3,
      end: UnityEngine.Vector3,
      layerMask: number
    ): boolean;

    static Linecast(
      start: UnityEngine.Vector3,
      end: UnityEngine.Vector3
    ): boolean;

    /*
            Physics Linecast
            parameter hitInfo is out
          */

    /*
            Physics Linecast
            parameter hitInfo is out
          */

    /*
            Physics Linecast
            parameter hitInfo is out
          */

    static CapsuleCast(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): boolean;

    static CapsuleCast(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number,
      layerMask: number
    ): boolean;

    static CapsuleCast(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number
    ): boolean;

    static CapsuleCast(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3
    ): boolean;

    /*
            Physics CapsuleCast
            parameter hitInfo is out
          */

    /*
            Physics CapsuleCast
            parameter hitInfo is out
          */

    /*
            Physics CapsuleCast
            parameter hitInfo is out
          */

    /*
            Physics CapsuleCast
            parameter hitInfo is out
          */

    /*
            Physics SphereCast
            parameter hitInfo is out
          */

    /*
            Physics SphereCast
            parameter hitInfo is out
          */

    /*
            Physics SphereCast
            parameter hitInfo is out
          */

    /*
            Physics SphereCast
            parameter hitInfo is out
          */

    static SphereCast(
      ray: UnityEngine.Ray,
      radius: number,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): boolean;

    static SphereCast(
      ray: UnityEngine.Ray,
      radius: number,
      maxDistance: number,
      layerMask: number
    ): boolean;

    static SphereCast(
      ray: UnityEngine.Ray,
      radius: number,
      maxDistance: number
    ): boolean;

    static SphereCast(ray: UnityEngine.Ray, radius: number): boolean;

    /*
            Physics SphereCast
            parameter hitInfo is out
          */

    /*
            Physics SphereCast
            parameter hitInfo is out
          */

    /*
            Physics SphereCast
            parameter hitInfo is out
          */

    /*
            Physics SphereCast
            parameter hitInfo is out
          */

    static BoxCast(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): boolean;

    static BoxCast(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      maxDistance: number,
      layerMask: number
    ): boolean;

    static BoxCast(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      maxDistance: number
    ): boolean;

    static BoxCast(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion
    ): boolean;

    static BoxCast(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3
    ): boolean;

    /*
            Physics BoxCast
            parameter hitInfo is out
          */

    /*
            Physics BoxCast
            parameter hitInfo is out
          */

    /*
            Physics BoxCast
            parameter hitInfo is out
          */

    /*
            Physics BoxCast
            parameter hitInfo is out
          */

    /*
            Physics BoxCast
            parameter hitInfo is out
          */

    static RaycastAll(
      origin: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.RaycastHit[];

    static RaycastAll(
      origin: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      maxDistance: number,
      layerMask: number
    ): UnityEngine.RaycastHit[];

    static RaycastAll(
      origin: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      maxDistance: number
    ): UnityEngine.RaycastHit[];

    static RaycastAll(
      origin: UnityEngine.Vector3,
      direction: UnityEngine.Vector3
    ): UnityEngine.RaycastHit[];

    static RaycastAll(
      ray: UnityEngine.Ray,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.RaycastHit[];

    static RaycastAll(
      ray: UnityEngine.Ray,
      maxDistance: number,
      layerMask: number
    ): UnityEngine.RaycastHit[];

    static RaycastAll(
      ray: UnityEngine.Ray,
      maxDistance: number
    ): UnityEngine.RaycastHit[];

    static RaycastAll(ray: UnityEngine.Ray): UnityEngine.RaycastHit[];

    static CapsuleCastAll(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.RaycastHit[];

    static CapsuleCastAll(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number,
      layerMask: number
    ): UnityEngine.RaycastHit[];

    static CapsuleCastAll(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number
    ): UnityEngine.RaycastHit[];

    static CapsuleCastAll(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3
    ): UnityEngine.RaycastHit[];

    static SphereCastAll(
      origin: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.RaycastHit[];

    static SphereCastAll(
      origin: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number,
      layerMask: number
    ): UnityEngine.RaycastHit[];

    static SphereCastAll(
      origin: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      maxDistance: number
    ): UnityEngine.RaycastHit[];

    static SphereCastAll(
      origin: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3
    ): UnityEngine.RaycastHit[];

    static SphereCastAll(
      ray: UnityEngine.Ray,
      radius: number,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.RaycastHit[];

    static SphereCastAll(
      ray: UnityEngine.Ray,
      radius: number,
      maxDistance: number,
      layerMask: number
    ): UnityEngine.RaycastHit[];

    static SphereCastAll(
      ray: UnityEngine.Ray,
      radius: number,
      maxDistance: number
    ): UnityEngine.RaycastHit[];

    static SphereCastAll(
      ray: UnityEngine.Ray,
      radius: number
    ): UnityEngine.RaycastHit[];

    static OverlapCapsule(
      point0: UnityEngine.Vector3,
      point1: UnityEngine.Vector3,
      radius: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.Collider[];

    static OverlapCapsule(
      point0: UnityEngine.Vector3,
      point1: UnityEngine.Vector3,
      radius: number,
      layerMask: number
    ): UnityEngine.Collider[];

    static OverlapCapsule(
      point0: UnityEngine.Vector3,
      point1: UnityEngine.Vector3,
      radius: number
    ): UnityEngine.Collider[];

    static OverlapSphere(
      position: UnityEngine.Vector3,
      radius: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.Collider[];

    static OverlapSphere(
      position: UnityEngine.Vector3,
      radius: number,
      layerMask: number
    ): UnityEngine.Collider[];

    static OverlapSphere(
      position: UnityEngine.Vector3,
      radius: number
    ): UnityEngine.Collider[];

    static Simulate(step: number): void;

    static SyncTransforms(): void;

    /*
            Physics ComputePenetration
            parameter direction is out
          */

    static ClosestPoint(
      point: UnityEngine.Vector3,
      collider: UnityEngine.Collider,
      position: UnityEngine.Vector3,
      rotation: UnityEngine.Quaternion
    ): UnityEngine.Vector3;

    static RaycastNonAlloc(
      ray: UnityEngine.Ray,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): number;

    static RaycastNonAlloc(
      ray: UnityEngine.Ray,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number
    ): number;

    static RaycastNonAlloc(
      ray: UnityEngine.Ray,
      results: UnityEngine.RaycastHit[],
      maxDistance: number
    ): number;

    static RaycastNonAlloc(
      ray: UnityEngine.Ray,
      results: UnityEngine.RaycastHit[]
    ): number;

    static RaycastNonAlloc(
      origin: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): number;

    static RaycastNonAlloc(
      origin: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number
    ): number;

    static RaycastNonAlloc(
      origin: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number
    ): number;

    static RaycastNonAlloc(
      origin: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[]
    ): number;

    /*
            Physics OverlapSphereNonAlloc
            parameter results is out
          */

    /*
            Physics OverlapSphereNonAlloc
            parameter results is out
          */

    /*
            Physics OverlapSphereNonAlloc
            parameter results is out
          */

    static CheckSphere(
      position: UnityEngine.Vector3,
      radius: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): boolean;

    static CheckSphere(
      position: UnityEngine.Vector3,
      radius: number,
      layerMask: number
    ): boolean;

    static CheckSphere(position: UnityEngine.Vector3, radius: number): boolean;

    static CapsuleCastNonAlloc(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): number;

    static CapsuleCastNonAlloc(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number
    ): number;

    static CapsuleCastNonAlloc(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number
    ): number;

    static CapsuleCastNonAlloc(
      point1: UnityEngine.Vector3,
      point2: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[]
    ): number;

    static SphereCastNonAlloc(
      origin: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): number;

    static SphereCastNonAlloc(
      origin: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number
    ): number;

    static SphereCastNonAlloc(
      origin: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      maxDistance: number
    ): number;

    static SphereCastNonAlloc(
      origin: UnityEngine.Vector3,
      radius: number,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[]
    ): number;

    static SphereCastNonAlloc(
      ray: UnityEngine.Ray,
      radius: number,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): number;

    static SphereCastNonAlloc(
      ray: UnityEngine.Ray,
      radius: number,
      results: UnityEngine.RaycastHit[],
      maxDistance: number,
      layerMask: number
    ): number;

    static SphereCastNonAlloc(
      ray: UnityEngine.Ray,
      radius: number,
      results: UnityEngine.RaycastHit[],
      maxDistance: number
    ): number;

    static SphereCastNonAlloc(
      ray: UnityEngine.Ray,
      radius: number,
      results: UnityEngine.RaycastHit[]
    ): number;

    static CheckCapsule(
      start: UnityEngine.Vector3,
      end: UnityEngine.Vector3,
      radius: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): boolean;

    static CheckCapsule(
      start: UnityEngine.Vector3,
      end: UnityEngine.Vector3,
      radius: number,
      layerMask: number
    ): boolean;

    static CheckCapsule(
      start: UnityEngine.Vector3,
      end: UnityEngine.Vector3,
      radius: number
    ): boolean;

    static CheckBox(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      layermask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): boolean;

    static CheckBox(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      layerMask: number
    ): boolean;

    static CheckBox(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion
    ): boolean;

    static CheckBox(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3
    ): boolean;

    static OverlapBox(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.Collider[];

    static OverlapBox(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      layerMask: number
    ): UnityEngine.Collider[];

    static OverlapBox(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion
    ): UnityEngine.Collider[];

    static OverlapBox(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3
    ): UnityEngine.Collider[];

    /*
            Physics OverlapBoxNonAlloc
            parameter results is out
          */

    /*
            Physics OverlapBoxNonAlloc
            parameter results is out
          */

    /*
            Physics OverlapBoxNonAlloc
            parameter results is out
          */

    /*
            Physics OverlapBoxNonAlloc
            parameter results is out
          */

    static BoxCastNonAlloc(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      orientation: UnityEngine.Quaternion,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): number;

    static BoxCastNonAlloc(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      orientation: UnityEngine.Quaternion
    ): number;

    static BoxCastNonAlloc(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      orientation: UnityEngine.Quaternion,
      maxDistance: number
    ): number;

    static BoxCastNonAlloc(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[],
      orientation: UnityEngine.Quaternion,
      maxDistance: number,
      layerMask: number
    ): number;

    static BoxCastNonAlloc(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      results: UnityEngine.RaycastHit[]
    ): number;

    static BoxCastAll(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      maxDistance: number,
      layerMask: number,
      queryTriggerInteraction: UnityEngine.QueryTriggerInteraction
    ): UnityEngine.RaycastHit[];

    static BoxCastAll(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      maxDistance: number,
      layerMask: number
    ): UnityEngine.RaycastHit[];

    static BoxCastAll(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion,
      maxDistance: number
    ): UnityEngine.RaycastHit[];

    static BoxCastAll(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3,
      orientation: UnityEngine.Quaternion
    ): UnityEngine.RaycastHit[];

    static BoxCastAll(
      center: UnityEngine.Vector3,
      halfExtents: UnityEngine.Vector3,
      direction: UnityEngine.Vector3
    ): UnityEngine.RaycastHit[];

    /*
            Physics OverlapCapsuleNonAlloc
            parameter results is out
          */

    /*
            Physics OverlapCapsuleNonAlloc
            parameter results is out
          */

    /*
            Physics OverlapCapsuleNonAlloc
            parameter results is out
          */

    static RebuildBroadphaseRegions(
      worldBounds: UnityEngine.Bounds,
      subdivisions: number
    ): void;

    // Instance Fields

    // Instance Property Accessors

    // Instance Methods
  }
}
