using System.Collections.Generic;
using ChakraCore.API;

namespace JavaScript.Module {
  class Loader {
    public static Cache defaultCache = new Cache();
    public static JavaScriptValue modulesSymbol;

    public static void Register(JavaScriptContext context) {
      JavaScriptValue symbolGlobal = JavaScriptValue.GlobalObject.GetProperty("Symbol");
      modulesSymbol = symbolGlobal.GetProperty("for").CallFunction(symbolGlobal, JavaScriptValue.FromString("typescript-for-unity.importedRootModules"));
      modulesSymbol.AddRef();
      JavaScriptValue.GlobalObject.SetProperty(modulesSymbol, JavaScriptValue.CreateObject());
    }

    public static JavaScriptValue Load(string rootDir, string specifier, out RecordDelegate recordDelegate, Cache passedCache = null) {
      Loader.Debug($"Javascript.Module.Loader.Load('{rootDir}', '{specifier}')");
      Cache cache = passedCache == null ? defaultCache : passedCache;

      var path = new JavaScript.Module.Resolver(rootDir).Normalize(null, specifier);

      if (path != null && cache.Has(path)) {
        recordDelegate = null; // TODO ?????
        return JavaScriptValue.GlobalObject.GetProperty(modulesSymbol).GetProperty(specifier);
      }

      RecordDelegate moduleRecordDelegate = new RecordDelegate(rootDir, cache);
      moduleRecordDelegate.Run($@"
        import * as mod from '{specifier}';
        global[Symbol.for('typescript-for-unity.importedRootModules')]['{specifier}'] = Object.assign({{}}, mod);
      ");
      recordDelegate = moduleRecordDelegate;

      return JavaScriptValue.GlobalObject.GetProperty(modulesSymbol).GetProperty(specifier);
    }

    public static List<string> SupportedExtensions = new List<string>() {
      ".js",
      ".ts"
    };

    public static string ConvertSourceToJS(string source, string fullPath) {
      Loader.Debug($"Javascript.Module.Loader.ConvertSourceToJS(source, '{fullPath}')");
      string extension = System.IO.Path.GetExtension(fullPath);
      if (extension.Equals(".js")) {
        return source;
      } else if (extension.Equals(".ts")) {
        return JavaScript.API.TypescriptServices.CompileTypescript(source);
      } else if (extension.Equals(".json")) {
        return "export default " + source;
      } else {
        return $@"
          throw new Error(
            'Attempted to import \'{fullPath}\', but the engine doesn\'t know how to load the \'{extension}\' file extension.'
          );
        ";
      }
    }

    public static void Debug(string message) {
      // UnityEngine.Debug.Log(message);
    }
  }
}
