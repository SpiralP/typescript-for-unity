using System;
using System.Collections.Generic;
using ChakraCore.API;

namespace JavaScript.Module {
  class Cache {
    private Dictionary<String, JavaScriptModuleRecord> dict = new Dictionary<String, JavaScriptModuleRecord>();

    public bool Has(String normalizedSpecifier) {
      var result = dict.ContainsKey(normalizedSpecifier);
      Loader.Debug($"Javascript.Module.Cache Has('{normalizedSpecifier}') -> {result}");
      return result;
    }

    public JavaScriptModuleRecord GetOrInvalid(String normalizedSpecifier) {
      Loader.Debug($"Javascript.Module.Cache GetOrNull('{normalizedSpecifier}')");
      if (dict.ContainsKey(normalizedSpecifier))
        return dict[normalizedSpecifier];
      else
        return JavaScriptModuleRecord.Invalid;
    }

    public void Set(String normalizedSpecifier, JavaScriptModuleRecord record) {
      Loader.Debug($"Javascript.Module.Cache Set('{normalizedSpecifier}', record)");
      dict.Add(normalizedSpecifier, record);
    }

    public void Reset() {
      dict = new Dictionary<String, JavaScriptModuleRecord>();
    }
  }
}
