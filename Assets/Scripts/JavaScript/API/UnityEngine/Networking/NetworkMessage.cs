using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkMessage {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkMessagePrototype;
      JavaScriptValue NetworkMessageConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkMessage),
        (args) => { throw new NotImplementedException(); },
        out NetworkMessagePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkMessage", NetworkMessageConstructor);


      // Static Fields

      NetworkMessageConstructor.SetProperty(
        "MaxMessageSize",
        JavaScriptValue.FromInt32(UnityEngine.Networking.NetworkMessage.MaxMessageSize)
      );


      // Static Property Accessors


      // Static Methods

      NetworkMessageConstructor.SetProperty(
        "Dump",
        Bridge.CreateFunction(
          "Dump",
          (args) => JavaScriptValue.FromString(UnityEngine.Networking.NetworkMessage.Dump(Bridge.GetExternal<System.Byte[]>(args[1]), args[2].ToInt32()))
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        NetworkMessagePrototype,
        "msgType",
        WithExternal<UnityEngine.Networking.NetworkMessage>((o, args) => Bridge.CreateExternalWithPrototype(o.msgType)),
        WithExternal<UnityEngine.Networking.NetworkMessage>((o, args) => { o.msgType = Bridge.GetExternal<System.Int16>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkMessagePrototype,
        "conn",
        WithExternal<UnityEngine.Networking.NetworkMessage>((o, args) => Bridge.CreateExternalWithPrototype(o.conn)),
        WithExternal<UnityEngine.Networking.NetworkMessage>((o, args) => { o.conn = Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkMessagePrototype,
        "reader",
        WithExternal<UnityEngine.Networking.NetworkMessage>((o, args) => Bridge.CreateExternalWithPrototype(o.reader)),
        WithExternal<UnityEngine.Networking.NetworkMessage>((o, args) => { o.reader = Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkMessagePrototype,
        "channelId",
        WithExternal<UnityEngine.Networking.NetworkMessage>((o, args) => JavaScriptValue.FromInt32(o.channelId)),
        WithExternal<UnityEngine.Networking.NetworkMessage>((o, args) => { o.channelId = args[1].ToInt32(); })
      );


      // Instance Property Accessors


      // Instance Methods

      /*
        NetworkMessage ReadMessage
        method has generics
      */


      /*
        NetworkMessage ReadMessage
        method has generics
      */


    }
  }
}
