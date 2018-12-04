using ChakraCore.API;

namespace JavaScript.API {
  class DOM {
    public static void Register(JavaScriptContext context) {
      var global = JavaScriptValue.GlobalObject;

      global.SetProperty("global", global);
      global.SetProperty("window", global);

      global.SetProperty(
        "atob",
        Bridge.CreateFunction("atob", (args) => {
          return JavaScriptValue.FromString(
            System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(args[1].ToString()))
          );
        })
      );

      global.SetProperty(
        "btoa",
        Bridge.CreateFunction("btoa", (args) => {
          return JavaScriptValue.FromString(
            System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(args[1].ToString()))
          );
        })
      );


    }
  }
}
