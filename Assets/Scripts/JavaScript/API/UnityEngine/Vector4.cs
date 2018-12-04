using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSVector4 {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue Vector4Prototype;
      JavaScriptValue Vector4Constructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Vector4),
        (args) => { throw new System.NotImplementedException(); },
        out Vector4Prototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Vector4", Vector4Constructor);


      // Static Fields

      Vector4Constructor.SetProperty(
        "kEpsilon",
        JavaScriptValue.FromDouble(UnityEngine.Vector4.kEpsilon)
      );


      // Static Property Accessors

      Bridge.DefineGetter(
        Vector4Constructor,
        "zero",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.zero)
      );


      Bridge.DefineGetter(
        Vector4Constructor,
        "one",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.one)
      );


      Bridge.DefineGetter(
        Vector4Constructor,
        "positiveInfinity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.positiveInfinity)
      );


      Bridge.DefineGetter(
        Vector4Constructor,
        "negativeInfinity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.negativeInfinity)
      );


      // Static Methods

      Vector4Constructor.SetProperty(
        "Lerp",
        Bridge.CreateFunction(
          "Lerp",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.Lerp(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector4Constructor.SetProperty(
        "LerpUnclamped",
        Bridge.CreateFunction(
          "LerpUnclamped",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.LerpUnclamped(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector4Constructor.SetProperty(
        "MoveTowards",
        Bridge.CreateFunction(
          "MoveTowards",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.MoveTowards(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Vector4Constructor.SetProperty(
        "Scale",
        Bridge.CreateFunction(
          "Scale",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.Scale(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      Vector4Constructor.SetProperty(
        "Normalize",
        Bridge.CreateFunction(
          "Normalize",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.Normalize(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped))
        )
      );


      Vector4Constructor.SetProperty(
        "Dot",
        Bridge.CreateFunction(
          "Dot",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector4.Dot(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      Vector4Constructor.SetProperty(
        "Project",
        Bridge.CreateFunction(
          "Project",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.Project(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      Vector4Constructor.SetProperty(
        "Distance",
        Bridge.CreateFunction(
          "Distance",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector4.Distance(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      Vector4Constructor.SetProperty(
        "Magnitude",
        Bridge.CreateFunction(
          "Magnitude",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector4.Magnitude(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped))
        )
      );


      Vector4Constructor.SetProperty(
        "Min",
        Bridge.CreateFunction(
          "Min",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.Min(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      Vector4Constructor.SetProperty(
        "Max",
        Bridge.CreateFunction(
          "Max",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Vector4.Max(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      Vector4Constructor.SetProperty(
        "SqrMagnitude",
        Bridge.CreateFunction(
          "SqrMagnitude",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Vector4.SqrMagnitude(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped))
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        Vector4Prototype,
        "x",
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.x)),
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => { o.wrapped.x = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Vector4Prototype,
        "y",
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.y)),
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => { o.wrapped.y = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Vector4Prototype,
        "z",
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.z)),
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => { o.wrapped.z = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Vector4Prototype,
        "w",
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.w)),
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => { o.wrapped.w = (float) args[1].ToDouble(); })
      );


      // Instance Property Accessors

      Bridge.DefineGetter(
        Vector4Prototype,
        "normalized",
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.normalized))
      );


      Bridge.DefineGetter(
        Vector4Prototype,
        "magnitude",
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.magnitude))
      );


      Bridge.DefineGetter(
        Vector4Prototype,
        "sqrMagnitude",
        Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.sqrMagnitude))
      );


      // Instance Methods

      Vector4Prototype.SetProperty(
        "Set",
        Bridge.CreateFunction(
          "Set",
          Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => o.wrapped.Set((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble()))
        )
      );


      Vector4Prototype.SetProperty(
        "Scale",
        Bridge.CreateFunction(
          "Scale",
          Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => o.wrapped.Scale(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped))
        )
      );


      Vector4Prototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromInt32(o.wrapped.GetHashCode()))
        )
      );


      Vector4Prototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      Vector4Prototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped)))
        )
      );


      Vector4Prototype.SetProperty(
        "Normalize",
        Bridge.CreateFunction(
          "Normalize",
          Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => o.wrapped.Normalize())
        )
      );


      Vector4Prototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => {
            if (args.Length == 1)
              return JavaScriptValue.FromString(o.wrapped.ToString());
            else
              return JavaScriptValue.FromString(o.wrapped.ToString(args[1].ToString()));
          })
        )
      );


      Vector4Prototype.SetProperty(
        "SqrMagnitude",
        Bridge.CreateFunction(
          "SqrMagnitude",
          Bridge.WithBoxedExternal<UnityEngine.Vector4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.SqrMagnitude()))
        )
      );


    }
  }
}
