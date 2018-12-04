using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSRigidbody {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RigidbodyPrototype;
      JavaScriptValue RigidbodyConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Rigidbody),
        (args) => { throw new System.NotImplementedException(); },
        out RigidbodyPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Rigidbody", RigidbodyConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "velocity",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.velocity)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.velocity = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "angularVelocity",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.angularVelocity)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.angularVelocity = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "drag",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromDouble(o.drag)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.drag = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "angularDrag",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromDouble(o.angularDrag)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.angularDrag = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "mass",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromDouble(o.mass)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.mass = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "useGravity",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromBoolean(o.useGravity)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.useGravity = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "maxDepenetrationVelocity",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromDouble(o.maxDepenetrationVelocity)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.maxDepenetrationVelocity = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "isKinematic",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromBoolean(o.isKinematic)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.isKinematic = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "freezeRotation",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromBoolean(o.freezeRotation)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.freezeRotation = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "constraints",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.constraints)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.constraints = Bridge.GetExternal<UnityEngine.RigidbodyConstraints>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "collisionDetectionMode",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.collisionDetectionMode)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.collisionDetectionMode = Bridge.GetExternal<UnityEngine.CollisionDetectionMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "centerOfMass",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.centerOfMass)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.centerOfMass = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetter(
        RigidbodyPrototype,
        "worldCenterOfMass",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.worldCenterOfMass))
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "inertiaTensorRotation",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.inertiaTensorRotation)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.inertiaTensorRotation = Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "inertiaTensor",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.inertiaTensor)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.inertiaTensor = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "detectCollisions",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromBoolean(o.detectCollisions)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.detectCollisions = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "position",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.position)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.position = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "rotation",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.rotation)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.rotation = Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "interpolation",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.interpolation)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.interpolation = Bridge.GetExternal<UnityEngine.RigidbodyInterpolation>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "solverIterations",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromInt32(o.solverIterations)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.solverIterations = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "sleepThreshold",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromDouble(o.sleepThreshold)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.sleepThreshold = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "maxAngularVelocity",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromDouble(o.maxAngularVelocity)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.maxAngularVelocity = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        RigidbodyPrototype,
        "solverVelocityIterations",
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromInt32(o.solverVelocityIterations)),
        Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => { o.solverVelocityIterations = args[1].ToInt32(); })
      );


      // Instance Methods

      RigidbodyPrototype.SetProperty(
        "SetDensity",
        Bridge.CreateFunction(
          "SetDensity",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.SetDensity((float) args[1].ToDouble()))
        )
      );


      RigidbodyPrototype.SetProperty(
        "MovePosition",
        Bridge.CreateFunction(
          "MovePosition",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.MovePosition(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      RigidbodyPrototype.SetProperty(
        "MoveRotation",
        Bridge.CreateFunction(
          "MoveRotation",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.MoveRotation(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped))
        )
      );


      RigidbodyPrototype.SetProperty(
        "Sleep",
        Bridge.CreateFunction(
          "Sleep",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.Sleep())
        )
      );


      RigidbodyPrototype.SetProperty(
        "IsSleeping",
        Bridge.CreateFunction(
          "IsSleeping",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => JavaScriptValue.FromBoolean(o.IsSleeping()))
        )
      );


      RigidbodyPrototype.SetProperty(
        "WakeUp",
        Bridge.CreateFunction(
          "WakeUp",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.WakeUp())
        )
      );


      RigidbodyPrototype.SetProperty(
        "ResetCenterOfMass",
        Bridge.CreateFunction(
          "ResetCenterOfMass",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.ResetCenterOfMass())
        )
      );


      RigidbodyPrototype.SetProperty(
        "ResetInertiaTensor",
        Bridge.CreateFunction(
          "ResetInertiaTensor",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.ResetInertiaTensor())
        )
      );


      RigidbodyPrototype.SetProperty(
        "GetRelativePointVelocity",
        Bridge.CreateFunction(
          "GetRelativePointVelocity",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.GetRelativePointVelocity(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      RigidbodyPrototype.SetProperty(
        "GetPointVelocity",
        Bridge.CreateFunction(
          "GetPointVelocity",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.GetPointVelocity(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddForce",
        Bridge.CreateFunction(
          "AddForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddForce(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.ForceMode>(args[2])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddForce",
        Bridge.CreateFunction(
          "AddForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddForce(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddForce",
        Bridge.CreateFunction(
          "AddForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddForce((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), Bridge.GetExternal<UnityEngine.ForceMode>(args[4])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddForce",
        Bridge.CreateFunction(
          "AddForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddForce((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddRelativeForce",
        Bridge.CreateFunction(
          "AddRelativeForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddRelativeForce(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.ForceMode>(args[2])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddRelativeForce",
        Bridge.CreateFunction(
          "AddRelativeForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddRelativeForce(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddRelativeForce",
        Bridge.CreateFunction(
          "AddRelativeForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddRelativeForce((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), Bridge.GetExternal<UnityEngine.ForceMode>(args[4])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddRelativeForce",
        Bridge.CreateFunction(
          "AddRelativeForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddRelativeForce((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddTorque",
        Bridge.CreateFunction(
          "AddTorque",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddTorque(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.ForceMode>(args[2])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddTorque",
        Bridge.CreateFunction(
          "AddTorque",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddTorque(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddTorque",
        Bridge.CreateFunction(
          "AddTorque",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddTorque((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), Bridge.GetExternal<UnityEngine.ForceMode>(args[4])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddTorque",
        Bridge.CreateFunction(
          "AddTorque",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddTorque((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddRelativeTorque",
        Bridge.CreateFunction(
          "AddRelativeTorque",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddRelativeTorque(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.ForceMode>(args[2])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddRelativeTorque",
        Bridge.CreateFunction(
          "AddRelativeTorque",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddRelativeTorque(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddRelativeTorque",
        Bridge.CreateFunction(
          "AddRelativeTorque",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddRelativeTorque((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), Bridge.GetExternal<UnityEngine.ForceMode>(args[4])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddRelativeTorque",
        Bridge.CreateFunction(
          "AddRelativeTorque",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddRelativeTorque((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddForceAtPosition",
        Bridge.CreateFunction(
          "AddForceAtPosition",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddForceAtPosition(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.ForceMode>(args[3])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddForceAtPosition",
        Bridge.CreateFunction(
          "AddForceAtPosition",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddForceAtPosition(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddExplosionForce",
        Bridge.CreateFunction(
          "AddExplosionForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddExplosionForce((float) args[1].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), (float) args[4].ToDouble(), Bridge.GetExternal<UnityEngine.ForceMode>(args[5])))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddExplosionForce",
        Bridge.CreateFunction(
          "AddExplosionForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddExplosionForce((float) args[1].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), (float) args[4].ToDouble()))
        )
      );


      RigidbodyPrototype.SetProperty(
        "AddExplosionForce",
        Bridge.CreateFunction(
          "AddExplosionForce",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => o.AddExplosionForce((float) args[1].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      RigidbodyPrototype.SetProperty(
        "ClosestPointOnBounds",
        Bridge.CreateFunction(
          "ClosestPointOnBounds",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.ClosestPointOnBounds(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


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


      RigidbodyPrototype.SetProperty(
        "SweepTestAll",
        Bridge.CreateFunction(
          "SweepTestAll",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.SweepTestAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[3]))))
        )
      );


      RigidbodyPrototype.SetProperty(
        "SweepTestAll",
        Bridge.CreateFunction(
          "SweepTestAll",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.SweepTestAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble())))
        )
      );


      RigidbodyPrototype.SetProperty(
        "SweepTestAll",
        Bridge.CreateFunction(
          "SweepTestAll",
          Bridge.WithExternal<UnityEngine.Rigidbody>((o, args) => Bridge.CreateExternalWithPrototype(o.SweepTestAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


    }
  }
}
