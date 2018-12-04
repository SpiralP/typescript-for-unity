using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkTransform {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkTransformPrototype;
      JavaScriptValue NetworkTransformConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkTransform),
        (args) => { throw new NotImplementedException(); },
        out NetworkTransformPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkTransform", NetworkTransformConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      NetworkTransformConstructor.SetProperty(
        "HandleTransform",
        Bridge.CreateFunction(
          "HandleTransform",
          (args) => UnityEngine.Networking.NetworkTransform.HandleTransform(Bridge.GetExternal<UnityEngine.Networking.NetworkMessage>(args[1]))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "SerializeVelocity3D",
        Bridge.CreateFunction(
          "SerializeVelocity3D",
          (args) => UnityEngine.Networking.NetworkTransform.SerializeVelocity3D(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), Bridge.GetExternal<UnityEngine.Vector3>(args[2]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[3]))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "SerializeVelocity2D",
        Bridge.CreateFunction(
          "SerializeVelocity2D",
          (args) => UnityEngine.Networking.NetworkTransform.SerializeVelocity2D(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), Bridge.GetExternal<UnityEngine.Vector2>(args[2]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[3]))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "SerializeRotation3D",
        Bridge.CreateFunction(
          "SerializeRotation3D",
          (args) => UnityEngine.Networking.NetworkTransform.SerializeRotation3D(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), Bridge.GetExternal<UnityEngine.Quaternion>(args[2]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.AxisSyncMode>(args[3]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[4]))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "SerializeRotation2D",
        Bridge.CreateFunction(
          "SerializeRotation2D",
          (args) => UnityEngine.Networking.NetworkTransform.SerializeRotation2D(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[3]))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "SerializeSpin3D",
        Bridge.CreateFunction(
          "SerializeSpin3D",
          (args) => UnityEngine.Networking.NetworkTransform.SerializeSpin3D(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), Bridge.GetExternal<UnityEngine.Vector3>(args[2]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.AxisSyncMode>(args[3]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[4]))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "SerializeSpin2D",
        Bridge.CreateFunction(
          "SerializeSpin2D",
          (args) => UnityEngine.Networking.NetworkTransform.SerializeSpin2D(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[3]))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "UnserializeVelocity3D",
        Bridge.CreateFunction(
          "UnserializeVelocity3D",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkTransform.UnserializeVelocity3D(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[2])))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "UnserializeVelocity2D",
        Bridge.CreateFunction(
          "UnserializeVelocity2D",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkTransform.UnserializeVelocity2D(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[2])))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "UnserializeRotation3D",
        Bridge.CreateFunction(
          "UnserializeRotation3D",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkTransform.UnserializeRotation3D(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.AxisSyncMode>(args[2]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[3])))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "UnserializeRotation2D",
        Bridge.CreateFunction(
          "UnserializeRotation2D",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Networking.NetworkTransform.UnserializeRotation2D(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[2])))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "UnserializeSpin3D",
        Bridge.CreateFunction(
          "UnserializeSpin3D",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkTransform.UnserializeSpin3D(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.AxisSyncMode>(args[2]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[3])))
        )
      );


      NetworkTransformConstructor.SetProperty(
        "UnserializeSpin2D",
        Bridge.CreateFunction(
          "UnserializeSpin2D",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Networking.NetworkTransform.UnserializeSpin2D(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[2])))
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "transformSyncMode",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.transformSyncMode)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.transformSyncMode = Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.TransformSyncMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "sendInterval",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.sendInterval)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.sendInterval = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "syncRotationAxis",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.syncRotationAxis)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.syncRotationAxis = Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.AxisSyncMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "rotationSyncCompression",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.rotationSyncCompression)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.rotationSyncCompression = Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.CompressionSyncMode>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "syncSpin",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromBoolean(o.syncSpin)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.syncSpin = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "movementTheshold",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.movementTheshold)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.movementTheshold = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "velocityThreshold",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.velocityThreshold)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.velocityThreshold = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "snapThreshold",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.snapThreshold)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.snapThreshold = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "interpolateRotation",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.interpolateRotation)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.interpolateRotation = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "interpolateMovement",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.interpolateMovement)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.interpolateMovement = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "clientMoveCallback3D",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.clientMoveCallback3D)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.clientMoveCallback3D = Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.ClientMoveCallback3D>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "clientMoveCallback2D",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.clientMoveCallback2D)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.clientMoveCallback2D = Bridge.GetExternal<UnityEngine.Networking.NetworkTransform.ClientMoveCallback2D>(args[1]); })
      );


      Bridge.DefineGetter(
        NetworkTransformPrototype,
        "characterContoller",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.characterContoller))
      );


      Bridge.DefineGetter(
        NetworkTransformPrototype,
        "rigidbody3D",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.rigidbody3D))
      );


      Bridge.DefineGetter(
        NetworkTransformPrototype,
        "rigidbody2D",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.rigidbody2D))
      );


      Bridge.DefineGetter(
        NetworkTransformPrototype,
        "lastSyncTime",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.lastSyncTime))
      );


      Bridge.DefineGetter(
        NetworkTransformPrototype,
        "targetSyncPosition",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.targetSyncPosition))
      );


      Bridge.DefineGetter(
        NetworkTransformPrototype,
        "targetSyncVelocity",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.targetSyncVelocity))
      );


      Bridge.DefineGetter(
        NetworkTransformPrototype,
        "targetSyncRotation3D",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => Bridge.CreateExternalWithPrototype(o.targetSyncRotation3D))
      );


      Bridge.DefineGetter(
        NetworkTransformPrototype,
        "targetSyncRotation2D",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.targetSyncRotation2D))
      );


      Bridge.DefineGetterSetter(
        NetworkTransformPrototype,
        "grounded",
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromBoolean(o.grounded)),
        WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => { o.grounded = args[1].ToBoolean(); })
      );


      // Instance Methods

      NetworkTransformPrototype.SetProperty(
        "OnStartServer",
        Bridge.CreateFunction(
          "OnStartServer",
          WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => o.OnStartServer())
        )
      );


      NetworkTransformPrototype.SetProperty(
        "OnSerialize",
        Bridge.CreateFunction(
          "OnSerialize",
          WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromBoolean(o.OnSerialize(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), args[2].ToBoolean())))
        )
      );


      NetworkTransformPrototype.SetProperty(
        "OnDeserialize",
        Bridge.CreateFunction(
          "OnDeserialize",
          WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => o.OnDeserialize(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), args[2].ToBoolean()))
        )
      );


      NetworkTransformPrototype.SetProperty(
        "GetNetworkChannel",
        Bridge.CreateFunction(
          "GetNetworkChannel",
          WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromInt32(o.GetNetworkChannel()))
        )
      );


      NetworkTransformPrototype.SetProperty(
        "GetNetworkSendInterval",
        Bridge.CreateFunction(
          "GetNetworkSendInterval",
          WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => JavaScriptValue.FromDouble(o.GetNetworkSendInterval()))
        )
      );


      NetworkTransformPrototype.SetProperty(
        "OnStartAuthority",
        Bridge.CreateFunction(
          "OnStartAuthority",
          WithExternal<UnityEngine.Networking.NetworkTransform>((o, args) => o.OnStartAuthority())
        )
      );


    }
  }
}
