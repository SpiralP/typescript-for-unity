using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkAnimator {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkAnimatorPrototype;
      JavaScriptValue NetworkAnimatorConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkAnimator),
        (args) => { throw new NotImplementedException(); },
        out NetworkAnimatorPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkAnimator", NetworkAnimatorConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields

      Bridge.DefineGetterSetter(
        NetworkAnimatorPrototype,
        "param0",
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => JavaScriptValue.FromString(o.param0)),
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => { o.param0 = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkAnimatorPrototype,
        "param1",
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => JavaScriptValue.FromString(o.param1)),
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => { o.param1 = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkAnimatorPrototype,
        "param2",
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => JavaScriptValue.FromString(o.param2)),
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => { o.param2 = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkAnimatorPrototype,
        "param3",
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => JavaScriptValue.FromString(o.param3)),
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => { o.param3 = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkAnimatorPrototype,
        "param4",
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => JavaScriptValue.FromString(o.param4)),
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => { o.param4 = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkAnimatorPrototype,
        "param5",
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => JavaScriptValue.FromString(o.param5)),
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => { o.param5 = args[1].ToString(); })
      );


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        NetworkAnimatorPrototype,
        "animator",
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => Bridge.CreateExternalWithPrototype(o.animator)),
        WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => { o.animator = Bridge.GetExternal<UnityEngine.Animator>(args[1]); })
      );


      // Instance Methods

      NetworkAnimatorPrototype.SetProperty(
        "SetParameterAutoSend",
        Bridge.CreateFunction(
          "SetParameterAutoSend",
          WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => o.SetParameterAutoSend(args[1].ToInt32(), args[2].ToBoolean()))
        )
      );


      NetworkAnimatorPrototype.SetProperty(
        "GetParameterAutoSend",
        Bridge.CreateFunction(
          "GetParameterAutoSend",
          WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => JavaScriptValue.FromBoolean(o.GetParameterAutoSend(args[1].ToInt32())))
        )
      );


      NetworkAnimatorPrototype.SetProperty(
        "OnSerialize",
        Bridge.CreateFunction(
          "OnSerialize",
          WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => JavaScriptValue.FromBoolean(o.OnSerialize(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), args[2].ToBoolean())))
        )
      );


      NetworkAnimatorPrototype.SetProperty(
        "OnDeserialize",
        Bridge.CreateFunction(
          "OnDeserialize",
          WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => o.OnDeserialize(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), args[2].ToBoolean()))
        )
      );


      NetworkAnimatorPrototype.SetProperty(
        "SetTrigger",
        Bridge.CreateFunction(
          "SetTrigger",
          WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => o.SetTrigger(args[1].ToString()))
        )
      );


      NetworkAnimatorPrototype.SetProperty(
        "SetTrigger",
        Bridge.CreateFunction(
          "SetTrigger",
          WithExternal<UnityEngine.Networking.NetworkAnimator>((o, args) => o.SetTrigger(args[1].ToInt32()))
        )
      );


    }
  }
}
