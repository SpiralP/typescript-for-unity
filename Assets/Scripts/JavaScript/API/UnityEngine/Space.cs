using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSSpace {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue SpacePrototype;
      JavaScriptValue SpaceConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Space),
        (args) => { throw new System.NotImplementedException(); },
        out SpacePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Space", SpaceConstructor);


      // Static Fields

      SpaceConstructor.SetProperty(
        "World",
        Bridge.CreateExternalWithPrototype(UnityEngine.Space.World)
      );


      SpaceConstructor.SetProperty(
        "Self",
        Bridge.CreateExternalWithPrototype(UnityEngine.Space.Self)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
