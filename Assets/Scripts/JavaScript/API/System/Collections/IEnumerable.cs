using ChakraCore.API;

namespace JavaScript.API.JSSystem.Collections {
  class JSIEnumerable {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue IEnumerablePrototype;
      JavaScriptValue IEnumerableConstructor = Bridge.CreateConstructor(
        typeof(System.Collections.IEnumerable),
        (args) => { throw new System.NotImplementedException(); },
        out IEnumerablePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("System")
        .GetProperty("Collections")
        .SetProperty("IEnumerable", IEnumerableConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

      IEnumerablePrototype.SetProperty(
        "GetEnumerator",
        Bridge.CreateFunction(
          "GetEnumerator",
          Bridge.WithExternal<System.Collections.IEnumerable>((o, args) => Bridge.CreateExternalWithPrototype(o.GetEnumerator()))
        )
      );


      IEnumerablePrototype.SetProperty(
        JavaScriptValue.GlobalObject.GetProperty("Symbol").GetProperty("iterator").GetPropertyIdFromSymbol(),
        Bridge.CreateFunction(
          "Iterator",
          Bridge.WithExternal<System.Collections.IEnumerable>((o, args) => {
            JavaScriptValue iteratorObj = Bridge.CreateExternalWithPrototype(o.GetEnumerator());

            iteratorObj.SetProperty("next", Bridge.CreateFunction(Bridge.WithExternal<System.Collections.IEnumerator>((enumerator, nextArgs) => {
              // returns { value: "h", done: false }
              JavaScriptValue nextObj = JavaScriptValue.CreateObject();

              bool more = enumerator.MoveNext();
              nextObj.SetProperty("done", JavaScriptValue.FromBoolean(!more));

              JavaScriptValue value = JavaScriptValue.Undefined;
              if (more) {
                value = Bridge.CreateExternalWithPrototype(enumerator.Current);
              }
              nextObj.SetProperty("value", value);

              return nextObj;
            })));

            return iteratorObj;
          })
        )
      );

    }
  }
}
