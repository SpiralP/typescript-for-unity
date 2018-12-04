using ChakraCore.API;

namespace JavaScript.API.JSSystem.Collections {
  class JSSystemCollections {
    public static void Register(JavaScriptContext context) {
      var SystemCollectionsGlobal = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.GetProperty("System").SetProperty("Collections", SystemCollectionsGlobal);

      JSIEnumerator.Register(context);
      JSIEnumerable.Register(context); // this might conflict with the magic prototype parent finder

    }
  }
}
