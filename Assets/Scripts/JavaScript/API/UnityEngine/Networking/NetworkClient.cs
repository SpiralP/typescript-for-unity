using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkClient {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkClientPrototype;
      JavaScriptValue NetworkClientConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkClient),
        (args) => { throw new NotImplementedException(); },
        out NetworkClientPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkClient", NetworkClientConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetter(
        NetworkClientConstructor,
        "allClients",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkClient.allClients)
      );


      Bridge.DefineGetter(
        NetworkClientConstructor,
        "active",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkClient.active)
      );


      // Static Methods

      NetworkClientConstructor.SetProperty(
        "GetTotalConnectionStats",
        Bridge.CreateFunction(
          "GetTotalConnectionStats",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkClient.GetTotalConnectionStats())
        )
      );


      NetworkClientConstructor.SetProperty(
        "ShutdownAll",
        Bridge.CreateFunction(
          "ShutdownAll",
          (args) => UnityEngine.Networking.NetworkClient.ShutdownAll()
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        NetworkClientPrototype,
        "serverIp",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromString(o.serverIp))
      );


      Bridge.DefineGetter(
        NetworkClientPrototype,
        "serverPort",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromInt32(o.serverPort))
      );


      Bridge.DefineGetter(
        NetworkClientPrototype,
        "connection",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => Bridge.CreateExternalWithPrototype(o.connection))
      );


      Bridge.DefineGetter(
        NetworkClientPrototype,
        "handlers",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => Bridge.CreateExternalWithPrototype(o.handlers))
      );


      Bridge.DefineGetter(
        NetworkClientPrototype,
        "numChannels",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromInt32(o.numChannels))
      );


      Bridge.DefineGetter(
        NetworkClientPrototype,
        "hostTopology",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => Bridge.CreateExternalWithPrototype(o.hostTopology))
      );


      Bridge.DefineGetterSetter(
        NetworkClientPrototype,
        "hostPort",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromInt32(o.hostPort)),
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => { o.hostPort = args[1].ToInt32(); })
      );


      Bridge.DefineGetter(
        NetworkClientPrototype,
        "isConnected",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.isConnected))
      );


      Bridge.DefineGetter(
        NetworkClientPrototype,
        "networkConnectionClass",
        WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => Bridge.CreateExternalWithPrototype(o.networkConnectionClass))
      );


      // Instance Methods

      /*
        NetworkClient SetNetworkConnectionClass
        method has generics
      */


      NetworkClientPrototype.SetProperty(
        "Configure",
        Bridge.CreateFunction(
          "Configure",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.Configure(Bridge.GetExternal<UnityEngine.Networking.ConnectionConfig>(args[1]), args[2].ToInt32())))
        )
      );


      NetworkClientPrototype.SetProperty(
        "Configure",
        Bridge.CreateFunction(
          "Configure",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.Configure(Bridge.GetExternal<UnityEngine.Networking.HostTopology>(args[1]))))
        )
      );


      NetworkClientPrototype.SetProperty(
        "Connect",
        Bridge.CreateFunction(
          "Connect",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.Connect(Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[1])))
        )
      );


      NetworkClientPrototype.SetProperty(
        "ReconnectToNewHost",
        Bridge.CreateFunction(
          "ReconnectToNewHost",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.ReconnectToNewHost(args[1].ToString(), args[2].ToInt32())))
        )
      );


      NetworkClientPrototype.SetProperty(
        "ReconnectToNewHost",
        Bridge.CreateFunction(
          "ReconnectToNewHost",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.ReconnectToNewHost(Bridge.GetExternal<System.Net.EndPoint>(args[1]))))
        )
      );


      NetworkClientPrototype.SetProperty(
        "ConnectWithSimulator",
        Bridge.CreateFunction(
          "ConnectWithSimulator",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.ConnectWithSimulator(args[1].ToString(), args[2].ToInt32(), args[3].ToInt32(), (float) args[4].ToDouble()))
        )
      );


      NetworkClientPrototype.SetProperty(
        "Connect",
        Bridge.CreateFunction(
          "Connect",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.Connect(args[1].ToString(), args[2].ToInt32()))
        )
      );


      NetworkClientPrototype.SetProperty(
        "Connect",
        Bridge.CreateFunction(
          "Connect",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.Connect(Bridge.GetExternal<System.Net.EndPoint>(args[1])))
        )
      );


      NetworkClientPrototype.SetProperty(
        "Disconnect",
        Bridge.CreateFunction(
          "Disconnect",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.Disconnect())
        )
      );


      NetworkClientPrototype.SetProperty(
        "Send",
        Bridge.CreateFunction(
          "Send",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.Send(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2]))))
        )
      );


      NetworkClientPrototype.SetProperty(
        "SendWriter",
        Bridge.CreateFunction(
          "SendWriter",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.SendWriter(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), args[2].ToInt32())))
        )
      );


      NetworkClientPrototype.SetProperty(
        "SendBytes",
        Bridge.CreateFunction(
          "SendBytes",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.SendBytes(Bridge.GetExternal<System.Byte[]>(args[1]), args[2].ToInt32(), args[3].ToInt32())))
        )
      );


      NetworkClientPrototype.SetProperty(
        "SendUnreliable",
        Bridge.CreateFunction(
          "SendUnreliable",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.SendUnreliable(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2]))))
        )
      );


      NetworkClientPrototype.SetProperty(
        "SendByChannel",
        Bridge.CreateFunction(
          "SendByChannel",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromBoolean(o.SendByChannel(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[2]), args[3].ToInt32())))
        )
      );


      NetworkClientPrototype.SetProperty(
        "SetMaxDelay",
        Bridge.CreateFunction(
          "SetMaxDelay",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.SetMaxDelay((float) args[1].ToDouble()))
        )
      );


      NetworkClientPrototype.SetProperty(
        "Shutdown",
        Bridge.CreateFunction(
          "Shutdown",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.Shutdown())
        )
      );


      /*
        NetworkClient GetStatsOut
        parameter numMsgs is out
      */


      /*
        NetworkClient GetStatsIn
        parameter numMsgs is out
      */


      NetworkClientPrototype.SetProperty(
        "GetConnectionStats",
        Bridge.CreateFunction(
          "GetConnectionStats",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => Bridge.CreateExternalWithPrototype(o.GetConnectionStats()))
        )
      );


      NetworkClientPrototype.SetProperty(
        "ResetConnectionStats",
        Bridge.CreateFunction(
          "ResetConnectionStats",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.ResetConnectionStats())
        )
      );


      NetworkClientPrototype.SetProperty(
        "GetRTT",
        Bridge.CreateFunction(
          "GetRTT",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => JavaScriptValue.FromInt32(o.GetRTT()))
        )
      );


      NetworkClientPrototype.SetProperty(
        "RegisterHandler",
        Bridge.CreateFunction(
          "RegisterHandler",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.RegisterHandler(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkMessageDelegate>(args[2])))
        )
      );


      NetworkClientPrototype.SetProperty(
        "RegisterHandlerSafe",
        Bridge.CreateFunction(
          "RegisterHandlerSafe",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.RegisterHandlerSafe(Bridge.GetExternal<System.Int16>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkMessageDelegate>(args[2])))
        )
      );


      NetworkClientPrototype.SetProperty(
        "UnregisterHandler",
        Bridge.CreateFunction(
          "UnregisterHandler",
          WithExternal<UnityEngine.Networking.NetworkClient>((o, args) => o.UnregisterHandler(Bridge.GetExternal<System.Int16>(args[1])))
        )
      );


    }
  }
}
