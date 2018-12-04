using ChakraCore.API;

namespace JavaScript.API.JSSystem.Collections {
  class JSIEnumerator {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue IEnumeratorPrototype;
      JavaScriptValue IEnumeratorConstructor = Bridge.CreateConstructor(
        typeof(System.Collections.IEnumerator),
        (args) => { throw new System.NotImplementedException(); },
        out IEnumeratorPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("System")
        .GetProperty("Collections")
        .SetProperty("IEnumerator", IEnumeratorConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        IEnumeratorPrototype,
        "Current",
        Bridge.WithExternal<System.Collections.IEnumerator>((o, args) => Bridge.CreateExternalWithPrototype(o.Current))
      );


      // Instance Methods

      IEnumeratorPrototype.SetProperty(
        "MoveNext",
        Bridge.CreateFunction(
          "MoveNext",
          Bridge.WithExternal<System.Collections.IEnumerator>((o, args) => JavaScriptValue.FromBoolean(o.MoveNext()))
        )
      );


      IEnumeratorPrototype.SetProperty(
        "Reset",
        Bridge.CreateFunction(
          "Reset",
          Bridge.WithExternal<System.Collections.IEnumerator>((o, args) => o.Reset())
        )
      );


    }
  }
}
