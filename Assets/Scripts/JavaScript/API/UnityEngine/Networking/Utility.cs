using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSUtility {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue UtilityPrototype;
      JavaScriptValue UtilityConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.Utility),
        (args) => { throw new NotImplementedException(); },
        out UtilityPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("Utility", UtilityConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      UtilityConstructor.SetProperty(
        "GetSourceID",
        Bridge.CreateFunction(
          "GetSourceID",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.Utility.GetSourceID())
        )
      );


      UtilityConstructor.SetProperty(
        "SetAccessTokenForNetwork",
        Bridge.CreateFunction(
          "SetAccessTokenForNetwork",
          (args) => UnityEngine.Networking.Utility.SetAccessTokenForNetwork(Bridge.GetExternal<UnityEngine.Networking.Types.NetworkID>(args[1]), Bridge.GetExternal<UnityEngine.Networking.Types.NetworkAccessToken>(args[2]))
        )
      );


      UtilityConstructor.SetProperty(
        "GetAccessTokenForNetwork",
        Bridge.CreateFunction(
          "GetAccessTokenForNetwork",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.Utility.GetAccessTokenForNetwork(Bridge.GetExternal<UnityEngine.Networking.Types.NetworkID>(args[1])))
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
