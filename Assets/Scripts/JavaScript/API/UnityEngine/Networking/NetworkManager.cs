using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSNetworkManager {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue NetworkManagerPrototype;
      JavaScriptValue NetworkManagerConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.NetworkManager),
        (args) => { throw new NotImplementedException(); },
        out NetworkManagerPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("NetworkManager", NetworkManagerConstructor);


      // Static Fields

      Bridge.DefineGetterSetter(
        NetworkManagerConstructor,
        "networkSceneName",
        (args) => JavaScriptValue.FromString(UnityEngine.Networking.NetworkManager.networkSceneName),
        (args) => { UnityEngine.Networking.NetworkManager.networkSceneName = args[1].ToString(); }
      );


      Bridge.DefineGetterSetter(
        NetworkManagerConstructor,
        "singleton",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Networking.NetworkManager.singleton),
        (args) => { UnityEngine.Networking.NetworkManager.singleton = Bridge.GetExternal<UnityEngine.Networking.NetworkManager>(args[1]); }
      );


      // Static Property Accessors


      // Static Methods

      NetworkManagerConstructor.SetProperty(
        "RegisterStartPosition",
        Bridge.CreateFunction(
          "RegisterStartPosition",
          (args) => UnityEngine.Networking.NetworkManager.RegisterStartPosition(Bridge.GetExternal<UnityEngine.Transform>(args[1]))
        )
      );


      NetworkManagerConstructor.SetProperty(
        "UnRegisterStartPosition",
        Bridge.CreateFunction(
          "UnRegisterStartPosition",
          (args) => UnityEngine.Networking.NetworkManager.UnRegisterStartPosition(Bridge.GetExternal<UnityEngine.Transform>(args[1]))
        )
      );


      NetworkManagerConstructor.SetProperty(
        "Shutdown",
        Bridge.CreateFunction(
          "Shutdown",
          (args) => UnityEngine.Networking.NetworkManager.Shutdown()
        )
      );


      // Instance Fields

      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "matchName",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromString(o.matchName)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.matchName = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "matchSize",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.matchSize)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.matchSize = Bridge.GetExternal<System.UInt32>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "isNetworkActive",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.isNetworkActive)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.isNetworkActive = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "client",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.client)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.client = Bridge.GetExternal<UnityEngine.Networking.NetworkClient>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "matchInfo",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.matchInfo)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.matchInfo = Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "matchMaker",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.matchMaker)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.matchMaker = Bridge.GetExternal<UnityEngine.Networking.Match.NetworkMatch>(args[1]); })
      );


      /*
        NetworkManager matches
        System.Collections.Generic.List`1[UnityEngine.Networking.Match.MatchInfoSnapshot] has generics
      */


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "networkPort",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromInt32(o.networkPort)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.networkPort = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "serverBindToIP",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.serverBindToIP)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.serverBindToIP = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "serverBindAddress",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromString(o.serverBindAddress)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.serverBindAddress = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "networkAddress",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromString(o.networkAddress)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.networkAddress = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "dontDestroyOnLoad",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.dontDestroyOnLoad)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.dontDestroyOnLoad = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "runInBackground",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.runInBackground)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.runInBackground = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "scriptCRCCheck",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.scriptCRCCheck)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.scriptCRCCheck = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "maxDelay",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromDouble(o.maxDelay)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.maxDelay = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "logLevel",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.logLevel)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.logLevel = Bridge.GetExternal<UnityEngine.Networking.LogFilter.FilterLevel>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "playerPrefab",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.playerPrefab)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.playerPrefab = Bridge.GetExternal<UnityEngine.GameObject>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "autoCreatePlayer",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.autoCreatePlayer)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.autoCreatePlayer = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "playerSpawnMethod",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.playerSpawnMethod)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.playerSpawnMethod = Bridge.GetExternal<UnityEngine.Networking.PlayerSpawnMethod>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "offlineScene",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromString(o.offlineScene)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.offlineScene = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "onlineScene",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromString(o.onlineScene)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.onlineScene = args[1].ToString(); })
      );


      Bridge.DefineGetter(
        NetworkManagerPrototype,
        "spawnPrefabs",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.spawnPrefabs))
      );


      Bridge.DefineGetter(
        NetworkManagerPrototype,
        "startPositions",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.startPositions))
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "customConfig",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.customConfig)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.customConfig = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        NetworkManagerPrototype,
        "connectionConfig",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.connectionConfig))
      );


      Bridge.DefineGetter(
        NetworkManagerPrototype,
        "globalConfig",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.globalConfig))
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "maxConnections",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromInt32(o.maxConnections)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.maxConnections = args[1].ToInt32(); })
      );


      Bridge.DefineGetter(
        NetworkManagerPrototype,
        "channels",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.channels))
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "secureTunnelEndpoint",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.secureTunnelEndpoint)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.secureTunnelEndpoint = Bridge.GetExternal<System.Net.EndPoint>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "useWebSockets",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.useWebSockets)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.useWebSockets = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "useSimulator",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.useSimulator)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.useSimulator = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "simulatedLatency",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromInt32(o.simulatedLatency)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.simulatedLatency = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "packetLossPercentage",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromDouble(o.packetLossPercentage)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.packetLossPercentage = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "matchHost",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromString(o.matchHost)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.matchHost = args[1].ToString(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "matchPort",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromInt32(o.matchPort)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.matchPort = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        NetworkManagerPrototype,
        "clientLoadedScene",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.clientLoadedScene)),
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => { o.clientLoadedScene = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        NetworkManagerPrototype,
        "migrationManager",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.migrationManager))
      );


      Bridge.DefineGetter(
        NetworkManagerPrototype,
        "numPlayers",
        WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromInt32(o.numPlayers))
      );


      // Instance Methods

      NetworkManagerPrototype.SetProperty(
        "SetupMigrationManager",
        Bridge.CreateFunction(
          "SetupMigrationManager",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.SetupMigrationManager(Bridge.GetExternal<UnityEngine.Networking.NetworkMigrationManager>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartServer",
        Bridge.CreateFunction(
          "StartServer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.StartServer(Bridge.GetExternal<UnityEngine.Networking.ConnectionConfig>(args[1]), args[2].ToInt32())))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartServer",
        Bridge.CreateFunction(
          "StartServer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.StartServer()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartServer",
        Bridge.CreateFunction(
          "StartServer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.StartServer(Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[1]))))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "UseExternalClient",
        Bridge.CreateFunction(
          "UseExternalClient",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.UseExternalClient(Bridge.GetExternal<UnityEngine.Networking.NetworkClient>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartClient",
        Bridge.CreateFunction(
          "StartClient",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.StartClient(Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[1]), Bridge.GetExternal<UnityEngine.Networking.ConnectionConfig>(args[2]), args[3].ToInt32())))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartClient",
        Bridge.CreateFunction(
          "StartClient",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.StartClient(Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[1]))))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartClient",
        Bridge.CreateFunction(
          "StartClient",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.StartClient()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartClient",
        Bridge.CreateFunction(
          "StartClient",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.StartClient(Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[1]), Bridge.GetExternal<UnityEngine.Networking.ConnectionConfig>(args[2]))))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartHost",
        Bridge.CreateFunction(
          "StartHost",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.StartHost(Bridge.GetExternal<UnityEngine.Networking.ConnectionConfig>(args[1]), args[2].ToInt32())))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartHost",
        Bridge.CreateFunction(
          "StartHost",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.StartHost(Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[1]))))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartHost",
        Bridge.CreateFunction(
          "StartHost",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.StartHost()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StopHost",
        Bridge.CreateFunction(
          "StopHost",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.StopHost())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StopServer",
        Bridge.CreateFunction(
          "StopServer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.StopServer())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StopClient",
        Bridge.CreateFunction(
          "StopClient",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.StopClient())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "ServerChangeScene",
        Bridge.CreateFunction(
          "ServerChangeScene",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.ServerChangeScene(args[1].ToString()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "IsClientConnected",
        Bridge.CreateFunction(
          "IsClientConnected",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => JavaScriptValue.FromBoolean(o.IsClientConnected()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnServerConnect",
        Bridge.CreateFunction(
          "OnServerConnect",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnServerConnect(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnServerDisconnect",
        Bridge.CreateFunction(
          "OnServerDisconnect",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnServerDisconnect(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnServerReady",
        Bridge.CreateFunction(
          "OnServerReady",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnServerReady(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnServerAddPlayer",
        Bridge.CreateFunction(
          "OnServerAddPlayer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnServerAddPlayer(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<System.Int16>(args[2]), Bridge.GetExternal<UnityEngine.Networking.NetworkReader>(args[3])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnServerAddPlayer",
        Bridge.CreateFunction(
          "OnServerAddPlayer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnServerAddPlayer(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<System.Int16>(args[2])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "GetStartPosition",
        Bridge.CreateFunction(
          "GetStartPosition",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => Bridge.CreateExternalWithPrototype(o.GetStartPosition()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnServerRemovePlayer",
        Bridge.CreateFunction(
          "OnServerRemovePlayer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnServerRemovePlayer(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), Bridge.GetExternal<UnityEngine.Networking.PlayerController>(args[2])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnServerError",
        Bridge.CreateFunction(
          "OnServerError",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnServerError(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), args[2].ToInt32()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnServerSceneChanged",
        Bridge.CreateFunction(
          "OnServerSceneChanged",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnServerSceneChanged(args[1].ToString()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnClientConnect",
        Bridge.CreateFunction(
          "OnClientConnect",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnClientConnect(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnClientDisconnect",
        Bridge.CreateFunction(
          "OnClientDisconnect",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnClientDisconnect(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnClientError",
        Bridge.CreateFunction(
          "OnClientError",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnClientError(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1]), args[2].ToInt32()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnClientNotReady",
        Bridge.CreateFunction(
          "OnClientNotReady",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnClientNotReady(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnClientSceneChanged",
        Bridge.CreateFunction(
          "OnClientSceneChanged",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnClientSceneChanged(Bridge.GetExternal<UnityEngine.Networking.NetworkConnection>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StartMatchMaker",
        Bridge.CreateFunction(
          "StartMatchMaker",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.StartMatchMaker())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "StopMatchMaker",
        Bridge.CreateFunction(
          "StopMatchMaker",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.StopMatchMaker())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "SetMatchHost",
        Bridge.CreateFunction(
          "SetMatchHost",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.SetMatchHost(args[1].ToString(), args[2].ToInt32(), args[3].ToBoolean()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnStartHost",
        Bridge.CreateFunction(
          "OnStartHost",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnStartHost())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnStartServer",
        Bridge.CreateFunction(
          "OnStartServer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnStartServer())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnStartClient",
        Bridge.CreateFunction(
          "OnStartClient",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnStartClient(Bridge.GetExternal<UnityEngine.Networking.NetworkClient>(args[1])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnStopServer",
        Bridge.CreateFunction(
          "OnStopServer",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnStopServer())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnStopClient",
        Bridge.CreateFunction(
          "OnStopClient",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnStopClient())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnStopHost",
        Bridge.CreateFunction(
          "OnStopHost",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnStopHost())
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnMatchCreate",
        Bridge.CreateFunction(
          "OnMatchCreate",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnMatchCreate(args[1].ToBoolean(), args[2].ToString(), Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[3])))
        )
      );


      /*
        NetworkManager OnMatchList
        System.Collections.Generic.List`1[UnityEngine.Networking.Match.MatchInfoSnapshot] has generics
      */


      NetworkManagerPrototype.SetProperty(
        "OnMatchJoined",
        Bridge.CreateFunction(
          "OnMatchJoined",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnMatchJoined(args[1].ToBoolean(), args[2].ToString(), Bridge.GetExternal<UnityEngine.Networking.Match.MatchInfo>(args[3])))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnDestroyMatch",
        Bridge.CreateFunction(
          "OnDestroyMatch",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnDestroyMatch(args[1].ToBoolean(), args[2].ToString()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnDropConnection",
        Bridge.CreateFunction(
          "OnDropConnection",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnDropConnection(args[1].ToBoolean(), args[2].ToString()))
        )
      );


      NetworkManagerPrototype.SetProperty(
        "OnSetMatchAttributes",
        Bridge.CreateFunction(
          "OnSetMatchAttributes",
          WithExternal<UnityEngine.Networking.NetworkManager>((o, args) => o.OnSetMatchAttributes(args[1].ToBoolean(), args[2].ToString()))
        )
      );


    }
  }
}
