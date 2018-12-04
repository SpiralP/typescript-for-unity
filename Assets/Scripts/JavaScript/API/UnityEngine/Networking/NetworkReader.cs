using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkReader {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkReaderPrototype;
      JavaScriptValue NetworkReaderConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkReader),
        (args) => { throw new NotImplementedException(); },
        out NetworkReaderPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkReader", NetworkReaderConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        NetworkReaderPrototype,
        "Position",
        WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.Position))
      );


      Bridge.DefineGetter(
        NetworkReaderPrototype,
        "Length",
        WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => JavaScriptValue.FromInt32(o.Length))
      );


      // Instance Methods

      NetworkReaderPrototype.SetProperty(
        "SeekZero",
        Bridge.CreateFunction(
          "SeekZero",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => o.SeekZero())
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadPackedUInt32",
        Bridge.CreateFunction(
          "ReadPackedUInt32",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadPackedUInt32()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadPackedUInt64",
        Bridge.CreateFunction(
          "ReadPackedUInt64",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadPackedUInt64()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadNetworkId",
        Bridge.CreateFunction(
          "ReadNetworkId",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadNetworkId()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadSceneId",
        Bridge.CreateFunction(
          "ReadSceneId",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadSceneId()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadByte",
        Bridge.CreateFunction(
          "ReadByte",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadByte()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadSByte",
        Bridge.CreateFunction(
          "ReadSByte",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadSByte()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadInt16",
        Bridge.CreateFunction(
          "ReadInt16",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadInt16()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadUInt16",
        Bridge.CreateFunction(
          "ReadUInt16",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadUInt16()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadInt32",
        Bridge.CreateFunction(
          "ReadInt32",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => JavaScriptValue.FromInt32(o.ReadInt32()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadUInt32",
        Bridge.CreateFunction(
          "ReadUInt32",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadUInt32()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadInt64",
        Bridge.CreateFunction(
          "ReadInt64",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadInt64()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadUInt64",
        Bridge.CreateFunction(
          "ReadUInt64",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadUInt64()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadDecimal",
        Bridge.CreateFunction(
          "ReadDecimal",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadDecimal()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadSingle",
        Bridge.CreateFunction(
          "ReadSingle",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => JavaScriptValue.FromDouble(o.ReadSingle()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadDouble",
        Bridge.CreateFunction(
          "ReadDouble",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => JavaScriptValue.FromDouble(o.ReadDouble()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadString",
        Bridge.CreateFunction(
          "ReadString",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => JavaScriptValue.FromString(o.ReadString()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadChar",
        Bridge.CreateFunction(
          "ReadChar",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadChar()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadBoolean",
        Bridge.CreateFunction(
          "ReadBoolean",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => JavaScriptValue.FromBoolean(o.ReadBoolean()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadBytes",
        Bridge.CreateFunction(
          "ReadBytes",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadBytes(args[1].ToInt32())))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadBytesAndSize",
        Bridge.CreateFunction(
          "ReadBytesAndSize",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadBytesAndSize()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadVector2",
        Bridge.CreateFunction(
          "ReadVector2",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadVector2()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadVector3",
        Bridge.CreateFunction(
          "ReadVector3",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadVector3()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadVector4",
        Bridge.CreateFunction(
          "ReadVector4",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadVector4()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadColor",
        Bridge.CreateFunction(
          "ReadColor",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadColor()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadColor32",
        Bridge.CreateFunction(
          "ReadColor32",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadColor32()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadQuaternion",
        Bridge.CreateFunction(
          "ReadQuaternion",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadQuaternion()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadRect",
        Bridge.CreateFunction(
          "ReadRect",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadRect()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadPlane",
        Bridge.CreateFunction(
          "ReadPlane",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadPlane()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadRay",
        Bridge.CreateFunction(
          "ReadRay",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadRay()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadMatrix4x4",
        Bridge.CreateFunction(
          "ReadMatrix4x4",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadMatrix4x4()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadNetworkHash128",
        Bridge.CreateFunction(
          "ReadNetworkHash128",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadNetworkHash128()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadTransform",
        Bridge.CreateFunction(
          "ReadTransform",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadTransform()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadGameObject",
        Bridge.CreateFunction(
          "ReadGameObject",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadGameObject()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "ReadNetworkIdentity",
        Bridge.CreateFunction(
          "ReadNetworkIdentity",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => Bridge.CreateExternalWithPrototype(o.ReadNetworkIdentity()))
        )
      );


      NetworkReaderPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          WithExternal<UnityEngine.Networking.NetworkReader>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


      /*
        NetworkReader ReadMessage
        method has generics
      */


    }
  }
}
