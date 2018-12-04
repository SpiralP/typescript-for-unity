using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ChakraCore.API;

namespace JavaScript.Bridging {
  public class Externals {
    private static Dictionary<IntPtr, Action> freeCallbacks = new Dictionary<IntPtr, Action>();

    public static Action<JavaScriptValue[]> WithExternal<T>(Action<T, JavaScriptValue[]> action) {
      return (args) => {
        action(GetExternal<T>(args[0]), args);
      };
    }
    public static Func<JavaScriptValue[], JavaScriptValue> WithExternal<T>(Func<T, JavaScriptValue[], JavaScriptValue> func) {
      return (args) => {
        return func(GetExternal<T>(args[0]), args);
      };
    }

    public static Action<JavaScriptValue[]> WithBoxedExternal<T>(Action<Bridge.Box<T>, JavaScriptValue[]> action) {
      return (args) => {
        action(GetExternal<Bridge.Box<T>>(args[0]), args);
      };
    }
    public static Func<JavaScriptValue[], JavaScriptValue> WithBoxedExternal<T>(Func<Bridge.Box<T>, JavaScriptValue[], JavaScriptValue> func) {
      return (args) => {
        return func(GetExternal<Bridge.Box<T>>(args[0]), args);
      };
    }

    public static Action<JavaScriptValue[]> WithExternal<T>(uint argsIndex, Action<T, JavaScriptValue[]> action) {
      return (args) => {
        action(GetExternal<T>(args[argsIndex]), args);
      };
    }
    public static Func<JavaScriptValue[], JavaScriptValue> WithExternal<T>(uint argsIndex, Func<T, JavaScriptValue[], JavaScriptValue> func) {
      return (args) => {
        return func(GetExternal<T>(args[argsIndex]), args);
      };
    }


    public static T GetExternal<T>(JavaScriptValue jsValue) {
      // if (jsValue.ValueType == JavaScriptValueType.Null) return null;
      if (!jsValue.HasExternalData) throw new Exception("Attempted to retrieve External data from a JavaScriptValue, but the value did not have any external data");

      GCHandle gch = GCHandle.FromIntPtr(jsValue.ExternalData);
      // TODO use (Target is T)?
      // UnityEngine.Debug.Log(gch.Target.GetType() + " casting to " + typeof(T));

      return (T) gch.Target;
    }
    public static Bridge.Box<T> GetBoxedExternal<T>(JavaScriptValue jsValue) {
      return GetExternal<Bridge.Box<T>>(jsValue);
    }


    public static JavaScriptValue CreateExternalWithPrototype<T>(T obj, Action onFree = null) {
      if (((System.Object) obj) == null || ((System.Object) obj).Equals(null)) return JavaScriptValue.Null;
      // Unity likes to create "null" objects where their ToString() == "null" but it's not technically the C# value null
      // so we use Object which UnityEntity.Object extends Equals on
      // This will also handle Nullable<T> "nullOrValue?" values

      Type type = obj.GetType(); // this has to be GetType and not typeof(T) because T will be System.Object sometimes
      string typeName = type.ToString();
      if (typeName.EndsWith("+Enumerator")) { // TODO?
        typeName = typeName.Replace("+Enumerator", ""); // Transform+Enumerator -> Transform
      }

      JavaScriptValue? prototype = Bridging.ConstructorsAndPrototypes.GetPrototype(typeName);

      if (!prototype.HasValue) {
        throw new Exception($"Attempted to create an external with prototype '{typeName}', but no such prototype has been registered with the Bridge.");
      }

      return CreateExternalWithPrototype<T>(obj, prototype.Value, onFree);
    }

    public static JavaScriptValue CreateExternalWithPrototype<T>(T obj, JavaScriptValue prototype, Action onFree = null) {
      if (((System.Object) obj) == null || ((System.Object) obj).Equals(null)) return JavaScriptValue.Null;
      // Unity likes to create "null" objects where their ToString() == "null" but it's not technically the C# value null
      // so we use Object which UnityEntity.Object extends Equals on
      // This will also handle Nullable<T> "nullOrValue?" values

      // TODO things that pass in Nullable<T> should be casted to T since Nullable<> is redundant from us removing null ^

      Type type = obj.GetType(); // this has to be GetType and not typeof(T) because T will be System.Object sometimes
      GCHandle handle;
      if (type.IsValueType && !type.IsEnum) { // if a struct
        handle = GCHandle.Alloc(new Bridge.Box<T>(obj));
      } else {
        handle = GCHandle.Alloc(obj);
      }

      IntPtr ptr = GCHandle.ToIntPtr(handle);
      if (onFree != null) {
        freeCallbacks[ptr] = onFree;
      }

      return JavaScriptValue.CreateExternalObjectWithPrototype(
        ptr,
        (intPtr) => {
          try {
            if (freeCallbacks.ContainsKey(intPtr)) {
              Action onFreeForPtr = freeCallbacks[intPtr];
              freeCallbacks.Remove(intPtr);
              onFreeForPtr();
            }
          } finally {
            if (freeCallbacks.ContainsKey(intPtr)) {
              freeCallbacks.Remove(intPtr);
            }
            GCHandle.FromIntPtr(intPtr).Free();
          }
        },
        prototype
      );
    }
  }
}
