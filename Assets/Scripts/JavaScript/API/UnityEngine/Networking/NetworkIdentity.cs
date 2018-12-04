using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkIdentity {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkIdentityPrototype;
      JavaScriptValue NetworkIdentityConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkIdentity),
        (args) => { throw new NotImplementedException(); },
        out NetworkIdentityPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkIdentity", NetworkIdentityConstructor);


      // Static Fields

      Bridge.DefineGetterSetter(
        NetworkIdentityConstructor,
        "clientAuthorityCallback",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkIdentity.clientAuthorityCallback),
        (args) => { UnityEngine.Networking.NetworkIdentity.clientAuthorityCallback = Bridge.GetExternal<UnityEngine.Networking.NetworkIdentity.ClientAuthorityCallback>(args[1]); }
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "isClient",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => JavaScriptValue.FromBoolean(o.isClient))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "isServer",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => JavaScriptValue.FromBoolean(o.isServer))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "hasAuthority",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => JavaScriptValue.FromBoolean(o.hasAuthority))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "netId",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => Bridge.CreateExternalWithPrototype(o.netId))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "sceneId",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => Bridge.CreateExternalWithPrototype(o.sceneId))
      );


      Bridge.DefineGetterSetter(
        NetworkIdentityPrototype,
        "serverOnly",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => JavaScriptValue.FromBoolean(o.serverOnly)),
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => { o.serverOnly = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkIdentityPrototype,
        "localPlayerAuthority",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => JavaScriptValue.FromBoolean(o.localPlayerAuthority)),
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => { o.localPlayerAuthority = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "clientAuthorityOwner",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => Bridge.CreateExternalWithPrototype(o.clientAuthorityOwner))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "assetId",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => Bridge.CreateExternalWithPrototype(o.assetId))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "isLocalPlayer",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => JavaScriptValue.FromBoolean(o.isLocalPlayer))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "playerControllerId",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => Bridge.CreateExternalWithPrototype(o.playerControllerId))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "connectionToServer",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => Bridge.CreateExternalWithPrototype(o.connectionToServer))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "connectionToClient",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => Bridge.CreateExternalWithPrototype(o.connectionToClient))
      );


      Bridge.DefineGetter(
        NetworkIdentityPrototype,
        "observers",
        WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => Bridge.CreateExternalWithPrototype(o.observers))
      );


      // Instance Methods

      NetworkIdentityPrototype.SetProperty(
        "ForceSceneId",
        Bridge.CreateFunction(
          "ForceSceneId",
          WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => o.ForceSceneId(args[1].ToInt32()))
        )
      );


      NetworkIdentityPrototype.SetProperty(
        "RebuildObservers",
        Bridge.CreateFunction(
          "RebuildObservers",
          WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => o.RebuildObservers(args[1].ToBoolean()))
        )
      );


      NetworkIdentityPrototype.SetProperty(
        "RemoveClientAuthority",
        Bridge.CreateFunction(
          "RemoveClientAuthority",
          WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => JavaScriptValue.FromBoolean(o.RemoveClientAuthority(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]))))
        )
      );


      NetworkIdentityPrototype.SetProperty(
        "AssignClientAuthority",
        Bridge.CreateFunction(
          "AssignClientAuthority",
          WithExternal<UnityEngine.Networking.NetworkIdentity>((o, args) => JavaScriptValue.FromBoolean(o.AssignClientAuthority(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]))))
        )
      );


    }
  }
}
