using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking.PlayerConnection {
  class JSMessageEventArgs {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue MessageEventArgsPrototype;
      JavaScriptValue MessageEventArgsConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.PlayerConnection.MessageEventArgs),
        (args) => { throw new NotImplementedException(); },
        out MessageEventArgsPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .GetProperty("PlayerConnection")
        .SetProperty("MessageEventArgs", MessageEventArgsConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields

      Bridge.DefineGetterSetter(
        MessageEventArgsPrototype,
        "playerId",
        WithExternal<UnityEngine.Networking.PlayerConnection.MessageEventArgs>((o, args) => JavaScriptValue.FromInt32(o.playerId)),
        WithExternal<UnityEngine.Networking.PlayerConnection.MessageEventArgs>((o, args) => { o.playerId = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        MessageEventArgsPrototype,
        "data",
        WithExternal<UnityEngine.Networking.PlayerConnection.MessageEventArgs>((o, args) => Bridge.CreateExternalWithPrototype(o.data)),
        WithExternal<UnityEngine.Networking.PlayerConnection.MessageEventArgs>((o, args) => { o.data = Bridge.GetExternal<System.Byte[]>(args[1]); })
      );


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
