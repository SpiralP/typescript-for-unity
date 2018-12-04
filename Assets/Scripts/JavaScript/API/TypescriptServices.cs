using System;
using ChakraCore.API;
using UnityEngine;

namespace JavaScript.API {
  class TypescriptServices {
    public static void Register(JavaScriptContext context) {
      Engine.RunFile("vendor/typescriptServices.js");
      if (JavaScriptValue.GlobalObject.GetProperty("ts").ValueType == JavaScriptValueType.Undefined) {
        Debug.LogWarning("didn't make ts global!");
      }
    }

    public static string CompileTypescript(string code) {
      JavaScriptValue ts = JavaScriptValue.GlobalObject
        .GetProperty("ts");

      JavaScriptValue compileOptions = JavaScriptValue.CreateObject();
      compileOptions.SetProperty(
        "target",
        ts.GetProperty("ScriptTarget").GetProperty("ES2017") // http://kangax.github.io/compat-table/es2016plus/
      );

      string compiledCode = ts
        .GetProperty("transpile")
        .CallFunction(
          JavaScriptValue.Undefined,
          JavaScriptValue.FromString(code),
          compileOptions
        ).ToString();

      return compiledCode;
    }
  }
}
