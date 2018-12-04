using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSBoneWeight {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue BoneWeightPrototype;
      JavaScriptValue BoneWeightConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.BoneWeight),
        (args) => { throw new System.NotImplementedException(); },
        out BoneWeightPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("BoneWeight", BoneWeightConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        BoneWeightPrototype,
        "weight0",
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromDouble(o.wrapped.weight0)),
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => { o.wrapped.weight0 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        BoneWeightPrototype,
        "weight1",
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromDouble(o.wrapped.weight1)),
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => { o.wrapped.weight1 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        BoneWeightPrototype,
        "weight2",
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromDouble(o.wrapped.weight2)),
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => { o.wrapped.weight2 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        BoneWeightPrototype,
        "weight3",
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromDouble(o.wrapped.weight3)),
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => { o.wrapped.weight3 = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        BoneWeightPrototype,
        "boneIndex0",
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromInt32(o.wrapped.boneIndex0)),
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => { o.wrapped.boneIndex0 = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        BoneWeightPrototype,
        "boneIndex1",
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromInt32(o.wrapped.boneIndex1)),
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => { o.wrapped.boneIndex1 = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        BoneWeightPrototype,
        "boneIndex2",
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromInt32(o.wrapped.boneIndex2)),
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => { o.wrapped.boneIndex2 = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        BoneWeightPrototype,
        "boneIndex3",
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromInt32(o.wrapped.boneIndex3)),
        Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => { o.wrapped.boneIndex3 = args[1].ToInt32(); })
      );


      // Instance Methods

      BoneWeightPrototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromInt32(o.wrapped.GetHashCode()))
        )
      );


      BoneWeightPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      BoneWeightPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.BoneWeight>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetBoxedExternal<UnityEngine.BoneWeight>(args[1]).wrapped)))
        )
      );


    }
  }
}
