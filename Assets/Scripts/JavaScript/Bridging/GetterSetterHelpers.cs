using System;
using ChakraCore.API;

namespace JavaScript.Bridging {
  public class GetterSetterHelpers {
    public static void DefineGetter(
      JavaScriptValue obj,
      string keyName,
      Func<JavaScriptValue[], JavaScriptValue> callback
    ) {
      JavaScriptValue descriptor = JavaScriptValue.CreateObject();
      descriptor.SetProperty(
        "get",
        FunctionAllocation.CreateFunction(callback)
      );
      obj.DefineProperty(
        keyName,
        descriptor
      );
    }

    public static void DefineGetterSetter(
      JavaScriptValue obj,
      string keyName,
      Func<JavaScriptValue[], JavaScriptValue> callbackGetter,
      Action<JavaScriptValue[]> callbackSetter
    ) {
      JavaScriptValue descriptor = JavaScriptValue.CreateObject();

      descriptor.SetProperty("get", FunctionAllocation.CreateFunction(callbackGetter));
      descriptor.SetProperty("set", FunctionAllocation.CreateFunction(callbackSetter));

      obj.DefineProperty(
        keyName,
        descriptor
      );
    }
    public static void DefineGetterSetter(
      JavaScriptValue obj,
      string keyName,
      Func<JavaScriptValue[], JavaScriptValue> callbackGetter,
      Func<JavaScriptValue[], JavaScriptValue> callbackSetter
    ) {
      JavaScriptValue descriptor = JavaScriptValue.CreateObject();

      descriptor.SetProperty("get", FunctionAllocation.CreateFunction(callbackGetter));
      descriptor.SetProperty("set", FunctionAllocation.CreateFunction(callbackSetter));

      obj.DefineProperty(
        keyName,
        descriptor
      );
    }
  }
}
