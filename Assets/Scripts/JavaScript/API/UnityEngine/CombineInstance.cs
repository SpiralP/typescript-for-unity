using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCombineInstance {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue CombineInstancePrototype;
      JavaScriptValue CombineInstanceConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.CombineInstance),
        (args) => { throw new System.NotImplementedException(); },
        out CombineInstancePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("CombineInstance", CombineInstanceConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        CombineInstancePrototype,
        "mesh",
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.mesh)),
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => { o.wrapped.mesh = Bridge.GetExternal<UnityEngine.Mesh>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        CombineInstancePrototype,
        "subMeshIndex",
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => JavaScriptValue.FromInt32(o.wrapped.subMeshIndex)),
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => { o.wrapped.subMeshIndex = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        CombineInstancePrototype,
        "transform",
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.transform)),
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => { o.wrapped.transform = Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CombineInstancePrototype,
        "lightmapScaleOffset",
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.lightmapScaleOffset)),
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => { o.wrapped.lightmapScaleOffset = Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        CombineInstancePrototype,
        "realtimeLightmapScaleOffset",
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.realtimeLightmapScaleOffset)),
        Bridge.WithBoxedExternal<UnityEngine.CombineInstance>((o, args) => { o.wrapped.realtimeLightmapScaleOffset = Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[1]).wrapped; })
      );


      // Instance Methods

    }
  }
}
