using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSPlayerController {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PlayerControllerPrototype;
      JavaScriptValue PlayerControllerConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.PlayerController),
        (args) => { throw new NotImplementedException(); },
        out PlayerControllerPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("PlayerController", PlayerControllerConstructor);


      // Static Fields

      PlayerControllerConstructor.SetProperty(
        "MaxPlayersPerClient",
        JavaScriptValue.FromInt32(UnityEngine.Networking.PlayerController.MaxPlayersPerClient)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields

      Bridge.DefineGetterSetter(
        PlayerControllerPrototype,
        "playerControllerId",
        WithExternal<UnityEngine.Networking.PlayerController>((o, args) => Bridge.CreateExternalWithPrototype(o.playerControllerId)),
        WithExternal<UnityEngine.Networking.PlayerController>((o, args) => { o.playerControllerId = Bridge.GetExternal<System.Int16>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PlayerControllerPrototype,
        "unetView",
        WithExternal<UnityEngine.Networking.PlayerController>((o, args) => Bridge.CreateExternalWithPrototype(o.unetView)),
        WithExternal<UnityEngine.Networking.PlayerController>((o, args) => { o.unetView = Bridge.GetExternal<UnityEngine.Networking.NetworkIdentity>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PlayerControllerPrototype,
        "gameObject",
        WithExternal<UnityEngine.Networking.PlayerController>((o, args) => Bridge.CreateExternalWithPrototype(o.gameObject)),
        WithExternal<UnityEngine.Networking.PlayerController>((o, args) => { o.gameObject = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      // Instance Property Accessors

      Bridge.DefineGetter(
        PlayerControllerPrototype,
        "IsValid",
        WithExternal<UnityEngine.Networking.PlayerController>((o, args) => JavaScriptValue.FromBoolean(o.IsValid))
      );


      // Instance Methods

      PlayerControllerPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          WithExternal<UnityEngine.Networking.PlayerController>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


    }
  }
}
