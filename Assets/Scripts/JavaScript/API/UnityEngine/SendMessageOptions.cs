using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSSendMessageOptions {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue SendMessageOptionsPrototype;
      JavaScriptValue SendMessageOptionsConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.SendMessageOptions),
        (args) => { throw new System.NotImplementedException(); },
        out SendMessageOptionsPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("SendMessageOptions", SendMessageOptionsConstructor);


      // Static Fields

      SendMessageOptionsConstructor.SetProperty(
        "RequireReceiver",
        Bridge.CreateExternalWithPrototype(UnityEngine.SendMessageOptions.RequireReceiver)
      );


      SendMessageOptionsConstructor.SetProperty(
        "DontRequireReceiver",
        Bridge.CreateExternalWithPrototype(UnityEngine.SendMessageOptions.DontRequireReceiver)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
