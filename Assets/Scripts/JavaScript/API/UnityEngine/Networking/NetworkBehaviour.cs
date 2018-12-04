using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkBehaviour {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkBehaviourPrototype;
      JavaScriptValue NetworkBehaviourConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkBehaviour),
        (args) => { throw new NotImplementedException(); },
        out NetworkBehaviourPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkBehaviour", NetworkBehaviourConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "localPlayerAuthority",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.localPlayerAuthority))
      );


      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "isServer",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.isServer))
      );


      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "isClient",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.isClient))
      );


      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "isLocalPlayer",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.isLocalPlayer))
      );


      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "hasAuthority",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.hasAuthority))
      );


      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "netId",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => Bridge.CreateExternalWithPrototype(o.netId))
      );


      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "connectionToServer",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => Bridge.CreateExternalWithPrototype(o.connectionToServer))
      );


      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "connectionToClient",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => Bridge.CreateExternalWithPrototype(o.connectionToClient))
      );


      Bridge.DefineGetter(
        NetworkBehaviourPrototype,
        "playerControllerId",
        WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => Bridge.CreateExternalWithPrototype(o.playerControllerId))
      );


      // Instance Methods

      NetworkBehaviourPrototype.SetProperty(
        "InvokeCommand",
        Bridge.CreateFunction(
          "InvokeCommand",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.InvokeCommand(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[2]))))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "InvokeRPC",
        Bridge.CreateFunction(
          "InvokeRPC",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.InvokeRPC(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[2]))))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "InvokeSyncEvent",
        Bridge.CreateFunction(
          "InvokeSyncEvent",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.InvokeSyncEvent(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[2]))))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "InvokeSyncList",
        Bridge.CreateFunction(
          "InvokeSyncList",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.InvokeSyncList(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[2]))))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "SetDirtyBit",
        Bridge.CreateFunction(
          "SetDirtyBit",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.SetDirtyBit(Bridge.GetExternal<System.UInt32>(args[1])))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "ClearAllDirtyBits",
        Bridge.CreateFunction(
          "ClearAllDirtyBits",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.ClearAllDirtyBits())
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnSerialize",
        Bridge.CreateFunction(
          "OnSerialize",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.OnSerialize(Bridge.GetExternal<UnityEngine.Networking.NetworkWriter>(args[1]), args[2].ToBoolean())))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnDeserialize",
        Bridge.CreateFunction(
          "OnDeserialize",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.OnDeserialize(Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[1]), args[2].ToBoolean()))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "PreStartClient",
        Bridge.CreateFunction(
          "PreStartClient",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.PreStartClient())
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnNetworkDestroy",
        Bridge.CreateFunction(
          "OnNetworkDestroy",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.OnNetworkDestroy())
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnStartServer",
        Bridge.CreateFunction(
          "OnStartServer",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.OnStartServer())
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnStartClient",
        Bridge.CreateFunction(
          "OnStartClient",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.OnStartClient())
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnStartLocalPlayer",
        Bridge.CreateFunction(
          "OnStartLocalPlayer",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.OnStartLocalPlayer())
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnStartAuthority",
        Bridge.CreateFunction(
          "OnStartAuthority",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.OnStartAuthority())
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnStopAuthority",
        Bridge.CreateFunction(
          "OnStopAuthority",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.OnStopAuthority())
        )
      );


      /*
        NetworkBehaviour OnRebuildObservers
        System.Collections.Generic.HashSet`1[UnityEngine.Networking.NetworkConnection] has generics
      */


      NetworkBehaviourPrototype.SetProperty(
        "OnSetLocalVisibility",
        Bridge.CreateFunction(
          "OnSetLocalVisibility",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => o.OnSetLocalVisibility(args[1].ToBoolean()))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "OnCheckObserver",
        Bridge.CreateFunction(
          "OnCheckObserver",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.OnCheckObserver(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]))))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "GetNetworkChannel",
        Bridge.CreateFunction(
          "GetNetworkChannel",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromInt32(o.GetNetworkChannel()))
        )
      );


      NetworkBehaviourPrototype.SetProperty(
        "GetNetworkSendInterval",
        Bridge.CreateFunction(
          "GetNetworkSendInterval",
          WithExternal<UnityEngine.Networking.NetworkBehaviour>((o, args) => JavaScriptValue.FromDouble(o.GetNetworkSendInterval()))
        )
      );


    }
  }
}
