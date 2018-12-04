using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSResolution {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ResolutionPrototype;
      JavaScriptValue ResolutionConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Resolution),
        (args) => { throw new System.NotImplementedException(); },
        out ResolutionPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Resolution", ResolutionConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        ResolutionPrototype,
        "width",
        Bridge.WithBoxedExternal<UnityEngine.Resolution>((o, args) => JavaScriptValue.FromInt32(o.wrapped.width)),
        Bridge.WithBoxedExternal<UnityEngine.Resolution>((o, args) => { o.wrapped.width = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        ResolutionPrototype,
        "height",
        Bridge.WithBoxedExternal<UnityEngine.Resolution>((o, args) => JavaScriptValue.FromInt32(o.wrapped.height)),
        Bridge.WithBoxedExternal<UnityEngine.Resolution>((o, args) => { o.wrapped.height = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        ResolutionPrototype,
        "refreshRate",
        Bridge.WithBoxedExternal<UnityEngine.Resolution>((o, args) => JavaScriptValue.FromInt32(o.wrapped.refreshRate)),
        Bridge.WithBoxedExternal<UnityEngine.Resolution>((o, args) => { o.wrapped.refreshRate = args[1].ToInt32(); })
      );


      // Instance Methods

      ResolutionPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Resolution>((o, args) => JavaScriptValue.FromString(o.wrapped.ToString()))
        )
      );


    }
  }
}
