using System;
using ChakraCore.API;

namespace JavaScript {
  public class Bridge {
    #region Bridging.FunctionAllocation
    public static JavaScriptValue CreateFunction(string name, Action<JavaScriptValue[]> func) {
      return Bridging.FunctionAllocation.CreateFunction(name, func);
    }
    public static JavaScriptValue CreateFunction(Action<JavaScriptValue[]> func) {
      return Bridging.FunctionAllocation.CreateFunction(func);
    }

    // Func
    public static JavaScriptValue CreateFunction(string name, Func<JavaScriptValue[], JavaScriptValue> func) {
      return Bridging.FunctionAllocation.CreateFunction(name, func);
    }
    public static JavaScriptValue CreateFunction(Func<JavaScriptValue[], JavaScriptValue> func) {
      return Bridging.FunctionAllocation.CreateFunction(func);
    }
    #endregion

    #region Bridging.ConstructorsAndPrototypes
    public static JavaScriptValue CreateConstructor(
      Type type,
      Action<JavaScriptValue[]> action,
      out JavaScriptValue prototype,
      bool dontExtend = false
    ) {
      return Bridging.ConstructorsAndPrototypes.CreateConstructor(type, action, out prototype, dontExtend);
    }

    public static JavaScriptValue CreateConstructor(
      Type type,
      Func<JavaScriptValue[], JavaScriptValue> func,
      out JavaScriptValue prototype,
      bool dontExtend = false
    ) {
      return Bridging.ConstructorsAndPrototypes.CreateConstructor(type, func, out prototype, dontExtend);
    }

    public static System.Type GetType(string typeName) {
      return Bridging.ConstructorsAndPrototypes.GetType(typeName);
    }

    public static System.Type GetType(JavaScriptValue constructor) {
      return Bridging.ConstructorsAndPrototypes.GetType(constructor);
    }

    public static JavaScriptValue GetPrototype(string typeName) {
      return Bridging.ConstructorsAndPrototypes.GetPrototype(typeName);
    }
    #endregion

    #region Bridging.Externals

    public class Box<T> {
      public T wrapped;
      public Box(T wrapped) { this.wrapped = wrapped; }
    }

    public static Action<JavaScriptValue[]> WithExternal<T>(Action<T, JavaScriptValue[]> action) {
      return Bridging.Externals.WithExternal<T>(action);
    }
    public static Func<JavaScriptValue[], JavaScriptValue> WithExternal<T>(Func<T, JavaScriptValue[], JavaScriptValue> func) {
      return Bridging.Externals.WithExternal<T>(func);
    }
    public static Action<JavaScriptValue[]> WithBoxedExternal<T>(Action<Box<T>, JavaScriptValue[]> action) {
      return Bridging.Externals.WithBoxedExternal<T>(action);
    }
    public static Func<JavaScriptValue[], JavaScriptValue> WithBoxedExternal<T>(Func<Box<T>, JavaScriptValue[], JavaScriptValue> func) {
      return Bridging.Externals.WithBoxedExternal<T>(func);
    }
    public static Action<JavaScriptValue[]> WithExternal<T>(uint argsIndex, Action<T, JavaScriptValue[]> action) {
      return Bridging.Externals.WithExternal<T>(argsIndex, action);
    }
    public static Func<JavaScriptValue[], JavaScriptValue> WithExternal<T>(uint argsIndex, Func<T, JavaScriptValue[], JavaScriptValue> func) {
      return Bridging.Externals.WithExternal(argsIndex, func);
    }

    public static T GetExternal<T>(JavaScriptValue jsValue) {
      return Bridging.Externals.GetExternal<T>(jsValue);
    }
    public static Box<T> GetBoxedExternal<T>(JavaScriptValue jsValue) {
      return Bridging.Externals.GetBoxedExternal<T>(jsValue);
    }

    public static JavaScriptValue CreateExternalWithPrototype<T>(T obj, Action onFree = null) {
      return Bridging.Externals.CreateExternalWithPrototype<T>(obj, onFree);
    }

    public static JavaScriptValue CreateExternalWithPrototype<T>(T obj, JavaScriptValue prototype, Action onFree = null) {
      return Bridging.Externals.CreateExternalWithPrototype<T>(obj, prototype, onFree);
    }

    #endregion

    #region Bridging.GetterSetterHelpers

    public static void DefineGetter(
      JavaScriptValue obj,
      string keyName,
      Func<JavaScriptValue[], JavaScriptValue> callback
    ) {
      Bridging.GetterSetterHelpers.DefineGetter(obj, keyName, callback);
    }

    public static void DefineGetterSetter(
      JavaScriptValue obj,
      string keyName,
      Func<JavaScriptValue[], JavaScriptValue> callbackGetter,
      Action<JavaScriptValue[]> callbackSetter
    ) {
      Bridging.GetterSetterHelpers.DefineGetterSetter(obj, keyName, callbackGetter, callbackSetter);
    }

    #endregion

    public static void Stop() {
      Bridging.FunctionAllocation.FreeAll();
    }
  }
}
