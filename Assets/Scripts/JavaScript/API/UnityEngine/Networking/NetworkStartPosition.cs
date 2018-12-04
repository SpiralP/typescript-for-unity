using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkStartPosition {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkStartPositionPrototype;
      JavaScriptValue NetworkStartPositionConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkStartPosition),
        (args) => { throw new NotImplementedException(); },
        out NetworkStartPositionPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkStartPosition", NetworkStartPositionConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

      NetworkStartPositionPrototype.SetProperty(
        "Awake",
        Bridge.CreateFunction(
          "Awake",
          WithExternal<UnityEngine.Networking.NetworkStartPosition>((o, args) => o.Awake())
        )
      );


      NetworkStartPositionPrototype.SetProperty(
        "OnDestroy",
        Bridge.CreateFunction(
          "OnDestroy",
          WithExternal<UnityEngine.Networking.NetworkStartPosition>((o, args) => o.OnDestroy())
        )
      );


    }
  }
}
