using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkHash128 {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkHash128Prototype;
      JavaScriptValue NetworkHash128Constructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkHash128),
        (args) => { throw new NotImplementedException(); },
        out NetworkHash128Prototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkHash128", NetworkHash128Constructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      NetworkHash128Constructor.SetProperty(
        "Parse",
        Bridge.CreateFunction(
          "Parse",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkHash128.Parse(args[1].ToString()))
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i0",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i0)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i0 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i1",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i1)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i1 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i2",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i2)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i2 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i3",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i3)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i3 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i4",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i4)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i4 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i5",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i5)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i5 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i6",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i6)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i6 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i7",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i7)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i7 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i8",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i8)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i8 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i9",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i9)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i9 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i10",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i10)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i10 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i11",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i11)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i11 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i12",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i12)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i12 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i13",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i13)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i13 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i14",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i14)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i14 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkHash128Prototype,
        "i15",
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => Bridge.CreateExternalWithPrototype(o.i15)),
        WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => { o.i15 = Bridge.GetExternal<System.Byte>(args[1]); })
      );


      // Instance Property Accessors


      // Instance Methods

      NetworkHash128Prototype.SetProperty(
        "Reset",
        Bridge.CreateFunction(
          "Reset",
          WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => o.Reset())
        )
      );


      NetworkHash128Prototype.SetProperty(
        "IsValid",
        Bridge.CreateFunction(
          "IsValid",
          WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => JavaScriptValue.FromBoolean(o.IsValid()))
        )
      );


      NetworkHash128Prototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          WithExternal<UnityEngine.Networking.NetworkHash128>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


    }
  }
}
