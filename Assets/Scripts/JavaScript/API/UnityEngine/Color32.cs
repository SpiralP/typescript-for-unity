using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSColor32 {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue Color32Prototype;
      JavaScriptValue Color32Constructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Color32),
        (args) => Bridge.CreateExternalWithPrototype(
          new UnityEngine.Color32(
            (byte) args[1].ToInt32(),
            (byte) args[2].ToInt32(),
            (byte) args[3].ToInt32(),
            (byte) args[4].ToInt32()
          )
        ),
        out Color32Prototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Color32", Color32Constructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      Color32Constructor.SetProperty(
        "Lerp",
        Bridge.CreateFunction(
          "Lerp",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color32.Lerp(Bridge.GetBoxedExternal<UnityEngine.Color32>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Color32>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      Color32Constructor.SetProperty(
        "LerpUnclamped",
        Bridge.CreateFunction(
          "LerpUnclamped",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color32.LerpUnclamped(Bridge.GetBoxedExternal<UnityEngine.Color32>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Color32>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        Color32Prototype,
        "r",
        Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.r)),
        Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => { o.wrapped.r = Bridge.GetBoxedExternal<System.Byte>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        Color32Prototype,
        "g",
        Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.g)),
        Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => { o.wrapped.g = Bridge.GetBoxedExternal<System.Byte>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        Color32Prototype,
        "b",
        Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.b)),
        Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => { o.wrapped.b = Bridge.GetBoxedExternal<System.Byte>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        Color32Prototype,
        "a",
        Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.a)),
        Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => { o.wrapped.a = Bridge.GetBoxedExternal<System.Byte>(args[1]).wrapped; })
      );


      // Instance Property Accessors


      // Instance Methods

      Color32Prototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => {
            if (args.Length == 1)
              return JavaScriptValue.FromString(o.wrapped.ToString());
            else
              return JavaScriptValue.FromString(o.wrapped.ToString(args[1].ToString()));
          })
        )
      );


      Color32Prototype.SetProperty(
        "ToColor",
        Bridge.CreateFunction(
          "ToColor",
          Bridge.WithBoxedExternal<UnityEngine.Color32>((o, args) => {
            UnityEngine.Color asColor = o.wrapped;
            return Bridge.CreateExternalWithPrototype(asColor);
          })
        )
      );
    }
  }
}
