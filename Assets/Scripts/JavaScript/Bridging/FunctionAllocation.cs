using System;
using System.Collections.Generic;
using ChakraCore.API;

namespace JavaScript.Bridging {
  public class FunctionAllocation {
    private static Dictionary<IntPtr, Action<JavaScriptValue[]>> mapOfActions = new Dictionary<IntPtr, Action<JavaScriptValue[]>>();
    private static Dictionary<IntPtr, Func<JavaScriptValue[], JavaScriptValue>> mapOfFuncs = new Dictionary<IntPtr, Func<JavaScriptValue[], JavaScriptValue>>();
    private static IntPtr currentId = (IntPtr) 0;

    private static IntPtr Allocate(Action<JavaScriptValue[]> func) {
      currentId = currentId + 1;
      IntPtr id = currentId;
      mapOfActions[id] = func;
      return id;
    }
    private static IntPtr Allocate(Func<JavaScriptValue[], JavaScriptValue> func) {
      currentId = currentId + 1;
      IntPtr id = currentId;
      mapOfFuncs[id] = func;
      return id;
    }

    public static void FreeAll() {
      mapOfActions.Clear();
      mapOfFuncs.Clear();
    }

    // Action
    public static JavaScriptValue CreateFunction(string name, Action<JavaScriptValue[]> func) {
      return JavaScriptValue.CreateFunction(name, JsCallbackForAction, Allocate(func));
    }
    public static JavaScriptValue CreateFunction(Action<JavaScriptValue[]> func) {
      return JavaScriptValue.CreateFunction(JsCallbackForAction, Allocate(func));
    }

    // Func
    public static JavaScriptValue CreateFunction(string name, Func<JavaScriptValue[], JavaScriptValue> func) {
      return JavaScriptValue.CreateFunction(name, JsCallbackForFunc, Allocate(func));
    }
    public static JavaScriptValue CreateFunction(Func<JavaScriptValue[], JavaScriptValue> func) {
      return JavaScriptValue.CreateFunction(JsCallbackForFunc, Allocate(func));
    }


    private static JavaScriptValue JsCallbackForAction(
      JavaScriptValue callee,
      bool isConstructCall,
      JavaScriptValue[] arguments,
      ushort argumentCount,
      IntPtr callbackData
    ) {
      Action<JavaScriptValue[]> callback = mapOfActions[callbackData];

      try {
        callback(arguments);
      } catch (Exception e) {
        JavaScriptContext.ThrowException(e);
      }

      return JavaScriptValue.Undefined;
    }

    private static JavaScriptValue JsCallbackForFunc(
      JavaScriptValue callee,
      bool isConstructCall,
      JavaScriptValue[] arguments,
      ushort argumentCount,
      IntPtr callbackData
    ) {
      Func<JavaScriptValue[], JavaScriptValue> from = mapOfFuncs[callbackData];

      try {
        return from(arguments);
      } catch (Exception e) {
        JavaScriptContext.ThrowException(e);
      }

      return JavaScriptValue.Undefined;
    }
  }
}
