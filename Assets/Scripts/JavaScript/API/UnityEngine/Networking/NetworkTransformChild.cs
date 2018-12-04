using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkTransformChild {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkTransformChildPrototype;
      JavaScriptValue NetworkTransformChildConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkTransformChild),
        (args) => { throw new NotImplementedException(); },
        out NetworkTransformChildPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkTransformChild", NetworkTransformChildConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        NetworkTransformChildPrototype,
        "target",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => Bridge.CreateExternalWithPrototype(o.target)),
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => { o.target = Bridge.GetExternal<UnityEngine.Transform>(args[1]); })
      );


      Bridge.DefineGetter(
        NetworkTransformChildPrototype,
        "childIndex",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => Bridge.CreateExternalWithPrototype(o.childIndex))
      );


      Bridge.DefineGetterSetter(
        NetworkTransformChildPrototype,
        "sendInterval",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => JavaScriptValue.FromDouble(o.sendInterval)),
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => { o.sendInterval = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformChildPrototype,
        "syncRotationAxis",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => Bridge.CreateExternalWithPrototype(o.syncRotationAxis)),
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => { o.syncRotationAxis = Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.AxisSyncMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformChildPrototype,
        "rotationSyncCompression",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => Bridge.CreateExternalWithPrototype(o.rotationSyncCompression)),
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => { o.rotationSyncCompression = Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformChildPrototype,
        "movementThreshold",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => JavaScriptValue.FromDouble(o.movementThreshold)),
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => { o.movementThreshold = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformChildPrototype,
        "interpolateRotation",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => JavaScriptValue.FromDouble(o.interpolateRotation)),
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => { o.interpolateRotation = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformChildPrototype,
        "interpolateMovement",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => JavaScriptValue.FromDouble(o.interpolateMovement)),
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => { o.interpolateMovement = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformChildPrototype,
        "clientMoveCallback3D",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => Bridge.CreateExternalWithPrototype(o.clientMoveCallback3D)),
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => { o.clientMoveCallback3D = Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.ClientMoveCallback3D>(args[1]); })
      );


      Bridge.DefineGetter(
        NetworkTransformChildPrototype,
        "lastSyncTime",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => JavaScriptValue.FromDouble(o.lastSyncTime))
      );


      Bridge.DefineGetter(
        NetworkTransformChildPrototype,
        "targetSyncPosition",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => Bridge.CreateExternalWithPrototype(o.targetSyncPosition))
      );


      Bridge.DefineGetter(
        NetworkTransformChildPrototype,
        "targetSyncRotation3D",
        WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => Bridge.CreateExternalWithPrototype(o.targetSyncRotation3D))
      );


      // Instance Methods

      NetworkTransformChildPrototype.SetProperty(
        "OnSerialize",
        Bridge.CreateFunction(
          "OnSerialize",
          WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => JavaScriptValue.FromBoolean(o.OnSerialize(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), args[2].ToBoolean())))
        )
      );


      NetworkTransformChildPrototype.SetProperty(
        "OnDeserialize",
        Bridge.CreateFunction(
          "OnDeserialize",
          WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => o.OnDeserialize(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), args[2].ToBoolean()))
        )
      );


      NetworkTransformChildPrototype.SetProperty(
        "GetNetworkChannel",
        Bridge.CreateFunction(
          "GetNetworkChannel",
          WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => JavaScriptValue.FromInt32(o.GetNetworkChannel()))
        )
      );


      NetworkTransformChildPrototype.SetProperty(
        "GetNetworkSendInterval",
        Bridge.CreateFunction(
          "GetNetworkSendInterval",
          WithExternal<UnityEngine.Networking.NetworkTransformChild>((o, args) => JavaScriptValue.FromDouble(o.GetNetworkSendInterval()))
        )
      );


    }
  }
}
