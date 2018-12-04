using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkConnection {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkConnectionPrototype;
      JavaScriptValue NetworkConnectionConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkConnection),
        (args) => { throw new NotImplementedException(); },
        out NetworkConnectionPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkConnection", NetworkConnectionConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields

      Bridge.DefineGetterSetter(
        NetworkConnectionPrototype,
        "hostId",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromInt32(o.hostId)),
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => { o.hostId = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkConnectionPrototype,
        "connectionId",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromInt32(o.connectionId)),
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => { o.connectionId = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkConnectionPrototype,
        "isReady",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.isReady)),
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => { o.isReady = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkConnectionPrototype,
        "address",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromString(o.address)),
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => { o.address = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkConnectionPrototype,
        "lastMessageTime",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromDouble(o.lastMessageTime)),
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => { o.lastMessageTime = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkConnectionPrototype,
        "logNetworkMessages",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.logNetworkMessages)),
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => { o.logNetworkMessages = args[1].ToBoolean(); })
      );


      // Instance Property Accessors

      Bridge.DefineGetter(
        NetworkConnectionPrototype,
        "playerControllers",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => Bridge.CreateExternalWithPrototype(o.playerControllers))
      );


      Bridge.DefineGetter(
        NetworkConnectionPrototype,
        "clientOwnedObjects",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => Bridge.CreateExternalWithPrototype(o.clientOwnedObjects))
      );


      Bridge.DefineGetter(
        NetworkConnectionPrototype,
        "isConnected",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.isConnected))
      );


      Bridge.DefineGetter(
        NetworkConnectionPrototype,
        "lastError",
        WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => Bridge.CreateExternalWithPrototype(o.lastError))
        // WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => { o.lastError = Bridge.GetExternal<UnityEngine.Networking.NetworkError>(args[1]); })
      );


      // Instance Methods

      NetworkConnectionPrototype.SetProperty(
        "Initialize",
        Bridge.CreateFunction(
          "Initialize",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.Initialize(args[1].ToString(), args[2].ToInt32(), args[3].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[4])))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "Dispose",
        Bridge.CreateFunction(
          "Dispose",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.Dispose())
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "SetChannelOption",
        Bridge.CreateFunction(
          "SetChannelOption",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.SetChannelOption(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.ChannelOption>(args[2]), args[3].ToInt32())))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "Disconnect",
        Bridge.CreateFunction(
          "Disconnect",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.Disconnect())
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "CheckHandler",
        Bridge.CreateFunction(
          "CheckHandler",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.CheckHandler(Bridge.GetExternal<System.Int16>(args[1]))))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "InvokeHandlerNoData",
        Bridge.CreateFunction(
          "InvokeHandlerNoData",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.InvokeHandlerNoData(Bridge.GetExternal<System.Int16>(args[1]))))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "InvokeHandler",
        Bridge.CreateFunction(
          "InvokeHandler",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.InvokeHandler(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[2]), args[3].ToInt32())))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "InvokeHandler",
        Bridge.CreateFunction(
          "InvokeHandler",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.InvokeHandler(Bridge.GetExternal<UnityEngine.Networking.NetworkMessage>(args[1]))))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "RegisterHandler",
        Bridge.CreateFunction(
          "RegisterHandler",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.RegisterHandler(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkMessageDelegate>(args[2])))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "UnregisterHandler",
        Bridge.CreateFunction(
          "UnregisterHandler",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.UnregisterHandler(Bridge.GetExternal<System.Int16>(args[1])))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "FlushChannels",
        Bridge.CreateFunction(
          "FlushChannels",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.FlushChannels())
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "SetMaxDelay",
        Bridge.CreateFunction(
          "SetMaxDelay",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.SetMaxDelay((float) args[1].ToDouble()))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "Send",
        Bridge.CreateFunction(
          "Send",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.Send(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2]))))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "SendUnreliable",
        Bridge.CreateFunction(
          "SendUnreliable",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.SendUnreliable(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2]))))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "SendByChannel",
        Bridge.CreateFunction(
          "SendByChannel",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.SendByChannel(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2]), args[3].ToInt32())))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "SendBytes",
        Bridge.CreateFunction(
          "SendBytes",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.SendBytes(Bridge.GetExternal<System.Byte[]>(args[1]), args[2].ToInt32(), args[3].ToInt32())))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "SendWriter",
        Bridge.CreateFunction(
          "SendWriter",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromBoolean(o.SendWriter(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), args[2].ToInt32())))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "ResetStats",
        Bridge.CreateFunction(
          "ResetStats",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.ResetStats())
        )
      );


      /*
        NetworkConnection GetStatsOut
        parameter numMsgs is out
      */


      /*
        NetworkConnection GetStatsIn
        parameter numMsgs is out
      */


      NetworkConnectionPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


      NetworkConnectionPrototype.SetProperty(
        "TransportReceive",
        Bridge.CreateFunction(
          "TransportReceive",
          WithExternal<UnityEngine.Networking.NetworkConnection>((o, args) => o.TransportReceive(Bridge.GetExternal<System.Byte[]>(args[1]), args[2].ToInt32(), args[3].ToInt32()))
        )
      );


      /*
        NetworkConnection TransportSend
        parameter error is out
      */


    }
  }
}
