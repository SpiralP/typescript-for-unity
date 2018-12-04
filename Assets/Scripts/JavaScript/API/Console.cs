using System;
using System.Collections.Generic;
using System.Linq;
using ChakraCore.API;
using UnityEngine;

namespace JavaScript.API {
  class Console {
    private static string getFormattedString(JavaScriptValue[] arguments, Func<JavaScriptValue, string> toString) {
      return string.Join(
        "\t",
        arguments.Skip(1).Select(toString)
      ) + "\n";
    }

    private static Func<JavaScriptValue, string> ConvertToString() {
      return (jsValue) => {
        return jsValue.ConvertToString().ToString();
      };
    }

    private static Func<JavaScriptValue, string> Inspect() {
      return (jsValue) => {
        switch (jsValue.ValueType) {
          case JavaScriptValueType.String:
            return jsValue.ToString();

          case JavaScriptValueType.Boolean:
          case JavaScriptValueType.Null:
          case JavaScriptValueType.Number:
          case JavaScriptValueType.Symbol:
          case JavaScriptValueType.Undefined:
            return JavaScript.API.Inspect.GetString(jsValue);

          default:
            // It's safe to call GetProperty on all other value types
            JavaScriptValue valueToPrint = jsValue;
            JavaScriptValue toStringProperty = jsValue.GetProperty("toString");
            if (
              toStringProperty.IsValid &&
              toStringProperty.ValueType == JavaScriptValueType.Function &&
              // Object and array prototype toStrings are kinda useless; they just return eg [object Object] or array values joined with commas.
              // Don't bother calling those, should use Inspect instead.
              toStringProperty != JavaScriptValue.GlobalObject.GetProperty("Object").GetProperty("prototype").GetProperty("toString") &&
              toStringProperty != JavaScriptValue.GlobalObject.GetProperty("Array").GetProperty("prototype").GetProperty("toString")
            ) {
              valueToPrint = toStringProperty.CallFunction(jsValue);
            }
            return JavaScript.API.Inspect.GetString(valueToPrint);
        }
      };
    }

    public static void Register(JavaScriptContext context) {
      JavaScriptValue console = JavaScriptValue.CreateObject();

      JavaScriptValue.GlobalObject.SetProperty(
        "console",
        console
      );

      foreach (var pair in new Dictionary<string, Action<JavaScriptValue[]>>() {
          {
            "_log",
            (arguments) => {
              Debug.Log(getFormattedString(arguments, ConvertToString()));
            }
          }, {
            "_warn",
            (arguments) => {
              Debug.LogWarning(getFormattedString(arguments, ConvertToString()));
            }
          }, {
            "_error",
            (arguments) => {
              Debug.LogError(getFormattedString(arguments, ConvertToString()));
            }
          }, {
            "log",
            (arguments) => {
              Debug.Log(getFormattedString(arguments, Inspect()));
            }
          }, {
            "warn",
            (arguments) => {
              Debug.LogWarning(getFormattedString(arguments, Inspect()));
            }
          }, {
            "error",
            (arguments) => {
              Debug.LogError(getFormattedString(arguments, Inspect()));
            }
          }
        }) {

        console.SetProperty(
          pair.Key,
          Bridge.CreateFunction(pair.Key, pair.Value)
        );
      }
    }
  }
}
