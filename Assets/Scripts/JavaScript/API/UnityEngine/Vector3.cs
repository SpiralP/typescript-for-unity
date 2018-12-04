using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSVector3 {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue Vector3Prototype;
      JavaScriptValue Vector3Constructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Vector3),
        (args) => {
          if (args.Length == 1)
            return Bridge.CreateExternalWithPrototype(new UnityEngine.Vector3());

          return Bridge.CreateExternalWithPrototype(
            new UnityEngine.Vector3(
              (float) args[1].ToDouble(),
              (float) args[2].ToDouble(),
              (float) args[3].ToDouble()
            )
          );
        },
        out Vector3Prototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Vector3", Vector3Constructor);


      // Static Fields

      Vector3Constructor.SetProperty(
        "kEpsilon",
        JavaScriptValue.FromDouble(UnityEngine.Vector3.kEpsilon)
      );


      Vector3Constructor.SetProperty(
        "kEpsilonNormalSqrt",
        JavaScriptValue.FromDouble(UnityEngine.Vector3.kEpsilonNormalSqrt)
      );


      // Static Property Accessors

      Bridge.DefineGetter(
        Vector3Constructor,
        "zero",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.zero)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "one",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.one)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "forward",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.forward)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "back",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.back)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "up",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.up)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "down",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.down)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "left",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.left)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "right",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.right)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "positiveInfinity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.positiveInfinity)
      );


      Bridge.DefineGetter(
        Vector3Constructor,
        "negativeInfinity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.negativeInfinity)
      );


      // Static Methods

      Vector3Constructor.SetProperty(
        "Slerp",
        Bridge.CreateFunction(
          "Slerp",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Slerp(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector3Constructor.SetProperty(
        "SlerpUnclamped",
        Bridge.CreateFunction(
          "SlerpUnclamped",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.SlerpUnclamped(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      /*
        Vector3 OrthoNormalize
        parameter normal is ref
      */


      /*
        Vector3 OrthoNormalize
        parameter normal is ref
      */


      Vector3Constructor.SetProperty(
        "RotateTowards",
        Bridge.CreateFunction(
          "RotateTowards",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.RotateTowards(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble(), (float) args[4].ToDouble()))
        )
      );


      Vector3Constructor.SetProperty(
        "Lerp",
        Bridge.CreateFunction(
          "Lerp",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Lerp(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector3Constructor.SetProperty(
        "LerpUnclamped",
        Bridge.CreateFunction(
          "LerpUnclamped",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.LerpUnclamped(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector3Constructor.SetProperty(
        "MoveTowards",
        Bridge.CreateFunction(
          "MoveTowards",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.MoveTowards(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      /*
        Vector3 SmoothDamp
        parameter currentVelocity is ref
      */


      /*
        Vector3 SmoothDamp
        parameter currentVelocity is ref
      */


      /*
        Vector3 SmoothDamp
        parameter currentVelocity is ref
      */


      Vector3Constructor.SetProperty(
        "Scale",
        Bridge.CreateFunction(
          "Scale",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Scale(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Cross",
        Bridge.CreateFunction(
          "Cross",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Cross(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Reflect",
        Bridge.CreateFunction(
          "Reflect",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Reflect(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Normalize",
        Bridge.CreateFunction(
          "Normalize",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Normalize(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Dot",
        Bridge.CreateFunction(
          "Dot",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector3.Dot(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Project",
        Bridge.CreateFunction(
          "Project",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Project(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "ProjectOnPlane",
        Bridge.CreateFunction(
          "ProjectOnPlane",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.ProjectOnPlane(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Angle",
        Bridge.CreateFunction(
          "Angle",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector3.Angle(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "SignedAngle",
        Bridge.CreateFunction(
          "SignedAngle",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector3.SignedAngle(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Distance",
        Bridge.CreateFunction(
          "Distance",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector3.Distance(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "ClampMagnitude",
        Bridge.CreateFunction(
          "ClampMagnitude",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.ClampMagnitude(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


      Vector3Constructor.SetProperty(
        "Magnitude",
        Bridge.CreateFunction(
          "Magnitude",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector3.Magnitude(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "SqrMagnitude",
        Bridge.CreateFunction(
          "SqrMagnitude",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector3.SqrMagnitude(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Min",
        Bridge.CreateFunction(
          "Min",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Min(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      Vector3Constructor.SetProperty(
        "Max",
        Bridge.CreateFunction(
          "Max",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector3.Max(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        Vector3Prototype,
        "x",
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => JavaScriptValue.FromDouble(o.wrapped.x)),
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => { o.wrapped.x = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Vector3Prototype,
        "y",
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => JavaScriptValue.FromDouble(o.wrapped.y)),
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => { o.wrapped.y = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Vector3Prototype,
        "z",
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => JavaScriptValue.FromDouble(o.wrapped.z)),
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => { o.wrapped.z = (float) args[1].ToDouble(); })
      );


      // Instance Property Accessors

      Bridge.DefineGetter(
        Vector3Prototype,
        "normalized",
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.normalized))
      );


      Bridge.DefineGetter(
        Vector3Prototype,
        "magnitude",
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => JavaScriptValue.FromDouble(o.wrapped.magnitude))
      );


      Bridge.DefineGetter(
        Vector3Prototype,
        "sqrMagnitude",
        Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => JavaScriptValue.FromDouble(o.wrapped.sqrMagnitude))
      );


      // Instance Methods

      Vector3Prototype.SetProperty(
        "Set",
        Bridge.CreateFunction(
          "Set",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => o.wrapped.Set((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      Vector3Prototype.SetProperty(
        "Scale",
        Bridge.CreateFunction(
          "Scale",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => o.wrapped.Scale(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      Vector3Prototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => JavaScriptValue.FromInt32(o.wrapped.GetHashCode()))
        )
      );


      Vector3Prototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      Vector3Prototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      Vector3Prototype.SetProperty(
        "Normalize",
        Bridge.CreateFunction(
          "Normalize",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => o.wrapped.Normalize())
        )
      );


      Vector3Prototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => {
            if (args.Length == 1)
              return JavaScriptValue.FromString(o.wrapped.ToString());
            else
              return JavaScriptValue.FromString(o.wrapped.ToString(args[1].ToString()));
          })
        )
      );


      Vector3Prototype.SetProperty(
        "add",
        Bridge.CreateFunction(
          "add",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => {
            return Bridge.CreateExternalWithPrototype(o.wrapped + Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped);
          })
        )
      );

      Vector3Prototype.SetProperty(
        "neg",
        Bridge.CreateFunction(
          "neg",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => {
            return Bridge.CreateExternalWithPrototype(-o.wrapped);
          })
        )
      );

      Vector3Prototype.SetProperty(
        "sub",
        Bridge.CreateFunction(
          "sub",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => {
            return Bridge.CreateExternalWithPrototype(o.wrapped - Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped);
          })
        )
      );

      Vector3Prototype.SetProperty(
        "mul",
        Bridge.CreateFunction(
          "mul",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => {
            return Bridge.CreateExternalWithPrototype(o.wrapped * (float) args[1].ToDouble());
          })
        )
      );

      Vector3Prototype.SetProperty(
        "div",
        Bridge.CreateFunction(
          "div",
          Bridge.WithBoxedExternal<UnityEngine.Vector3>((o, args) => {
            return Bridge.CreateExternalWithPrototype(o.wrapped / (float) args[1].ToDouble());
          })
        )
      );


    }
  }
}
