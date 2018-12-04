using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSQuaternion {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue QuaternionPrototype;
      JavaScriptValue QuaternionConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Quaternion),
        (args) => {
          if (args.Length == 1)
            return Bridge.CreateExternalWithPrototype(new UnityEngine.Quaternion());

          return Bridge.CreateExternalWithPrototype(new UnityEngine.Quaternion(
            (float) args[1].ToDouble(),
            (float) args[2].ToDouble(),
            (float) args[3].ToDouble(),
            (float) args[4].ToDouble()
          ));
        },
        out QuaternionPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Quaternion", QuaternionConstructor);


      // Static Fields

      QuaternionConstructor.SetProperty(
        "kEpsilon",
        JavaScriptValue.FromDouble(UnityEngine.Quaternion.kEpsilon)
      );


      // Static Property Accessors

      Bridge.DefineGetter(
        QuaternionConstructor,
        "identity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.identity)
      );


      // Static Methods

      QuaternionConstructor.SetProperty(
        "FromToRotation",
        Bridge.CreateFunction(
          "FromToRotation",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.FromToRotation(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      QuaternionConstructor.SetProperty(
        "Inverse",
        Bridge.CreateFunction(
          "Inverse",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.Inverse(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped))
        )
      );


      QuaternionConstructor.SetProperty(
        "Slerp",
        Bridge.CreateFunction(
          "Slerp",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.Slerp(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      QuaternionConstructor.SetProperty(
        "SlerpUnclamped",
        Bridge.CreateFunction(
          "SlerpUnclamped",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.SlerpUnclamped(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      QuaternionConstructor.SetProperty(
        "Lerp",
        Bridge.CreateFunction(
          "Lerp",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.Lerp(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      QuaternionConstructor.SetProperty(
        "LerpUnclamped",
        Bridge.CreateFunction(
          "LerpUnclamped",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.LerpUnclamped(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      QuaternionConstructor.SetProperty(
        "AngleAxis",
        Bridge.CreateFunction(
          "AngleAxis",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.AngleAxis((float) args[1].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      QuaternionConstructor.SetProperty(
        "LookRotation",
        Bridge.CreateFunction(
          "LookRotation",
          (args) => {
            if (args.Length == 2)
              return Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.LookRotation(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped));
            else
              return Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.LookRotation(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped));
          }
        )
      );


      QuaternionConstructor.SetProperty(
        "Dot",
        Bridge.CreateFunction(
          "Dot",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Quaternion.Dot(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped))
        )
      );


      QuaternionConstructor.SetProperty(
        "Angle",
        Bridge.CreateFunction(
          "Angle",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Quaternion.Angle(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped))
        )
      );


      QuaternionConstructor.SetProperty(
        "Euler",
        Bridge.CreateFunction(
          "Euler",
          (args) => {
            if (args.Length == 2)
              return Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.Euler(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped));
            else
              return Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.Euler((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()));
          }
        )
      );


      QuaternionConstructor.SetProperty(
        "RotateTowards",
        Bridge.CreateFunction(
          "RotateTowards",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.RotateTowards(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      QuaternionConstructor.SetProperty(
        "Normalize",
        Bridge.CreateFunction(
          "Normalize",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Quaternion.Normalize(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped))
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        QuaternionPrototype,
        "x",
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => JavaScriptValue.FromDouble(o.wrapped.x)),
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => { o.wrapped.x = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        QuaternionPrototype,
        "y",
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => JavaScriptValue.FromDouble(o.wrapped.y)),
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => { o.wrapped.y = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        QuaternionPrototype,
        "z",
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => JavaScriptValue.FromDouble(o.wrapped.z)),
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => { o.wrapped.z = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        QuaternionPrototype,
        "w",
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => JavaScriptValue.FromDouble(o.wrapped.w)),
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => { o.wrapped.w = (float) args[1].ToDouble(); })
      );


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        QuaternionPrototype,
        "eulerAngles",
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.eulerAngles)),
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => { o.wrapped.eulerAngles = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetter(
        QuaternionPrototype,
        "normalized",
        Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.normalized))
      );


      // Instance Methods

      QuaternionPrototype.SetProperty(
        "Set",
        Bridge.CreateFunction(
          "Set",
          Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => o.wrapped.Set((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble()))
        )
      );


      QuaternionPrototype.SetProperty(
        "SetLookRotation",
        Bridge.CreateFunction(
          "SetLookRotation",
          Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => {
            if (args.Length == 2)
              o.wrapped.SetLookRotation(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped);
            else
              o.wrapped.SetLookRotation(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped);
          })
        )
      );


      /*
        Quaternion ToAngleAxis
        parameter angle is out
      */


      QuaternionPrototype.SetProperty(
        "SetFromToRotation",
        Bridge.CreateFunction(
          "SetFromToRotation",
          Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => o.wrapped.SetFromToRotation(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      QuaternionPrototype.SetProperty(
        "Normalize",
        Bridge.CreateFunction(
          "Normalize",
          Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => o.wrapped.Normalize())
        )
      );


      QuaternionPrototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => JavaScriptValue.FromInt32(o.wrapped.GetHashCode()))
        )
      );


      QuaternionPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      QuaternionPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped)))
        )
      );


      QuaternionPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Quaternion>((o, args) => {
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
