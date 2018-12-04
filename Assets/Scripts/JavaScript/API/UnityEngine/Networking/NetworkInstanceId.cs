using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkInstanceId {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkInstanceIdPrototype;
      JavaScriptValue NetworkInstanceIdConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkInstanceId),
        (args) => { throw new NotImplementedException(); },
        out NetworkInstanceIdPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkInstanceId", NetworkInstanceIdConstructor);


      // Static Fields

      Bridge.DefineGetterSetter(
        NetworkInstanceIdConstructor,
        "Invalid",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkInstanceId.Invalid),
        (args) => { UnityEngine.Networking.NetworkInstanceId.Invalid = Bridge.GetExternal<UnityEngine.Networking.NetworkInstanceId>(args[1]); }
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        NetworkInstanceIdPrototype,
        "Value",
        WithExternal<UnityEngine.Networking.NetworkInstanceId>((o, args) => Bridge.CreateExternalWithPrototype(o.Value))
      );


      // Instance Methods

      NetworkInstanceIdPrototype.SetProperty(
        "IsEmpty",
        Bridge.CreateFunction(
          "IsEmpty",
          WithExternal<UnityEngine.Networking.NetworkInstanceId>((o, args) => JavaScriptValue.FromBoolean(o.IsEmpty()))
        )
      );


      NetworkInstanceIdPrototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          WithExternal<UnityEngine.Networking.NetworkInstanceId>((o, args) => JavaScriptValue.FromInt32(o.GetHashCode()))
        )
      );


      NetworkInstanceIdPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          WithExternal<UnityEngine.Networking.NetworkInstanceId>((o, args) => JavaScriptValue.FromBoolean(o.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      NetworkInstanceIdPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          WithExternal<UnityEngine.Networking.NetworkInstanceId>((o, args) => JavaScriptValue.FromBoolean(o.Equals(Bridge.GetExternal<UnityEngine.Networking.NetworkInstanceId>(args[1]))))
        )
      );


      NetworkInstanceIdPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          WithExternal<UnityEngine.Networking.NetworkInstanceId>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


    }
  }
}
