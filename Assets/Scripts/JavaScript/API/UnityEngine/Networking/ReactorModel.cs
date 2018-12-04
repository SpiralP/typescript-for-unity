using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSReactorModel {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ReactorModelPrototype;
      JavaScriptValue ReactorModelConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.ReactorModel),
        (args) => { throw new NotImplementedException(); },
        out ReactorModelPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("ReactorModel", ReactorModelConstructor);


      // Static Fields

      ReactorModelConstructor.SetProperty(
        "SelectReactor",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.ReactorModel.SelectReactor)
      );


      ReactorModelConstructor.SetProperty(
        "FixRateReactor",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.ReactorModel.FixRateReactor)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
