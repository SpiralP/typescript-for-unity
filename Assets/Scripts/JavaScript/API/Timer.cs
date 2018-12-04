using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ChakraCore.API;

namespace JavaScript.API {

  class Timer {
    private struct TimerCallback {
      public JavaScriptValue callback;
      public Stopwatch stopwatch;
      public int delay;
      public TimerCallback(JavaScriptValue callback, int delay) {
        this.callback = callback;
        this.stopwatch = new Stopwatch();
        this.delay = delay;

        this.stopwatch.Start();
      }

      public bool IsTimeUp() {
        return stopwatch.ElapsedMilliseconds >= delay;
      }
    }

    private static Dictionary<string, TimerCallback> timeoutTimers = new Dictionary<string, TimerCallback>();
    private static Dictionary<string, TimerCallback> intervalTimers = new Dictionary<string, TimerCallback>();

    public static void ProcessTimers() {
      ProcessTimeouts();
      ProcessIntervals();
    }

    private static void ProcessTimeouts() {
      // ToList will snapshot the keys, so we don't run new timers created by these timers in this loop
      foreach (string guid in timeoutTimers.Keys.ToList()) {

        // handle things in this current function call removing other timers
        if (!timeoutTimers.ContainsKey(guid)) { continue; }

        TimerCallback timerCallback = timeoutTimers[guid];
        if (!timerCallback.IsTimeUp()) { continue; }

        JavaScriptValue callback = timerCallback.callback;
        try {
          callback.CallFunction(JavaScriptValue.Undefined);
        } catch (Exception e) {
          UnityEngine.Debug.LogError(e);
        } finally {
          ClearTimeout(guid);
        }
      }
    }

    private static void ProcessIntervals() {
      // ToList will snapshot the keys, so we don't run new timers created by these timers in this loop
      foreach (string guid in intervalTimers.Keys.ToList()) {

        // handle things in this current function call removing other timers
        if (!intervalTimers.ContainsKey(guid)) { continue; }

        TimerCallback timerCallback = intervalTimers[guid];
        if (!timerCallback.IsTimeUp()) { continue; }

        JavaScriptValue callback = timerCallback.callback;
        try {
          callback.CallFunction(JavaScriptValue.Undefined);
        } catch (Exception e) {
          UnityEngine.Debug.LogError(e);
        }

        timerCallback.stopwatch.Restart();
      }
    }

    public static string SetTimeout(JavaScriptValue callback, int delay) {
      callback.AddRef(); // call Release later

      string guid = Guid.NewGuid().ToString();
      timeoutTimers[guid] = new TimerCallback(callback, delay);
      return guid;
    }

    public static void ClearTimeout(string guid) {
      if (!timeoutTimers.ContainsKey(guid)) { return; }
      TimerCallback timerCallback = timeoutTimers[guid];
      timerCallback.stopwatch.Stop();
      timerCallback.callback.Release();
      timeoutTimers.Remove(guid);
    }

    public static string SetInterval(JavaScriptValue callback, int delay) {
      callback.AddRef(); // call Release later

      string guid = Guid.NewGuid().ToString();
      intervalTimers[guid] = new TimerCallback(callback, delay);
      return guid;
    }

    public static void ClearInterval(string guid) {
      if (!intervalTimers.ContainsKey(guid)) { return; }
      TimerCallback timerCallback = intervalTimers[guid];
      timerCallback.stopwatch.Stop();
      timerCallback.callback.Release();
      intervalTimers.Remove(guid);
    }

    public static void Register(JavaScriptContext context) {
      JavaScriptValue global = JavaScriptValue.GlobalObject;

      global.SetProperty(
        "setTimeout",
        Bridge.CreateFunction((args) => {
          if (args[1].ValueType != JavaScriptValueType.Function) {
            throw new Exception("First argument passed to setTimeout must be a function");
          }
          int delay = 4; // 4ms HTML5 spec standard
          if (args.Length > 2) {
            delay = args[2].ToInt32();
          }
          if (delay < 4) {
            delay = 4;
          }
          return JavaScriptValue.FromString(
            SetTimeout(args[1], delay)
          );
        })
      );

      global.SetProperty(
        "setInterval",
        Bridge.CreateFunction((args) => {
          if (args[1].ValueType != JavaScriptValueType.Function) {
            throw new Exception("First argument passed to setInterval must be a function");
          }
          int interval = 4;
          if (args.Length > 2) {
            interval = args[2].ToInt32();
          }
          if (interval < 4) {
            interval = 4;
          }
          return JavaScriptValue.FromString(
            SetInterval(args[1], interval)
          );
        })
      );

      global.SetProperty(
        "clearTimeout",
        Bridge.CreateFunction("clearTimeout", (args) => {
          if (args.Length < 2 || args[1].ValueType != JavaScriptValueType.String) {
            return;
          }
          string guid = args[1].ToString();

          ClearTimeout(guid);
        })
      );

      global.SetProperty(
        "clearInterval",
        Bridge.CreateFunction("clearInterval", (args) => {
          if (args.Length < 2 || args[1].ValueType != JavaScriptValueType.String) {
            return;
          }
          string guid = args[1].ToString();

          ClearInterval(guid);
        })
      );
    }
  }
}
