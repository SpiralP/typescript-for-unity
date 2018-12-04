using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSBounds {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue BoundsPrototype;
      JavaScriptValue BoundsConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Bounds),
        (args) => { throw new System.NotImplementedException(); },
        out BoundsPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Bounds", BoundsConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        BoundsPrototype,
        "center",
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.center)),
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => { o.wrapped.center = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        BoundsPrototype,
        "size",
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.size)),
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => { o.wrapped.size = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        BoundsPrototype,
        "extents",
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.extents)),
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => { o.wrapped.extents = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        BoundsPrototype,
        "min",
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.min)),
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => { o.wrapped.min = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        BoundsPrototype,
        "max",
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.max)),
        Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => { o.wrapped.max = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      // Instance Methods

      BoundsPrototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => JavaScriptValue.FromInt32(o.wrapped.GetHashCode()))
        )
      );


      BoundsPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      BoundsPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetBoxedExternal<UnityEngine.Bounds>(args[1]).wrapped)))
        )
      );


      BoundsPrototype.SetProperty(
        "SetMinMax",
        Bridge.CreateFunction(
          "SetMinMax",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => o.wrapped.SetMinMax(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      BoundsPrototype.SetProperty(
        "Encapsulate",
        Bridge.CreateFunction(
          "Encapsulate",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => o.wrapped.Encapsulate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      BoundsPrototype.SetProperty(
        "Encapsulate",
        Bridge.CreateFunction(
          "Encapsulate",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => o.wrapped.Encapsulate(Bridge.GetBoxedExternal<UnityEngine.Bounds>(args[1]).wrapped))
        )
      );


      BoundsPrototype.SetProperty(
        "Expand",
        Bridge.CreateFunction(
          "Expand",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => o.wrapped.Expand((float) args[1].ToDouble()))
        )
      );


      BoundsPrototype.SetProperty(
        "Expand",
        Bridge.CreateFunction(
          "Expand",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => o.wrapped.Expand(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      BoundsPrototype.SetProperty(
        "Intersects",
        Bridge.CreateFunction(
          "Intersects",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Intersects(Bridge.GetBoxedExternal<UnityEngine.Bounds>(args[1]).wrapped)))
        )
      );


      BoundsPrototype.SetProperty(
        "IntersectRay",
        Bridge.CreateFunction(
          "IntersectRay",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.IntersectRay(Bridge.GetBoxedExternal<UnityEngine.Ray>(args[1]).wrapped)))
        )
      );


      /*
        Bounds IntersectRay
        parameter distance is out
      */


      BoundsPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => {
            if (args.Length == 1)
              return JavaScriptValue.FromString(o.wrapped.ToString());
            else
              return JavaScriptValue.FromString(o.wrapped.ToString(args[1].ToString()));
          })
        )
      );


      BoundsPrototype.SetProperty(
        "Contains",
        Bridge.CreateFunction(
          "Contains",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Contains(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      BoundsPrototype.SetProperty(
        "SqrDistance",
        Bridge.CreateFunction(
          "SqrDistance",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => JavaScriptValue.FromDouble(o.wrapped.SqrDistance(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      BoundsPrototype.SetProperty(
        "ClosestPoint",
        Bridge.CreateFunction(
          "ClosestPoint",
          Bridge.WithBoxedExternal<UnityEngine.Bounds>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.ClosestPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


    }
  }
}
