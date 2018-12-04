using System;
using System.Collections.Generic;
using ChakraCore.API;

namespace JavaScript.Module {
  class RecordDelegate {
    public static string rootSpecifier = "<root>";

    private Cache cache;
    private Resolver resolver;
    // we need a queue so that we delay execution until after the callbacks like
    // it wants. If we don't delay it we get a blank "" jsErrorInstance.message
    private Queue<Action> moduleParseQueue;
    private Action executeRoot;
    public List<JavaScriptModuleRecord> dependencies = new List<JavaScriptModuleRecord>();

    public RecordDelegate(string rootDir, Cache _cache = null) {
      Loader.Debug($"Javascript.Module.RecordDelegate constructed with rootDir: '{rootDir}'");
      resolver = new Resolver(rootDir);
      if (_cache == null) {
        cache = new Cache();
      } else {
        cache = _cache;
      }
      moduleParseQueue = new Queue<Action>();
      executeRoot = null;
    }

    public void Run(string source) {
      JavaScriptModuleRecord root = JavaScriptModuleRecord.Initialize(
        null,
        rootSpecifier
      );
      root.HostUrl = "<root>";

      root.NotifyModuleReadyCallback = NotifyModuleReadyCallback;
      root.FetchImportedModuleCallBack = FetchImportedModuleCallback;

      try {
        root.ParseSource(source);
      } catch {
        // Exception gets handled by NotifyModuleReadyCallback
      }

      while (moduleParseQueue.Count > 0) {
        Loader.Debug("Parsing module from queue...");
        moduleParseQueue.Dequeue() ();
      }

      if (executeRoot != null) {
        executeRoot();
        executeRoot = null;
      }
    }

    JavaScriptErrorCode FetchImportedModuleCallback(
      JavaScriptModuleRecord referencingModule,
      JavaScriptValue specifierAsValue,
      out JavaScriptModuleRecord outDependentModuleRecord
    ) {
      string specifier = specifierAsValue.ToString();
      Loader.Debug($"Javascript.Module.RecordDelegate FetchImportedModuleCallback for specifier: '{specifier}'");

      string normalizedSpecifier = resolver.Normalize(referencingModule.HostUrl, specifier);

      JavaScriptModuleRecord dependentModuleRecord;
      if (normalizedSpecifier == null) {
        dependentModuleRecord = JavaScriptModuleRecord.Initialize(null, "<invalid record>");
        dependentModuleRecord.Exception = JavaScriptValue.CreateError($"Could not find module '{specifier}' from '{referencingModule.HostUrl}'");
      } else if (cache.Has(normalizedSpecifier)) {
        dependentModuleRecord = cache.GetOrInvalid(normalizedSpecifier);
      } else {
        dependentModuleRecord = JavaScriptModuleRecord.Initialize(referencingModule, normalizedSpecifier);
        dependentModuleRecord.HostUrl = normalizedSpecifier;
        cache.Set(normalizedSpecifier, dependentModuleRecord);

        moduleParseQueue.Enqueue(() => {
          Loader.Debug($"Javascript.Module.RecordDelegate parsing source for '{specifier}'");
          string source = "";
          try {
            source = resolver.Read(normalizedSpecifier);
          } catch (Exception loadException) {
            dependentModuleRecord.Exception = JavaScriptValue.CreateError($"Couldn't read file '{normalizedSpecifier}': " + loadException);
          }

          try {
            // if we couldn't read the file for whatever reason, we must still call ParseSource
            // so that the internals will move on to the next step and show us the Exception set above
            dependentModuleRecord.ParseSource(source); // can throw syntax errors
          } catch {
            // will set Exception for us!
          }
        });
      }

      dependencies.Add(dependentModuleRecord);

      outDependentModuleRecord = dependentModuleRecord;
      return JavaScriptErrorCode.NoError; // Error case gets handled by Exception being set on the module record
    }

    JavaScriptErrorCode NotifyModuleReadyCallback(
      JavaScriptModuleRecord referencingModule,
      JavaScriptValue exceptionVar
    ) {
      Loader.Debug($"Javascript.Module.RecordDelegate NotifyModuleReadyCallback evaluating module: '{referencingModule.HostUrl}'");

      executeRoot = () => {
        referencingModule.Evaluate(); // will throw if exceptionVar was set
      };

      return JavaScriptErrorCode.NoError; // this return value is ignored! (wiki)
    }
  }
}
