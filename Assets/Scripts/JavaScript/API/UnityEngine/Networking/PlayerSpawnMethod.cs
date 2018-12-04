using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSPlayerSpawnMethod {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PlayerSpawnMethodPrototype;
      JavaScriptValue PlayerSpawnMethodConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.PlayerSpawnMethod),
        (args) => { throw new NotImplementedException(); },
        out PlayerSpawnMethodPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("PlayerSpawnMethod", PlayerSpawnMethodConstructor);


      // Static Fields

      PlayerSpawnMethodConstructor.SetProperty(
        "Random",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.PlayerSpawnMethod.Random)
      );


      PlayerSpawnMethodConstructor.SetProperty(
        "RoundRobin",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.PlayerSpawnMethod.RoundRobin)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
