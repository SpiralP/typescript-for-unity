using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSRandom {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RandomPrototype;
      JavaScriptValue RandomConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Random),
        (args) => { throw new System.NotImplementedException(); },
        out RandomPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Random", RandomConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetterSetter(
        RandomConstructor,
        "state",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.state),
        (args) => { UnityEngine.Random.state = Bridge.GetBoxedExternal<UnityEngine.Random.State>(args[1]).wrapped; }
      );


      Bridge.DefineGetter(
        RandomConstructor,
        "value",
        (args) => JavaScriptValue.FromDouble(UnityEngine.Random.value)
      );


      Bridge.DefineGetter(
        RandomConstructor,
        "insideUnitSphere",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.insideUnitSphere)
      );


      Bridge.DefineGetter(
        RandomConstructor,
        "insideUnitCircle",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.insideUnitCircle)
      );


      Bridge.DefineGetter(
        RandomConstructor,
        "onUnitSphere",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.onUnitSphere)
      );


      Bridge.DefineGetter(
        RandomConstructor,
        "rotation",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.rotation)
      );


      Bridge.DefineGetter(
        RandomConstructor,
        "rotationUniform",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.rotationUniform)
      );


      // Static Methods

      RandomConstructor.SetProperty(
        "InitState",
        Bridge.CreateFunction(
          "InitState",
          (args) => UnityEngine.Random.InitState(args[1].ToInt32())
        )
      );


      RandomConstructor.SetProperty(
        "Range",
        Bridge.CreateFunction(
          "Range",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Random.Range((float) args[1].ToDouble(), (float) args[2].ToDouble()))
        )
      );


      RandomConstructor.SetProperty(
        "Range",
        Bridge.CreateFunction(
          "Range",
          (args) => JavaScriptValue.FromInt32(UnityEngine.Random.Range(args[1].ToInt32(), args[2].ToInt32()))
        )
      );


      RandomConstructor.SetProperty(
        "ColorHSV",
        Bridge.CreateFunction(
          "ColorHSV",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.ColorHSV())
        )
      );


      RandomConstructor.SetProperty(
        "ColorHSV",
        Bridge.CreateFunction(
          "ColorHSV",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.ColorHSV((float) args[1].ToDouble(), (float) args[2].ToDouble()))
        )
      );


      RandomConstructor.SetProperty(
        "ColorHSV",
        Bridge.CreateFunction(
          "ColorHSV",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.ColorHSV((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble()))
        )
      );


      RandomConstructor.SetProperty(
        "ColorHSV",
        Bridge.CreateFunction(
          "ColorHSV",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.ColorHSV((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble(), (float) args[6].ToDouble()))
        )
      );


      RandomConstructor.SetProperty(
        "ColorHSV",
        Bridge.CreateFunction(
          "ColorHSV",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Random.ColorHSV((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble(), (float) args[6].ToDouble(), (float) args[7].ToDouble(), (float) args[8].ToDouble()))
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
