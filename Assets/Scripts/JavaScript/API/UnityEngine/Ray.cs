using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSRay {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RayPrototype;
      JavaScriptValue RayConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Ray),
        (args) => {
          return Bridge.CreateExternalWithPrototype(
            new UnityEngine.Ray(
              Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, // origin
              Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped // direction
            )
          );
        },
        out RayPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Ray", RayConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        RayPrototype,
        "origin",
        Bridge.WithBoxedExternal<UnityEngine.Ray>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.origin)),
        Bridge.WithBoxedExternal<UnityEngine.Ray>((o, args) => { o.wrapped.origin = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        RayPrototype,
        "direction",
        Bridge.WithBoxedExternal<UnityEngine.Ray>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.direction)),
        Bridge.WithBoxedExternal<UnityEngine.Ray>((o, args) => { o.wrapped.direction = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      // Instance Methods

      RayPrototype.SetProperty(
        "GetPoint",
        Bridge.CreateFunction(
          "GetPoint",
          Bridge.WithBoxedExternal<UnityEngine.Ray>((o, args) => Bridge.CreateExternalWithPrototype(o.wrapped.GetPoint((float) args[1].ToDouble())))
        )
      );


      RayPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithBoxedExternal<UnityEngine.Ray>((o, args) => {
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
