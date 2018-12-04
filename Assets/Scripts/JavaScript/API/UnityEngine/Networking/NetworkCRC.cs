using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkCRC {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkCRCPrototype;
      JavaScriptValue NetworkCRCConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkCRC),
        (args) => { throw new NotImplementedException(); },
        out NetworkCRCPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkCRC", NetworkCRCConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetterSetter(
        NetworkCRCConstructor,
        "scriptCRCCheck",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Networking.NetworkCRC.scriptCRCCheck),
        (args) => { UnityEngine.Networking.NetworkCRC.scriptCRCCheck = args[1].ToBoolean(); }
      );


      // Static Methods

      NetworkCRCConstructor.SetProperty(
        "ReinitializeScriptCRCs",
        Bridge.CreateFunction(
          "ReinitializeScriptCRCs",
          (args) => UnityEngine.Networking.NetworkCRC.ReinitializeScriptCRCs(Bridge.GetExternal<System.Reflection.Assembly>(args[1]))
        )
      );


      NetworkCRCConstructor.SetProperty(
        "RegisterBehaviour",
        Bridge.CreateFunction(
          "RegisterBehaviour",
          (args) => UnityEngine.Networking.NetworkCRC.RegisterBehaviour(args[1].ToString(), args[2].ToInt32())
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        NetworkCRCPrototype,
        "scripts",
        WithExternal<UnityEngine.Networking.NetworkCRC>((o, args) => Bridge.CreateExternalWithPrototype(o.scripts))
      );


      // Instance Methods

    }
  }
}
