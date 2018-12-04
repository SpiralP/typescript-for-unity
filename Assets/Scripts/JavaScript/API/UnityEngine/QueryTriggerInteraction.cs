using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSQueryTriggerInteraction {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue QueryTriggerInteractionPrototype;
      JavaScriptValue QueryTriggerInteractionConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.QueryTriggerInteraction),
        (args) => { throw new System.NotImplementedException(); },
        out QueryTriggerInteractionPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("QueryTriggerInteraction", QueryTriggerInteractionConstructor);


      // Static Fields

      QueryTriggerInteractionConstructor.SetProperty(
        "UseGlobal",
        Bridge.CreateExternalWithPrototype(UnityEngine.QueryTriggerInteraction.UseGlobal)
      );


      QueryTriggerInteractionConstructor.SetProperty(
        "Ignore",
        Bridge.CreateExternalWithPrototype(UnityEngine.QueryTriggerInteraction.Ignore)
      );


      QueryTriggerInteractionConstructor.SetProperty(
        "Collide",
        Bridge.CreateExternalWithPrototype(UnityEngine.QueryTriggerInteraction.Collide)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
