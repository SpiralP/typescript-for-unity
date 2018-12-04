using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCollider {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ColliderPrototype;
      JavaScriptValue ColliderConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Collider),
        (args) => { throw new System.NotImplementedException(); },
        out ColliderPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Collider", ColliderConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        ColliderPrototype,
        "enabled",
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => JavaScriptValue.FromBoolean(o.enabled)),
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => { o.enabled = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        ColliderPrototype,
        "attachedRigidbody",
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => Bridge.CreateExternalWithPrototype(o.attachedRigidbody))
      );


      Bridge.DefineGetterSetter(
        ColliderPrototype,
        "isTrigger",
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => JavaScriptValue.FromBoolean(o.isTrigger)),
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => { o.isTrigger = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        ColliderPrototype,
        "contactOffset",
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => JavaScriptValue.FromDouble(o.contactOffset)),
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => { o.contactOffset = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetter(
        ColliderPrototype,
        "bounds",
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => Bridge.CreateExternalWithPrototype(o.bounds))
      );


      Bridge.DefineGetterSetter(
        ColliderPrototype,
        "sharedMaterial",
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => Bridge.CreateExternalWithPrototype(o.sharedMaterial)),
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => { o.sharedMaterial = Bridge.GetExternal<UnityEngine.PhysicMaterial>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        ColliderPrototype,
        "material",
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => Bridge.CreateExternalWithPrototype(o.material)),
        Bridge.WithExternal<UnityEngine.Collider>((o, args) => { o.material = Bridge.GetExternal<UnityEngine.PhysicMaterial>(args[1]); })
      );


      // Instance Methods

      ColliderPrototype.SetProperty(
        "ClosestPoint",
        Bridge.CreateFunction(
          "ClosestPoint",
          Bridge.WithExternal<UnityEngine.Collider>((o, args) => Bridge.CreateExternalWithPrototype(o.ClosestPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      /*
        Collider Raycast
        parameter hitInfo is out
      */


      ColliderPrototype.SetProperty(
        "ClosestPointOnBounds",
        Bridge.CreateFunction(
          "ClosestPointOnBounds",
          Bridge.WithExternal<UnityEngine.Collider>((o, args) => Bridge.CreateExternalWithPrototype(o.ClosestPointOnBounds(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


    }
  }
}
