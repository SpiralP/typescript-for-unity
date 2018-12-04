using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSRaycastHit {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RaycastHitPrototype;
      JavaScriptValue RaycastHitConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.RaycastHit),
        (args) => { throw new System.NotImplementedException(); },
        out RaycastHitPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("RaycastHit", RaycastHitConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        RaycastHitPrototype,
        "collider",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.collider))
      );


      Bridge.DefineGetterSetter(
        RaycastHitPrototype,
        "point",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.point)),
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => { o.wrapped.point = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RaycastHitPrototype,
        "normal",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.normal)),
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => { o.wrapped.normal = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RaycastHitPrototype,
        "barycentricCoordinate",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.barycentricCoordinate)),
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => { o.wrapped.barycentricCoordinate = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RaycastHitPrototype,
        "distance",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => JavaScriptValue.FromDouble(o.wrapped.distance)),
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => { o.wrapped.distance = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetter(
        RaycastHitPrototype,
        "triangleIndex",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => JavaScriptValue.FromInt32(o.wrapped.triangleIndex))
      );


      Bridge.DefineGetter(
        RaycastHitPrototype,
        "textureCoord",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.textureCoord))
      );


      Bridge.DefineGetter(
        RaycastHitPrototype,
        "textureCoord2",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.textureCoord2))
      );


      Bridge.DefineGetter(
        RaycastHitPrototype,
        "transform",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.transform))
      );


      Bridge.DefineGetter(
        RaycastHitPrototype,
        "rigidbody",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.rigidbody))
      );


      Bridge.DefineGetter(
        RaycastHitPrototype,
        "lightmapCoord",
        Bridge.WithBoxedExternal<UnityEngine.RaycastHit>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.lightmapCoord))
      );


      // Instance Methods

    }
  }
}
