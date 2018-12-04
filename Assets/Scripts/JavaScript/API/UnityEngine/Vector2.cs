using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSVector2 {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue Vector2Prototype;
      JavaScriptValue Vector2Constructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Vector2),
        (args) => { throw new System.NotImplementedException(); },
        out Vector2Prototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Vector2", Vector2Constructor);


      // Static Fields

      Vector2Constructor.SetProperty(
        "kEpsilon",
        JavaScriptValue.FromDouble(UnityEngine.Vector2.kEpsilon)
      );


      Vector2Constructor.SetProperty(
        "kEpsilonNormalSqrt",
        JavaScriptValue.FromDouble(UnityEngine.Vector2.kEpsilonNormalSqrt)
      );


      // Static Property Accessors

      Bridge.DefineGetter(
        Vector2Constructor,
        "zero",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.zero)
      );


      Bridge.DefineGetter(
        Vector2Constructor,
        "one",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.one)
      );


      Bridge.DefineGetter(
        Vector2Constructor,
        "up",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.up)
      );


      Bridge.DefineGetter(
        Vector2Constructor,
        "down",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.down)
      );


      Bridge.DefineGetter(
        Vector2Constructor,
        "left",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.left)
      );


      Bridge.DefineGetter(
        Vector2Constructor,
        "right",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.right)
      );


      Bridge.DefineGetter(
        Vector2Constructor,
        "positiveInfinity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.positiveInfinity)
      );


      Bridge.DefineGetter(
        Vector2Constructor,
        "negativeInfinity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.negativeInfinity)
      );


      // Static Methods

      Vector2Constructor.SetProperty(
        "Lerp",
        Bridge.CreateFunction(
          "Lerp",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.Lerp(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector2Constructor.SetProperty(
        "LerpUnclamped",
        Bridge.CreateFunction(
          "LerpUnclamped",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.LerpUnclamped(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector2Constructor.SetProperty(
        "MoveTowards",
        Bridge.CreateFunction(
          "MoveTowards",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.MoveTowards(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector2Constructor.SetProperty(
        "Scale",
        Bridge.CreateFunction(
          "Scale",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.Scale(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "Reflect",
        Bridge.CreateFunction(
          "Reflect",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.Reflect(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "Perpendicular",
        Bridge.CreateFunction(
          "Perpendicular",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.Perpendicular(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "Dot",
        Bridge.CreateFunction(
          "Dot",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector2.Dot(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "Angle",
        Bridge.CreateFunction(
          "Angle",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector2.Angle(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "SignedAngle",
        Bridge.CreateFunction(
          "SignedAngle",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector2.SignedAngle(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "Distance",
        Bridge.CreateFunction(
          "Distance",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector2.Distance(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "ClampMagnitude",
        Bridge.CreateFunction(
          "ClampMagnitude",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.ClampMagnitude(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


      Vector2Constructor.SetProperty(
        "SqrMagnitude",
        Bridge.CreateFunction(
          "SqrMagnitude",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector2.SqrMagnitude(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "Min",
        Bridge.CreateFunction(
          "Min",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.Min(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      Vector2Constructor.SetProperty(
        "Max",
        Bridge.CreateFunction(
          "Max",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector2.Max(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      /*
        Vector2 SmoothDamp
        parameter currentVelocity is ref
      */


      /*
        Vector2 SmoothDamp
        parameter currentVelocity is ref
      */


      /*
        Vector2 SmoothDamp
        parameter currentVelocity is ref
      */


      // Instance Fields

      Bridge.DefineGetterSetter(
        Vector2Prototype,
        "x",
        Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => JavaScriptValue.FromDouble(o.wrapped.x)),
        Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => { o.wrapped.x = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Vector2Prototype,
        "y",
        Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => JavaScriptValue.FromDouble(o.wrapped.y)),
        Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => { o.wrapped.y = (float) args[1].ToDouble(); })
      );


      // Instance Property Accessors

      Bridge.DefineGetter(
        Vector2Prototype,
        "normalized",
        Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.normalized))
      );


      Bridge.DefineGetter(
        Vector2Prototype,
        "magnitude",
        Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => JavaScriptValue.FromDouble(o.wrapped.magnitude))
      );


      Bridge.DefineGetter(
        Vector2Prototype,
        "sqrMagnitude",
        Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => JavaScriptValue.FromDouble(o.wrapped.sqrMagnitude))
      );


      // Instance Methods

      Vector2Prototype.SetProperty(
        "Set",
        Bridge.CreateFunction(
          "Set",
          Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => o.wrapped.Set((float) args[1].ToDouble(), (float) args[2].ToDouble()))
        )
      );


      Vector2Prototype.SetProperty(
        "Scale",
        Bridge.CreateFunction(
          "Scale",
          Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => o.wrapped.Scale(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped))
        )
      );


      Vector2Prototype.SetProperty(
        "Normalize",
        Bridge.CreateFunction(
          "Normalize",
          Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => o.wrapped.Normalize())
        )
      );


      Vector2Prototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => {
            if (args.Length == 1)
              return JavaScriptValue.FromString(o.wrapped.ToString());
            else
              return JavaScriptValue.FromString(o.wrapped.ToString(args[1].ToString()));
          })
        )
      );


      Vector2Prototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => JavaScriptValue.FromInt32(o.wrapped.GetHashCode()))
        )
      );


      Vector2Prototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      Vector2Prototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped)))
        )
      );


      Vector2Prototype.SetProperty(
        "SqrMagnitude",
        Bridge.CreateFunction(
          "SqrMagnitude",
          Bridge.WithBoxedExternal<UnityEngine.Vector2>((o, args) => JavaScriptValue.FromDouble(o.wrapped.SqrMagnitude()))
        )
      );


    }
  }
}
