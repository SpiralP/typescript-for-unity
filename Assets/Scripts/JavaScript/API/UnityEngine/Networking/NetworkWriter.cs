using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkWriter {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkWriterPrototype;
      JavaScriptValue NetworkWriterConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkWriter),
        (args) => { throw new NotImplementedException(); },
        out NetworkWriterPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkWriter", NetworkWriterConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        NetworkWriterPrototype,
        "Position",
        WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => Bridge.CreateExternalWithPrototype(o.Position))
      );


      // Instance Methods

      NetworkWriterPrototype.SetProperty(
        "ToArray",
        Bridge.CreateFunction(
          "ToArray",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => Bridge.CreateExternalWithPrototype(o.ToArray()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "AsArray",
        Bridge.CreateFunction(
          "AsArray",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => Bridge.CreateExternalWithPrototype(o.AsArray()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "WritePackedUInt32",
        Bridge.CreateFunction(
          "WritePackedUInt32",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.WritePackedUInt32(Bridge.GetExternal<System.UInt32>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "WritePackedUInt64",
        Bridge.CreateFunction(
          "WritePackedUInt64",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.WritePackedUInt64(Bridge.GetExternal<System.UInt64>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Networking.NetworkInstanceId>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Networking.NetworkSceneId>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.Char>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.Byte>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.SByte>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.Int16>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.UInt16>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(args[1].ToInt32()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.UInt32>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.Int64>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.UInt64>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write((float) args[1].ToDouble()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(args[1].ToDouble()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.Decimal>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(args[1].ToString()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(args[1].ToBoolean()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.Byte[]>(args[1]), args[2].ToInt32()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<System.Byte[]>(args[1]), args[2].ToInt32(), args[3].ToInt32()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "WriteBytesAndSize",
        Bridge.CreateFunction(
          "WriteBytesAndSize",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.WriteBytesAndSize(Bridge.GetExternal<System.Byte[]>(args[1]), args[2].ToInt32()))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "WriteBytesFull",
        Bridge.CreateFunction(
          "WriteBytesFull",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.WriteBytesFull(Bridge.GetExternal<System.Byte[]>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Vector2>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Vector3>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Vector4>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Color>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Color32>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Quaternion>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Rect>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Plane>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Ray>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Matrix4x4>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Networking.NetworkHash128>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Networking.NetworkIdentity>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Transform>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.GameObject>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "Write",
        Bridge.CreateFunction(
          "Write",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.Write(Bridge.GetExternal<UnityEngine.Networking.MessageBase>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "SeekZero",
        Bridge.CreateFunction(
          "SeekZero",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.SeekZero())
        )
      );


      NetworkWriterPrototype.SetProperty(
        "StartMessage",
        Bridge.CreateFunction(
          "StartMessage",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.StartMessage(Bridge.GetExternal<System.Int16>(args[1])))
        )
      );


      NetworkWriterPrototype.SetProperty(
        "FinishMessage",
        Bridge.CreateFunction(
          "FinishMessage",
          WithExternal<UnityEngine.Networking.NetworkWriter>((o, args) => o.FinishMessage())
        )
      );


    }
  }
}
