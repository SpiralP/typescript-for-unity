using ChakraCore.API;
using UnityEngine;

namespace JavaScript.API {
  class Inspect {
    public static void Register(JavaScriptContext context) {
      Engine.RunFile("vendor/inspect.js");
      if (JavaScriptValue.GlobalObject.GetProperty("inspect").ValueType == JavaScriptValueType.Undefined) {
        Debug.LogWarning("Expected vendor/inspect.js to define an inspect global, but it did not");
      }
    }

    public static string GetString(JavaScriptValue value) {
      return JavaScriptValue.GlobalObject.GetProperty("inspect").CallFunction(JavaScriptValue.Undefined, value).ConvertToString().ToString();
    }
  }
}
