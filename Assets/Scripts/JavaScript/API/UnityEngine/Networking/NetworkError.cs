using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkError {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkErrorPrototype;
      JavaScriptValue NetworkErrorConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkError),
        (args) => { throw new NotImplementedException(); },
        out NetworkErrorPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkError", NetworkErrorConstructor);


      // Static Fields

      NetworkErrorConstructor.SetProperty(
        "Ok",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.Ok)
      );


      NetworkErrorConstructor.SetProperty(
        "WrongHost",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.WrongHost)
      );


      NetworkErrorConstructor.SetProperty(
        "WrongConnection",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.WrongConnection)
      );


      NetworkErrorConstructor.SetProperty(
        "WrongChannel",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.WrongChannel)
      );


      NetworkErrorConstructor.SetProperty(
        "NoResources",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.NoResources)
      );


      NetworkErrorConstructor.SetProperty(
        "BadMessage",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.BadMessage)
      );


      NetworkErrorConstructor.SetProperty(
        "Timeout",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.Timeout)
      );


      NetworkErrorConstructor.SetProperty(
        "MessageToLong",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.MessageToLong)
      );


      NetworkErrorConstructor.SetProperty(
        "WrongOperation",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.WrongOperation)
      );


      NetworkErrorConstructor.SetProperty(
        "VersionMismatch",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.VersionMismatch)
      );


      NetworkErrorConstructor.SetProperty(
        "CRCMismatch",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.CRCMismatch)
      );


      NetworkErrorConstructor.SetProperty(
        "DNSFailure",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.DNSFailure)
      );


      NetworkErrorConstructor.SetProperty(
        "UsageError",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkError.UsageError)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
