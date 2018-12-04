using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSPlane {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PlanePrototype;
      JavaScriptValue PlaneConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Plane),
        (args) => { throw new System.NotImplementedException(); },
        out PlanePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Plane", PlaneConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      PlaneConstructor.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Plane.Translate(Bridge.GetBoxedExternal<UnityEngine.Plane>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        PlanePrototype,
        "normal",
        Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.normal)),
        Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => { o.wrapped.normal = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        PlanePrototype,
        "distance",
        Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => JavaScriptValue.FromDouble(o.wrapped.distance)),
        Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => { o.wrapped.distance = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetter(
        PlanePrototype,
        "flipped",
        Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.flipped))
      );


      // Instance Methods

      PlanePrototype.SetProperty(
        "SetNormalAndPosition",
        Bridge.CreateFunction(
          "SetNormalAndPosition",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => o.wrapped.SetNormalAndPosition(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      PlanePrototype.SetProperty(
        "Set3Points",
        Bridge.CreateFunction(
          "Set3Points",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => o.wrapped.Set3Points(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped))
        )
      );


      PlanePrototype.SetProperty(
        "Flip",
        Bridge.CreateFunction(
          "Flip",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => o.wrapped.Flip())
        )
      );


      PlanePrototype.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => o.wrapped.Translate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      PlanePrototype.SetProperty(
        "ClosestPointOnPlane",
        Bridge.CreateFunction(
          "ClosestPointOnPlane",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.ClosestPointOnPlane(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      PlanePrototype.SetProperty(
        "GetDistanceToPoint",
        Bridge.CreateFunction(
          "GetDistanceToPoint",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => JavaScriptValue.FromDouble(o.wrapped.GetDistanceToPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      PlanePrototype.SetProperty(
        "GetSide",
        Bridge.CreateFunction(
          "GetSide",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.GetSide(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      PlanePrototype.SetProperty(
        "SameSide",
        Bridge.CreateFunction(
          "SameSide",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.SameSide(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped)))
        )
      );


      /*
        Plane Raycast
        parameter enter is out
      */


      PlanePrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Plane>((o, args) => {
            if (args.Length == 1)
              return JavaScriptValue.FromString(o.wrapped.ToString());
            else
              return JavaScriptValue.FromString(o.wrapped.ToString(args[1].ToString()));
          })
        )
      );


    }
  }
}
