using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSPhysics {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PhysicsPrototype;
      JavaScriptValue PhysicsConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Physics),
        (args) => { throw new System.NotImplementedException(); },
        out PhysicsPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Physics", PhysicsConstructor);


      // Static Fields

      PhysicsConstructor.SetProperty(
        "IgnoreRaycastLayer",
        JavaScriptValue.FromInt32(UnityEngine.Physics.IgnoreRaycastLayer)
      );


      PhysicsConstructor.SetProperty(
        "DefaultRaycastLayers",
        JavaScriptValue.FromInt32(UnityEngine.Physics.DefaultRaycastLayers)
      );


      PhysicsConstructor.SetProperty(
        "AllLayers",
        JavaScriptValue.FromInt32(UnityEngine.Physics.AllLayers)
      );


      // Static Property Accessors

      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "gravity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.gravity),
        (args) => { UnityEngine.Physics.gravity = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "defaultContactOffset",
        (args) => JavaScriptValue.FromDouble(UnityEngine.Physics.defaultContactOffset),
        (args) => { UnityEngine.Physics.defaultContactOffset = (float) args[1].ToDouble(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "sleepThreshold",
        (args) => JavaScriptValue.FromDouble(UnityEngine.Physics.sleepThreshold),
        (args) => { UnityEngine.Physics.sleepThreshold = (float) args[1].ToDouble(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "queriesHitTriggers",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.queriesHitTriggers),
        (args) => { UnityEngine.Physics.queriesHitTriggers = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "queriesHitBackfaces",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.queriesHitBackfaces),
        (args) => { UnityEngine.Physics.queriesHitBackfaces = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "bounceThreshold",
        (args) => JavaScriptValue.FromDouble(UnityEngine.Physics.bounceThreshold),
        (args) => { UnityEngine.Physics.bounceThreshold = (float) args[1].ToDouble(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "defaultSolverIterations",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.defaultSolverIterations),
        (args) => { UnityEngine.Physics.defaultSolverIterations = args[1].ToInt32(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "defaultSolverVelocityIterations",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.defaultSolverVelocityIterations),
        (args) => { UnityEngine.Physics.defaultSolverVelocityIterations = args[1].ToInt32(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "autoSimulation",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.autoSimulation),
        (args) => { UnityEngine.Physics.autoSimulation = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "autoSyncTransforms",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.autoSyncTransforms),
        (args) => { UnityEngine.Physics.autoSyncTransforms = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "interCollisionDistance",
        (args) => JavaScriptValue.FromDouble(UnityEngine.Physics.interCollisionDistance),
        (args) => { UnityEngine.Physics.interCollisionDistance = (float) args[1].ToDouble(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "interCollisionStiffness",
        (args) => JavaScriptValue.FromDouble(UnityEngine.Physics.interCollisionStiffness),
        (args) => { UnityEngine.Physics.interCollisionStiffness = (float) args[1].ToDouble(); }
      );


      Bridge.DefineGetterSetter(
        PhysicsConstructor,
        "interCollisionSettingsToggle",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.interCollisionSettingsToggle),
        (args) => { UnityEngine.Physics.interCollisionSettingsToggle = args[1].ToBoolean(); }
      );


      // Static Methods

      PhysicsConstructor.SetProperty(
        "IgnoreCollision",
        Bridge.CreateFunction(
          "IgnoreCollision",
          (args) => UnityEngine.Physics.IgnoreCollision(Bridge.GetExternal<UnityEngine.Collider>(args[1]), Bridge.GetExternal<UnityEngine.Collider>(args[2]), args[3].ToBoolean())
        )
      );


      PhysicsConstructor.SetProperty(
        "IgnoreCollision",
        Bridge.CreateFunction(
          "IgnoreCollision",
          (args) => UnityEngine.Physics.IgnoreCollision(Bridge.GetExternal<UnityEngine.Collider>(args[1]), Bridge.GetExternal<UnityEngine.Collider>(args[2]))
        )
      );


      PhysicsConstructor.SetProperty(
        "IgnoreLayerCollision",
        Bridge.CreateFunction(
          "IgnoreLayerCollision",
          (args) => UnityEngine.Physics.IgnoreLayerCollision(args[1].ToInt32(), args[2].ToInt32(), args[3].ToBoolean())
        )
      );


      PhysicsConstructor.SetProperty(
        "IgnoreLayerCollision",
        Bridge.CreateFunction(
          "IgnoreLayerCollision",
          (args) => UnityEngine.Physics.IgnoreLayerCollision(args[1].ToInt32(), args[2].ToInt32())
        )
      );


      PhysicsConstructor.SetProperty(
        "GetIgnoreLayerCollision",
        Bridge.CreateFunction(
          "GetIgnoreLayerCollision",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.GetIgnoreLayerCollision(args[1].ToInt32(), args[2].ToInt32()))
        )
      );


      // PhysicsConstructor.SetProperty(
      //   "Raycast",
      //   Bridge.CreateFunction(
      //     "Raycast",
      //     (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Raycast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
      //   )
      // );


      // PhysicsConstructor.SetProperty(
      //   "Raycast",
      //   Bridge.CreateFunction(
      //     "Raycast",
      //     (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Raycast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), args[4].ToInt32()))
      //   )
      // );


      // PhysicsConstructor.SetProperty(
      //   "Raycast",
      //   Bridge.CreateFunction(
      //     "Raycast",
      //     (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Raycast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
      //   )
      // );


      // PhysicsConstructor.SetProperty(
      //   "Raycast",
      //   Bridge.CreateFunction(
      //     "Raycast",
      //     (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Raycast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
      //   )
      // );


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


      // PhysicsConstructor.SetProperty(
      //   "Raycast",
      //   Bridge.CreateFunction(
      //     "Raycast",
      //     (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Raycast(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), args[3].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[4])))
      //   )
      // );


      // PhysicsConstructor.SetProperty(
      //   "Raycast",
      //   Bridge.CreateFunction(
      //     "Raycast",
      //     (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Raycast(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), args[3].ToInt32()))
      //   )
      // );


      // PhysicsConstructor.SetProperty(
      //   "Raycast",
      //   Bridge.CreateFunction(
      //     "Raycast",
      //     (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Raycast(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble()))
      //   )
      // );


      // PhysicsConstructor.SetProperty(
      //   "Raycast",
      //   Bridge.CreateFunction(
      //     "Raycast",
      //     (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Raycast(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped))
      //   )
      // );


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


      // TODO
      PhysicsConstructor.SetProperty("Raycast", Bridge.CreateFunction((args) => { // origin, direction
        UnityEngine.Ray r;
        if (args.Length == 2) {
          r = Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped; // Ray type
        } else {
          r = new UnityEngine.Ray(
            Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped,
            Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped
          );
        }

        // Debug.DrawRay(r.origin, r.direction * 100f, Color.red, 10f);

        UnityEngine.RaycastHit hitInfo;
        bool hit = UnityEngine.Physics.Raycast(r, out hitInfo);

        JavaScriptValue returnObject = JavaScriptValue.CreateObject();
        returnObject.SetProperty("hit", JavaScriptValue.FromBoolean(hit));
        returnObject.SetProperty("hitInfo", Bridge.CreateExternalWithPrototype(hitInfo));

        return returnObject;
      }));


      PhysicsConstructor.SetProperty(
        "Linecast",
        Bridge.CreateFunction(
          "Linecast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Linecast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, args[3].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[4])))
        )
      );


      PhysicsConstructor.SetProperty(
        "Linecast",
        Bridge.CreateFunction(
          "Linecast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Linecast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, args[3].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "Linecast",
        Bridge.CreateFunction(
          "Linecast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.Linecast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


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


      PhysicsConstructor.SetProperty(
        "CapsuleCast",
        Bridge.CreateFunction(
          "CapsuleCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CapsuleCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, (float) args[5].ToDouble(), args[6].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[7])))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCast",
        Bridge.CreateFunction(
          "CapsuleCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CapsuleCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, (float) args[5].ToDouble(), args[6].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCast",
        Bridge.CreateFunction(
          "CapsuleCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CapsuleCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, (float) args[5].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCast",
        Bridge.CreateFunction(
          "CapsuleCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CapsuleCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped))
        )
      );


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


      PhysicsConstructor.SetProperty(
        "SphereCast",
        Bridge.CreateFunction(
          "SphereCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.SphereCast(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCast",
        Bridge.CreateFunction(
          "SphereCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.SphereCast(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), args[4].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCast",
        Bridge.CreateFunction(
          "SphereCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.SphereCast(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCast",
        Bridge.CreateFunction(
          "SphereCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.SphereCast(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


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


      PhysicsConstructor.SetProperty(
        "BoxCast",
        Bridge.CreateFunction(
          "BoxCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.BoxCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped, (float) args[5].ToDouble(), args[6].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[7])))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCast",
        Bridge.CreateFunction(
          "BoxCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.BoxCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped, (float) args[5].ToDouble(), args[6].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCast",
        Bridge.CreateFunction(
          "BoxCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.BoxCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped, (float) args[5].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCast",
        Bridge.CreateFunction(
          "BoxCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.BoxCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCast",
        Bridge.CreateFunction(
          "BoxCast",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.BoxCast(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped))
        )
      );


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


      PhysicsConstructor.SetProperty(
        "RaycastAll",
        Bridge.CreateFunction(
          "RaycastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.RaycastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastAll",
        Bridge.CreateFunction(
          "RaycastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.RaycastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), args[4].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastAll",
        Bridge.CreateFunction(
          "RaycastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.RaycastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastAll",
        Bridge.CreateFunction(
          "RaycastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.RaycastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastAll",
        Bridge.CreateFunction(
          "RaycastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.RaycastAll(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), args[3].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[4])))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastAll",
        Bridge.CreateFunction(
          "RaycastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.RaycastAll(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), args[3].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastAll",
        Bridge.CreateFunction(
          "RaycastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.RaycastAll(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastAll",
        Bridge.CreateFunction(
          "RaycastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.RaycastAll(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCastAll",
        Bridge.CreateFunction(
          "CapsuleCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.CapsuleCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, (float) args[5].ToDouble(), args[6].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[7])))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCastAll",
        Bridge.CreateFunction(
          "CapsuleCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.CapsuleCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, (float) args[5].ToDouble(), args[6].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCastAll",
        Bridge.CreateFunction(
          "CapsuleCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.CapsuleCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, (float) args[5].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCastAll",
        Bridge.CreateFunction(
          "CapsuleCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.CapsuleCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastAll",
        Bridge.CreateFunction(
          "SphereCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.SphereCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, (float) args[4].ToDouble(), args[5].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[6])))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastAll",
        Bridge.CreateFunction(
          "SphereCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.SphereCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, (float) args[4].ToDouble(), args[5].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastAll",
        Bridge.CreateFunction(
          "SphereCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.SphereCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, (float) args[4].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastAll",
        Bridge.CreateFunction(
          "SphereCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.SphereCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastAll",
        Bridge.CreateFunction(
          "SphereCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.SphereCastAll(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastAll",
        Bridge.CreateFunction(
          "SphereCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.SphereCastAll(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), args[4].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastAll",
        Bridge.CreateFunction(
          "SphereCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.SphereCastAll(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastAll",
        Bridge.CreateFunction(
          "SphereCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.SphereCastAll(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapCapsule",
        Bridge.CreateFunction(
          "OverlapCapsule",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapCapsule(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapCapsule",
        Bridge.CreateFunction(
          "OverlapCapsule",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapCapsule(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), args[4].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapCapsule",
        Bridge.CreateFunction(
          "OverlapCapsule",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapCapsule(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapSphere",
        Bridge.CreateFunction(
          "OverlapSphere",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapSphere(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), args[3].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[4])))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapSphere",
        Bridge.CreateFunction(
          "OverlapSphere",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapSphere(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), args[3].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapSphere",
        Bridge.CreateFunction(
          "OverlapSphere",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapSphere(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "Simulate",
        Bridge.CreateFunction(
          "Simulate",
          (args) => UnityEngine.Physics.Simulate((float) args[1].ToDouble())
        )
      );


      PhysicsConstructor.SetProperty(
        "SyncTransforms",
        Bridge.CreateFunction(
          "SyncTransforms",
          (args) => UnityEngine.Physics.SyncTransforms()
        )
      );


      /*
        Physics ComputePenetration
        parameter direction is out
      */


      PhysicsConstructor.SetProperty(
        "ClosestPoint",
        Bridge.CreateFunction(
          "ClosestPoint",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.ClosestPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Collider>(args[2]), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastNonAlloc",
        Bridge.CreateFunction(
          "RaycastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.RaycastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[2]), (float) args[3].ToDouble(), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastNonAlloc",
        Bridge.CreateFunction(
          "RaycastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.RaycastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[2]), (float) args[3].ToDouble(), args[4].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastNonAlloc",
        Bridge.CreateFunction(
          "RaycastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.RaycastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[2]), (float) args[3].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastNonAlloc",
        Bridge.CreateFunction(
          "RaycastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.RaycastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[2])))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastNonAlloc",
        Bridge.CreateFunction(
          "RaycastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.RaycastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[3]), (float) args[4].ToDouble(), args[5].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[6])))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastNonAlloc",
        Bridge.CreateFunction(
          "RaycastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.RaycastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[3]), (float) args[4].ToDouble(), args[5].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastNonAlloc",
        Bridge.CreateFunction(
          "RaycastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.RaycastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[3]), (float) args[4].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "RaycastNonAlloc",
        Bridge.CreateFunction(
          "RaycastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.RaycastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[3])))
        )
      );


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


      PhysicsConstructor.SetProperty(
        "CheckSphere",
        Bridge.CreateFunction(
          "CheckSphere",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckSphere(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), args[3].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[4])))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckSphere",
        Bridge.CreateFunction(
          "CheckSphere",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckSphere(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), args[3].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckSphere",
        Bridge.CreateFunction(
          "CheckSphere",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckSphere(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCastNonAlloc",
        Bridge.CreateFunction(
          "CapsuleCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.CapsuleCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[5]), (float) args[6].ToDouble(), args[7].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[8])))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCastNonAlloc",
        Bridge.CreateFunction(
          "CapsuleCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.CapsuleCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[5]), (float) args[6].ToDouble(), args[7].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCastNonAlloc",
        Bridge.CreateFunction(
          "CapsuleCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.CapsuleCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[5]), (float) args[6].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CapsuleCastNonAlloc",
        Bridge.CreateFunction(
          "CapsuleCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.CapsuleCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[4]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastNonAlloc",
        Bridge.CreateFunction(
          "SphereCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.SphereCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4]), (float) args[5].ToDouble(), args[6].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[7])))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastNonAlloc",
        Bridge.CreateFunction(
          "SphereCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.SphereCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4]), (float) args[5].ToDouble(), args[6].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastNonAlloc",
        Bridge.CreateFunction(
          "SphereCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.SphereCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4]), (float) args[5].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastNonAlloc",
        Bridge.CreateFunction(
          "SphereCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.SphereCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4])))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastNonAlloc",
        Bridge.CreateFunction(
          "SphereCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.SphereCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[3]), (float) args[4].ToDouble(), args[5].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[6])))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastNonAlloc",
        Bridge.CreateFunction(
          "SphereCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.SphereCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[3]), (float) args[4].ToDouble(), args[5].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastNonAlloc",
        Bridge.CreateFunction(
          "SphereCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.SphereCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[3]), (float) args[4].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "SphereCastNonAlloc",
        Bridge.CreateFunction(
          "SphereCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.SphereCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[3])))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckCapsule",
        Bridge.CreateFunction(
          "CheckCapsule",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckCapsule(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckCapsule",
        Bridge.CreateFunction(
          "CheckCapsule",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckCapsule(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), args[4].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckCapsule",
        Bridge.CreateFunction(
          "CheckCapsule",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckCapsule(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckBox",
        Bridge.CreateFunction(
          "CheckBox",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckBox(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[3]).wrapped, args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckBox",
        Bridge.CreateFunction(
          "CheckBox",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckBox(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[3]).wrapped, args[4].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckBox",
        Bridge.CreateFunction(
          "CheckBox",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckBox(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[3]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "CheckBox",
        Bridge.CreateFunction(
          "CheckBox",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Physics.CheckBox(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapBox",
        Bridge.CreateFunction(
          "OverlapBox",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapBox(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[3]).wrapped, args[4].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[5])))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapBox",
        Bridge.CreateFunction(
          "OverlapBox",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapBox(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[3]).wrapped, args[4].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapBox",
        Bridge.CreateFunction(
          "OverlapBox",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapBox(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[3]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "OverlapBox",
        Bridge.CreateFunction(
          "OverlapBox",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.OverlapBox(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


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


      PhysicsConstructor.SetProperty(
        "BoxCastNonAlloc",
        Bridge.CreateFunction(
          "BoxCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.BoxCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4]), Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[5]).wrapped, (float) args[6].ToDouble(), args[7].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[8])))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastNonAlloc",
        Bridge.CreateFunction(
          "BoxCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.BoxCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4]), Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[5]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastNonAlloc",
        Bridge.CreateFunction(
          "BoxCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.BoxCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4]), Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[5]).wrapped, (float) args[6].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastNonAlloc",
        Bridge.CreateFunction(
          "BoxCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.BoxCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4]), Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[5]).wrapped, (float) args[6].ToDouble(), args[7].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastNonAlloc",
        Bridge.CreateFunction(
          "BoxCastNonAlloc",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Physics.BoxCastNonAlloc(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.RaycastHit[]>(args[4])))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastAll",
        Bridge.CreateFunction(
          "BoxCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.BoxCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped, (float) args[5].ToDouble(), args[6].ToInt32(), Bridge.GetExternal<UnityEngine.QueryTriggerInteraction>(args[7])))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastAll",
        Bridge.CreateFunction(
          "BoxCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.BoxCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped, (float) args[5].ToDouble(), args[6].ToInt32()))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastAll",
        Bridge.CreateFunction(
          "BoxCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.BoxCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped, (float) args[5].ToDouble()))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastAll",
        Bridge.CreateFunction(
          "BoxCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.BoxCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[4]).wrapped))
        )
      );


      PhysicsConstructor.SetProperty(
        "BoxCastAll",
        Bridge.CreateFunction(
          "BoxCastAll",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Physics.BoxCastAll(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped))
        )
      );


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


      PhysicsConstructor.SetProperty(
        "RebuildBroadphaseRegions",
        Bridge.CreateFunction(
          "RebuildBroadphaseRegions",
          (args) => UnityEngine.Physics.RebuildBroadphaseRegions(Bridge.GetBoxedExternal<UnityEngine.Bounds>(args[1]).wrapped, args[2].ToInt32())
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
