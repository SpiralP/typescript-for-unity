using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSColor {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ColorPrototype;
      JavaScriptValue ColorConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Color),
        (args) => { throw new System.NotImplementedException(); },
        out ColorPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Color", ColorConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetter(
        ColorConstructor,
        "red",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.red)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "green",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.green)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "blue",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.blue)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "white",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.white)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "black",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.black)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "yellow",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.yellow)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "cyan",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.cyan)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "magenta",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.magenta)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "gray",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.gray)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "grey",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.grey)
      );


      Bridge.DefineGetter(
        ColorConstructor,
        "clear",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.clear)
      );


      // Static Methods

      ColorConstructor.SetProperty(
        "Lerp",
        Bridge.CreateFunction(
          "Lerp",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.Lerp(Bridge.GetBoxedExternal<UnityEngine.Color>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Color>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      ColorConstructor.SetProperty(
        "LerpUnclamped",
        Bridge.CreateFunction(
          "LerpUnclamped",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.LerpUnclamped(Bridge.GetBoxedExternal<UnityEngine.Color>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Color>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      /*
        Color RGBToHSV
        parameter H is out
      */


      ColorConstructor.SetProperty(
        "HSVToRGB",
        Bridge.CreateFunction(
          "HSVToRGB",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.HSVToRGB((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      ColorConstructor.SetProperty(
        "HSVToRGB",
        Bridge.CreateFunction(
          "HSVToRGB",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Color.HSVToRGB((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), args[4].ToBoolean()))
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        ColorPrototype,
        "r",
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromDouble(o.wrapped.r)),
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => { o.wrapped.r = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        ColorPrototype,
        "g",
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromDouble(o.wrapped.g)),
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => { o.wrapped.g = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        ColorPrototype,
        "b",
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromDouble(o.wrapped.b)),
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => { o.wrapped.b = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        ColorPrototype,
        "a",
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromDouble(o.wrapped.a)),
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => { o.wrapped.a = (float) args[1].ToDouble(); })
      );


      // Instance Property Accessors

      Bridge.DefineGetter(
        ColorPrototype,
        "grayscale",
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromDouble(o.wrapped.grayscale))
      );


      Bridge.DefineGetter(
        ColorPrototype,
        "linear",
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.linear))
      );


      Bridge.DefineGetter(
        ColorPrototype,
        "gamma",
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.gamma))
      );


      Bridge.DefineGetter(
        ColorPrototype,
        "maxColorComponent",
        Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromDouble(o.wrapped.maxColorComponent))
      );


      // Instance Methods

      ColorPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => {
            if (args.Length == 1)
              return JavaScriptValue.FromString(o.wrapped.ToString());
            else
              return JavaScriptValue.FromString(o.wrapped.ToString(args[1].ToString()));
          })
        )
      );


      ColorPrototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromInt32(o.wrapped.GetHashCode()))
        )
      );


      // ColorPrototype.SetProperty(
      //   "Equals",
      //   Bridge.CreateFunction(
      //     "Equals",
      //     Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetExternal<System.Object>(args[1]))))
      //   )
      // );


      ColorPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => JavaScriptValue.FromBoolean(o.wrapped.Equals(Bridge.GetBoxedExternal<UnityEngine.Color>(args[1]).wrapped)))
        )
      );


      ColorPrototype.SetProperty(
        "ToColor32",
        Bridge.CreateFunction(
          "ToColor32",
          Bridge.WithBoxedExternal<UnityEngine.Color>((o, args) => {
            UnityEngine.Color32 asColor32 = o.wrapped;
            return Bridge.CreateExternalWithPrototype(asColor32);
          })
        )
      );
    }
  }
}
