using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ChakraCore.API;
using UnityEngine;

namespace JavaScript {
  public class Engine : MonoBehaviour {
    public static JavaScriptRuntime runtime;
    public static JavaScriptContext context;
    public static Engine instance = null;
    public static string javascriptRoot = null;

    [Serializable]
    public struct Binding {
      public string name;
      public UnityEngine.Object boundObject;
    }

    public List<Binding> bindings = new List<Binding>();

    void Awake() {
#if UNITY_EDITOR
      javascriptRoot = Application.streamingAssetsPath + "/../../src/";
#else
      javascriptRoot = Application.streamingAssetsPath + "/src/";
#endif

      if (instance == null) {
        instance = this;
      } else {
        throw new Exception("There should not be more than one instance of Javascript.Engine in a scene at a time.");
      }

      runtime = JavaScriptRuntime.Create();
      context = runtime.CreateContext();

      Engine.With(() => {
        Module.Loader.Register(context);
        API.JSSystem.JSSystem.Register(context);
        API.Console.Register(context);
        API.DOM.Register(context);
        API.Inspect.Register(context);
        API.TypescriptServices.Register(context);
        API.File.Register(context);
        API.Http.Register(context);
        API.UpdateHelper.Register(context);
        API.Timer.Register(context);
        API.PromiseContinuation.Register(context);
        API.ChakraInternals.Register(context);
        API.JSUnityEngine.JSUnityEngine.Register(context);
        JavaScript.JSBehaviour.Register(context);

        JavaScriptValue.GlobalObject.SetProperty(
          "engine",
          Bridge.CreateExternalWithPrototype(
            this,
            Bridge.GetPrototype("UnityEngine.MonoBehaviour")
          )
        );
        JavaScriptValue.GlobalObject.SetProperty(
          "root",
          Bridge.CreateExternalWithPrototype(
            gameObject
          )
        );
        JavaScriptValue.GlobalObject.SetProperty(
          "importModule",
          Bridge.CreateFunction("importModule", (args) => {
            if (args[1].ValueType != JavaScriptValueType.String) {
              throw new Exception("The first argument to importModule must be a string");
            }
            return Import(args[1].ToString());
          })
        );
        JavaScriptValue.GlobalObject.SetProperty(
          "importScripts",
          Bridge.CreateFunction("importScripts", (args) => {
            foreach (var arg in args.Skip(1)) {
              if (args[1].ValueType != JavaScriptValueType.String) {
                throw new Exception("All arguments to importScripts must be strings");
              }
              RunFile(args[1].ToString());
            }
          })
        );

        JavaScriptValue BindingsGlobal = JavaScriptValue.CreateObject();
        BindingsGlobal.SetProperty("get", Bridge.CreateFunction("get", (arguments) => {
          string name = arguments[1].ToString();

          var binding = bindings.Find((b) => b.name.Equals(name));
          if (binding.Equals(null)) {
            throw new Exception($"Attempted to retrieve the '{name}' binding from the Engine, but no such binding was associated. ");
          }

          return Bridge.CreateExternalWithPrototype(binding.boundObject);
        }));

        JavaScriptValue.GlobalObject.SetProperty(
          "bindings",
          BindingsGlobal
        );
      });


      CreateFileWatcher(
        javascriptRoot,
        (path) => {
          Debug.Log("file changed: " + path);
          if (fileChangedCallbacks.ContainsKey(path)) {
            Module.Loader.defaultCache.Reset();

            Debug.Log("calling callback");
            fileChangedCallbacks[path](path);
          }
        }
      );
    }

    void Update() {
      Engine.With(() => {
        API.UpdateHelper.ProcessUpdate();
        API.PromiseContinuation.ProcessPromiseTaskQueue();
        API.Timer.ProcessTimers();
      });
    }

    void OnDestroy() {
      StopFileWatcher();

      Bridge.Stop();

      runtime.Dispose();
      instance = null;
    }


    public static JavaScriptValue RunScript(string script) {
      // TODO expression return value?
      return JavaScriptContext.RunScript("(function(){" + script + "})();");
    }

    public static JavaScriptValue RunFile(string filename) {
      string path = new JavaScript.Module.Resolver(javascriptRoot).Normalize(null, filename);
      if (path == null) {
        throw new Exception($"Could not find file from specifier '{filename}'");
      }

      string code = JavaScript.Module.Loader.ConvertSourceToJS(System.IO.File.ReadAllText(path), path);

      return JavaScriptContext.RunScript(code, filename);
    }


    // TODO event handler for multiple callbacks?
    private static Dictionary<string, Action<string>> fileChangedCallbacks = new Dictionary<string, Action<string>>();
    public static JavaScriptValue Import(string specifier, Action<string> fileChangedCallback = null) {
      JavaScriptValue module = JavaScriptValue.Null;
      Module.RecordDelegate recordDelegate = null;
      Engine.With(() => {
        module = Module.Loader.Load(javascriptRoot, specifier, out recordDelegate);
      });

      if (fileChangedCallback != null) {
        string path = new JavaScript.Module.Resolver(javascriptRoot).Normalize(null, specifier);
        fileChangedCallbacks[path] = fileChangedCallback;

        if (recordDelegate != null) {
          foreach (var item in recordDelegate.dependencies) {
            string dependencyPath = item.HostUrl;
            fileChangedCallbacks[dependencyPath] = fileChangedCallback;
          }
        }
      }

      return module;
    }


    private static System.Object jsThreadLock = new System.Object();
    public static void With(Action action) {
#if UNITY_EDITOR
      System.Diagnostics.Stopwatch lockStopwatch = new System.Diagnostics.Stopwatch();
      lockStopwatch.Start();
#endif

      lock(jsThreadLock) // only allow one thread to access "threadLock" at a time
      {
        using(context.getScope()) // call Dispose on this object after scope
        {

#if UNITY_EDITOR
          lockStopwatch.Stop();
          if (lockStopwatch.ElapsedMilliseconds >= (1000f * (1f / 10f))) { // lower than 10fps
            UnityEngine.Debug.LogWarning($"With() locking took {lockStopwatch.ElapsedMilliseconds}ms!");
          }

          System.Diagnostics.Stopwatch actionStopwatch = new System.Diagnostics.Stopwatch();
          try {
            actionStopwatch.Start();
#endif

            action();

#if UNITY_EDITOR
          } finally {
            actionStopwatch.Stop();
            if (actionStopwatch.ElapsedMilliseconds >= (1000f * (1f / 10f))) { // lower than 10fps
              UnityEngine.Debug.LogWarning($"With() took {actionStopwatch.ElapsedMilliseconds}ms!");
            }
          }
#endif

        } // using will call Dispose even if we throw
      } // lock will unlock even if we throw
    }

    public static void WithIfRunning(Action action) {
      if (instance != null) {
        With(action);
      }
    }


    private static FileSystemWatcher fileSystemWatcher = null;
    private static void CreateFileWatcher(string path, Action<string> callback) {
      if (fileSystemWatcher != null) throw new Exception("oh it is sad day");

      try {
        FileSystemWatcher watcher = new FileSystemWatcher();
        fileSystemWatcher = watcher;

        watcher.Path = path;
        watcher.Filter = "*.*";
        watcher.NotifyFilter = NotifyFilters.LastWrite;

        watcher.Changed += new FileSystemEventHandler((object o, FileSystemEventArgs a) => {
          callback(a.FullPath);
        });

        watcher.IncludeSubdirectories = true;
        // Begin watching.
        watcher.EnableRaisingEvents = true;
      } catch (Exception e) { Debug.LogWarning("couldn't create file watcher: " + e); }
    }
    private static void StopFileWatcher() {
      fileSystemWatcher.EnableRaisingEvents = false;
      fileSystemWatcher.Dispose();
    }
  }
}
