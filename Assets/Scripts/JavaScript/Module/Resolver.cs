using System.Collections.Generic;

namespace JavaScript.Module {
  class Resolver {
    private string rootDir;

    public Resolver(string _rootDir) {
      Loader.Debug($"Javascript.Module.Resolver constructed with path: '{_rootDir}'");
      rootDir = _rootDir.EndsWith("/") ? _rootDir : _rootDir + "/";
    }

    public string Normalize(string referencingModuleSpecifier, string specifier) {
      Loader.Debug($"Javascript.Module.Resolver normalizing '{specifier}' from '{referencingModuleSpecifier}'...");

      string searchDir = rootDir;

      if (
        referencingModuleSpecifier != null &&
        (
          specifier.StartsWith("../") ||
          specifier.StartsWith("./") ||
          specifier.StartsWith("..\\") ||
          specifier.StartsWith(".\\") ||
          specifier.Equals("..") ||
          specifier.Equals(".")
        )
      ) {
        searchDir = System.IO.Path.GetDirectoryName(referencingModuleSpecifier) + "/";
      }

      List<string> normalizationsToTry = new List<string>() {
        searchDir + specifier // import "foo.js" to load foo.js
      };
      normalizationsToTry.AddRange(Loader.SupportedExtensions.ConvertAll<string>((extension) => {
        return searchDir + specifier + extension; // import "foo" to load foo.js or foo.ts
      }));
      normalizationsToTry.AddRange(Loader.SupportedExtensions.ConvertAll<string>((extension) => {
        return searchDir + specifier + "/index" + extension; // import "foo" to load foo/index.js or foo/index.ts
      }));

      foreach (string normalization in normalizationsToTry) {
        Loader.Debug($"Javascript.Module.Resolver checking if '{normalization}' exists...");
        if (System.IO.File.Exists(normalization)) {
          string normalizationWithoutRelatives = System.IO.Path.GetFullPath(normalization);
          Loader.Debug($"Javascript.Module.Resolver normalized '{specifier}' as '{normalizationWithoutRelatives}'");
          return normalizationWithoutRelatives;
        }
      }

      Loader.Debug($"Javascript.Module.Resolver could not normalize '{specifier}' from '{referencingModuleSpecifier}'");
      return null;
    }

    public string Read(string normalizedSpecifier) {
      Loader.Debug($"Javascript.Module.Resolver reading '{normalizedSpecifier}'");
      string source = System.IO.File.ReadAllText(normalizedSpecifier);
      return Loader.ConvertSourceToJS(source, normalizedSpecifier);
    }
  }
}
