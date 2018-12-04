using System;
using System.Collections.Generic;
using ChakraCore.API;
using UnityEngine;

namespace JavaScript.API {
  public class PromiseContinuation {
    private static Queue<JavaScriptValue> promiseTaskQueue = new Queue<JavaScriptValue>();

    public static void ProcessPromiseTaskQueue() { // called inside With()
      while (promiseTaskQueue.Count != 0) {
        JavaScriptValue task = promiseTaskQueue.Dequeue();

        try {
          task.CallFunction(JavaScriptValue.Undefined);
        } catch (Exception e) {
          Debug.LogError(e);
        }

        task.Release();
      }
    }

    private static void PromiseRejectionTrackerCallback(
      JavaScriptValue promise,
      JavaScriptValue reason,
      bool handled,
      IntPtr callbackState
    ) {
      // TODO
      UnityEngine.Debug.LogError("Unhandled Promise rejection: " + reason.ConvertToString().ToString());
    }

    private static void PromiseContinuationCallback(
      JavaScriptValue task,
      IntPtr callbackState
    ) {
      task.AddRef(); // call Release later
      promiseTaskQueue.Enqueue(task);
    }

    public static void Register(JavaScriptContext context) {
      promiseTaskQueue.Clear();

      Native.ThrowIfError(
        Native.JsSetHostPromiseRejectionTracker(
          PromiseRejectionTrackerCallback,
          (IntPtr) 0
        )
      );
      Native.ThrowIfError(
        Native.JsSetPromiseContinuationCallback(
          PromiseContinuationCallback,
          (IntPtr) 0
        )
      );
    }

  }
}
