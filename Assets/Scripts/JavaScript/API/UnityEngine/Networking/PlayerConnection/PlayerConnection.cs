using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking.PlayerConnection {
  class JSPlayerConnection {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PlayerConnectionPrototype;
      JavaScriptValue PlayerConnectionConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.PlayerConnection.PlayerConnection),
        (args) => { throw new NotImplementedException(); },
        out PlayerConnectionPrototype // extends TODO
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .GetProperty("PlayerConnection")
        .SetProperty("PlayerConnection", PlayerConnectionConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetter(
        PlayerConnectionConstructor,
        "instance",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.PlayerConnection.PlayerConnection.instance)
      );


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        PlayerConnectionPrototype,
        "isConnected",
        WithExternal<UnityEngine.Networking.PlayerConnection.PlayerConnection>((o, args) => JavaScriptValue.FromBoolean(o.isConnected))
      );


      // Instance Methods

      PlayerConnectionPrototype.SetProperty(
        "OnEnable",
        Bridge.CreateFunction(
          "OnEnable",
          WithExternal<UnityEngine.Networking.PlayerConnection.PlayerConnection>((o, args) => o.OnEnable())
        )
      );


      /*
        PlayerConnection Register
        UnityEngine.Events.UnityAction`1[UnityEngine.Networking.PlayerConnection.MessageEventArgs] has generics
      */


      /*
        PlayerConnection Unregister
        UnityEngine.Events.UnityAction`1[UnityEngine.Networking.PlayerConnection.MessageEventArgs] has generics
      */


      /*
        PlayerConnection RegisterConnection
        UnityEngine.Events.UnityAction`1[System.Int32] has generics
      */


      /*
        PlayerConnection RegisterDisconnection
        UnityEngine.Events.UnityAction`1[System.Int32] has generics
      */


      PlayerConnectionPrototype.SetProperty(
        "Send",
        Bridge.CreateFunction(
          "Send",
          WithExternal<UnityEngine.Networking.PlayerConnection.PlayerConnection>((o, args) => o.Send(Bridge.GetExternal<System.Guid>(args[1]), Bridge.GetExternal<System.Byte[]>(args[2])))
        )
      );


      PlayerConnectionPrototype.SetProperty(
        "BlockUntilRecvMsg",
        Bridge.CreateFunction(
          "BlockUntilRecvMsg",
          WithExternal<UnityEngine.Networking.PlayerConnection.PlayerConnection>((o, args) => JavaScriptValue.FromBoolean(o.BlockUntilRecvMsg(Bridge.GetExternal<System.Guid>(args[1]), args[2].ToInt32())))
        )
      );


      PlayerConnectionPrototype.SetProperty(
        "DisconnectAll",
        Bridge.CreateFunction(
          "DisconnectAll",
          WithExternal<UnityEngine.Networking.PlayerConnection.PlayerConnection>((o, args) => o.DisconnectAll())
        )
      );


    }
  }
}
