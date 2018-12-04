using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSGlobalConfig {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue GlobalConfigPrototype;
      JavaScriptValue GlobalConfigConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.GlobalConfig),
        (args) => { throw new NotImplementedException(); },
        out GlobalConfigPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("GlobalConfig", GlobalConfigConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "ThreadAwakeTimeout",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.ThreadAwakeTimeout)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.ThreadAwakeTimeout = Bridge.GetExternal<System.UInt32>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "ReactorModel",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.ReactorModel)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.ReactorModel = Bridge.GetExternal<UnityEngine.Networking.ReactorModel>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "ReactorMaximumReceivedMessages",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.ReactorMaximumReceivedMessages)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.ReactorMaximumReceivedMessages = Bridge.GetExternal<System.UInt16>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "ReactorMaximumSentMessages",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.ReactorMaximumSentMessages)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.ReactorMaximumSentMessages = Bridge.GetExternal<System.UInt16>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "MaxPacketSize",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.MaxPacketSize)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.MaxPacketSize = Bridge.GetExternal<System.UInt16>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "MaxHosts",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.MaxHosts)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.MaxHosts = Bridge.GetExternal<System.UInt16>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "ThreadPoolSize",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.ThreadPoolSize)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.ThreadPoolSize = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "MinTimerTimeout",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.MinTimerTimeout)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.MinTimerTimeout = Bridge.GetExternal<System.UInt32>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "MaxTimerTimeout",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.MaxTimerTimeout)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.MaxTimerTimeout = Bridge.GetExternal<System.UInt32>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "MinNetSimulatorTimeout",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.MinNetSimulatorTimeout)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.MinNetSimulatorTimeout = Bridge.GetExternal<System.UInt32>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        GlobalConfigPrototype,
        "MaxNetSimulatorTimeout",
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => Bridge.CreateExternalWithPrototype(o.MaxNetSimulatorTimeout)),
        WithExternal<UnityEngine.Networking.GlobalConfig>((o, args) => { o.MaxNetSimulatorTimeout = Bridge.GetExternal<System.UInt32>(args[1]); })
      );


      /*
        GlobalConfig NetworkEventAvailable
        System.Action`1[System.Int32] has generics
      */


      /*
        GlobalConfig ConnectionReadyForSend
        System.Action`2[System.Int32,System.Int32] has generics
      */


      // Instance Methods

    }
  }
}
