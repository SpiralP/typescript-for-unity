using System;
using System.Collections.Generic;
using ChakraCore.API;
using UnityEngine;

namespace JavaScript.API {
  class UpdateHelper {
    private static Queue<Action> csharpCallback = new Queue<Action>();
    private static Queue<JavaScriptValue> oneUpdateCallbacks = new Queue<JavaScriptValue>();
    private static Dictionary<string, JavaScriptValue> updateCallbacks = new Dictionary<string, JavaScriptValue>();

    public static void ProcessUpdate() {
      while (csharpCallback.Count != 0) {
        Action fn = csharpCallback.Dequeue();
        fn();
      }

      while (oneUpdateCallbacks.Count != 0) {
        JavaScriptValue fn = oneUpdateCallbacks.Dequeue();
        try {
          fn.CallFunction(JavaScriptValue.Undefined);
        } catch (Exception e) {
          Debug.LogError(e);
        } finally {
          fn.Release();
        }
      }

      foreach (var pair in updateCallbacks) {
        try {
          pair.Value.CallFunction(JavaScriptValue.Undefined);
        } catch (Exception e) {
          Debug.LogError(e);
        }
      }
    }

    private static string addUpdateHook(JavaScriptValue fn) {
      if (fn.ValueType != JavaScriptValueType.Function) {
        throw new Exception("Argument passed to addUpdateHook must be a function");
      }

      string id = Guid.NewGuid().ToString();
      fn.AddRef();
      updateCallbacks[id] = fn;
      return id;
    }

    private static void addOneUpdateHook(JavaScriptValue fn) {
      if (fn.ValueType != JavaScriptValueType.Function) {
        throw new Exception("Argument passed to addOneUpdateHook must be a function");
      }

      fn.AddRef();
      oneUpdateCallbacks.Enqueue(fn);
    }

    // for C# to use
    public static void addOneUpdateHook(Action fn) {
      csharpCallback.Enqueue(fn);
    }

    private static void removeUpdateHook(string id) {
      if (!updateCallbacks.ContainsKey(id)) return;

      updateCallbacks[id].Release();
      updateCallbacks.Remove(id);
    }

    public static void Register(JavaScriptContext context) {
      updateCallbacks.Clear();
      oneUpdateCallbacks.Clear();

      JavaScriptValue UpdateHelper = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.SetProperty(
        "UpdateHelper",
        UpdateHelper
      );

      UpdateHelper.SetProperty(
        "addUpdateHook",
        Bridge.CreateFunction(
          "addUpdateHook",
          (args) => {
            return JavaScriptValue.FromString(
              addUpdateHook(args[1])
            );
          }
        )
      );

      UpdateHelper.SetProperty(
        "removeUpdateHook",
        Bridge.CreateFunction(
          "removeUpdateHook",
          (args) => {
            removeUpdateHook(args[1].ToString());
          }
        )
      );

      UpdateHelper.SetProperty(
        "removeAllUpdateHooks",
        Bridge.CreateFunction(
          "removeAllUpdateHooks",
          (args) => {
            updateCallbacks.Clear();
            oneUpdateCallbacks.Clear();
          }
        )
      );

      UpdateHelper.SetProperty(
        "addOneUpdateHook",
        Bridge.CreateFunction(
          "addOneUpdateHook",
          (args) => {
            addOneUpdateHook(args[1]);
          }
        )
      );

    }

  }
}
