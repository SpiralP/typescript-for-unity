using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSCursor {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue CursorPrototype;
      JavaScriptValue CursorConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Cursor),
        (args) => { throw new System.NotImplementedException(); },
        out CursorPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Cursor", CursorConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetterSetter(
        CursorConstructor,
        "visible",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Cursor.visible),
        (args) => { UnityEngine.Cursor.visible = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        CursorConstructor,
        "lockState",
        (args) => {
          var lockState = UnityEngine.Cursor.lockState;
          var enumName = "";
          switch (UnityEngine.Cursor.lockState) {
            case UnityEngine.CursorLockMode.None:
            enumName = "None";
            break;
            case UnityEngine.CursorLockMode.Locked:
            enumName = "Locked";
            break;
            case UnityEngine.CursorLockMode.Confined:
            enumName = "Confined";
            break;
          }

          // We return the CursorLockMode object from the JS side so that the
          // values are `===` to each other in JS-side checks.
          return JavaScriptValue
            .GlobalObject
            .GetProperty("UnityEngine")
            .GetProperty("CursorLockMode").GetProperty(enumName);
        },
        (args) => { UnityEngine.Cursor.lockState = Bridge.GetExternal<UnityEngine.CursorLockMode>(args[1]); }
      );


      // Static Methods

      CursorConstructor.SetProperty(
        "SetCursor",
        Bridge.CreateFunction(
          "SetCursor",
          (args) => UnityEngine.Cursor.SetCursor(Bridge.GetExternal<UnityEngine.Texture2D>(args[1]), Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.CursorMode>(args[3]))
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
