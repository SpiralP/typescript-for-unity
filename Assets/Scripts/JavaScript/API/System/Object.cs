using ChakraCore.API;

namespace JavaScript.API.JSSystem {
  class JSObject {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ObjectPrototype;
      JavaScriptValue ObjectConstructor = Bridge.CreateConstructor(
        typeof(System.Object),
        (args) => { throw new System.NotImplementedException(); },
        out ObjectPrototype,
        dontExtend : true
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("System")
        .SetProperty("Object", ObjectConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      ObjectConstructor.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          (args) => JavaScriptValue.FromBoolean(System.Object.Equals(Bridge.GetExternal<System.Object>(args[1]), Bridge.GetExternal<System.Object>(args[2])))
        )
      );


      ObjectConstructor.SetProperty(
        "ReferenceEquals",
        Bridge.CreateFunction(
          "ReferenceEquals",
          (args) => JavaScriptValue.FromBoolean(System.Object.ReferenceEquals(Bridge.GetExternal<System.Object>(args[1]), Bridge.GetExternal<System.Object>(args[2])))
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

      ObjectPrototype.SetProperty(
        "Equals",
        Bridge.CreateFunction(
          "Equals",
          Bridge.WithExternal<System.Object>((o, args) => JavaScriptValue.FromBoolean(o.Equals(Bridge.GetExternal<System.Object>(args[1]))))
        )
      );


      ObjectPrototype.SetProperty(
        "GetHashCode",
        Bridge.CreateFunction(
          "GetHashCode",
          Bridge.WithExternal<System.Object>((o, args) => JavaScriptValue.FromInt32(o.GetHashCode()))
        )
      );


      ObjectPrototype.SetProperty(
        "GetType",
        Bridge.CreateFunction(
          "GetType",
          Bridge.WithExternal<System.Object>((o, args) => Bridge.CreateExternalWithPrototype(o.GetType()))
        )
      );


      ObjectPrototype.SetProperty(
        "toString",
        Bridge.CreateFunction(
          "ToString",
          Bridge.WithExternal<System.Object>((o, args) => JavaScriptValue.FromString(o.ToString()))
        )
      );


    }
  }
}
