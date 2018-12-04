using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSMatrix4x4 {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue Matrix4x4Prototype;
      JavaScriptValue Matrix4x4Constructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Matrix4x4),
        (args) => { throw new System.NotImplementedException(); },
        out Matrix4x4Prototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Matrix4x4", Matrix4x4Constructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetter(
        Matrix4x4Constructor,
        "zero",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.zero)
      );


      Bridge.DefineGetter(
        Matrix4x4Constructor,
        "identity",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.identity)
      );


      // Static Methods

      Matrix4x4Constructor.SetProperty(
        "Determinant",
        Bridge.CreateFunction(
          "Determinant",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Matrix4x4.Determinant(Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "TRS",
        Bridge.CreateFunction(
          "TRS",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.TRS(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Inverse",
        Bridge.CreateFunction(
          "Inverse",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Inverse(Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Transpose",
        Bridge.CreateFunction(
          "Transpose",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Transpose(Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Ortho",
        Bridge.CreateFunction(
          "Ortho",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Ortho((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble(), (float) args[6].ToDouble()))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Perspective",
        Bridge.CreateFunction(
          "Perspective",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Perspective((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble()))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "LookAt",
        Bridge.CreateFunction(
          "LookAt",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.LookAt(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Frustum",
        Bridge.CreateFunction(
          "Frustum",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Frustum((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble(), (float) args[6].ToDouble()))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Frustum",
        Bridge.CreateFunction(
          "Frustum",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Frustum(Bridge.GetBoxedExternal<UnityEngine.FrustumPlanes>(args[1]).wrapped))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Scale",
        Bridge.CreateFunction(
          "Scale",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Scale(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Translate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      Matrix4x4Constructor.SetProperty(
        "Rotate",
        Bridge.CreateFunction(
          "Rotate",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Matrix4x4.Rotate(Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped))
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m00",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m00)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m00 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m10",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m10)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m10 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m20",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m20)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m20 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m30",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m30)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m30 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m01",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m01)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m01 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m11",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m11)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m11 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m21",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m21)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m21 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m31",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m31)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m31 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m02",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m02)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m02 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m12",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m12)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m12 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m22",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m22)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m22 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m32",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m32)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m32 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m03",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m03)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m03 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m13",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m13)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m13 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m23",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m23)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m23 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        Matrix4x4Prototype,
        "m33",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.m33)),
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => { o.wrapped.m33 = (float) args[1].ToDouble(); })
      );


      // Instance Property Accessors

      Bridge.DefineGetter(
        Matrix4x4Prototype,
        "rotation",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.rotation))
      );


      Bridge.DefineGetter(
        Matrix4x4Prototype,
        "lossyScale",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.lossyScale))
      );


      Bridge.DefineGetter(
        Matrix4x4Prototype,
        "isIdentity",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.isIdentity))
      );


      Bridge.DefineGetter(
        Matrix4x4Prototype,
        "determinant",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromDouble(o.wrapped.determinant))
      );


      Bridge.DefineGetter(
        Matrix4x4Prototype,
        "decomposeProjection",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.decomposeProjection))
      );


      Bridge.DefineGetter(
        Matrix4x4Prototype,
        "inverse",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.inverse))
      );


      Bridge.DefineGetter(
        Matrix4x4Prototype,
        "transpose",
        Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.transpose))
      );


      // Instance Methods

      Matrix4x4Prototype.SetProperty(
        "ValidTRS",
        Bridge.CreateFunction(
          "ValidTRS",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.ValidTRS()))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "SetTRS",
        Bridge.CreateFunction(
          "SetTRS",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => o.wrapped.SetTRS(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[3]).wrapped))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromInt32(o.wrapped.GetHashCode()))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped)))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "GetColumn",
        Bridge.CreateFunction(
          "GetColumn",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.GetColumn(args[1].ToInt32())))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "GetRow",
        Bridge.CreateFunction(
          "GetRow",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.GetRow(args[1].ToInt32())))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "SetColumn",
        Bridge.CreateFunction(
          "SetColumn",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => o.wrapped.SetColumn(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "SetRow",
        Bridge.CreateFunction(
          "SetRow",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => o.wrapped.SetRow(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "MultiplyPoint",
        Bridge.CreateFunction(
          "MultiplyPoint",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.MultiplyPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "MultiplyPoint3x4",
        Bridge.CreateFunction(
          "MultiplyPoint3x4",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.MultiplyPoint3x4(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "MultiplyVector",
        Bridge.CreateFunction(
          "MultiplyVector",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.MultiplyVector(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "TransformPlane",
        Bridge.CreateFunction(
          "TransformPlane",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.TransformPlane(Bridge.GetBoxedExternal<UnityEngine.Plane>(args[1]).wrapped)))
        )
      );


      Matrix4x4Prototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Matrix4x4>((o, args) => {
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
