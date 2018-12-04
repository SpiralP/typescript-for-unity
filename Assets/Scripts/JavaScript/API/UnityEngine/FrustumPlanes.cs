using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSFrustumPlanes {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue FrustumPlanesPrototype;
      JavaScriptValue FrustumPlanesConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.FrustumPlanes),
        (args) => { throw new System.NotImplementedException(); },
        out FrustumPlanesPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("FrustumPlanes", FrustumPlanesConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields

      Bridge.DefineGetterSetter(
        FrustumPlanesPrototype,
        "left",
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => JavaScriptValue.FromDouble(o.wrapped.left)),
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => { o.wrapped.left = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        FrustumPlanesPrototype,
        "right",
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => JavaScriptValue.FromDouble(o.wrapped.right)),
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => { o.wrapped.right = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        FrustumPlanesPrototype,
        "bottom",
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => JavaScriptValue.FromDouble(o.wrapped.bottom)),
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => { o.wrapped.bottom = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        FrustumPlanesPrototype,
        "top",
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => JavaScriptValue.FromDouble(o.wrapped.top)),
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => { o.wrapped.top = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        FrustumPlanesPrototype,
        "zNear",
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => JavaScriptValue.FromDouble(o.wrapped.zNear)),
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => { o.wrapped.zNear = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        FrustumPlanesPrototype,
        "zFar",
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => JavaScriptValue.FromDouble(o.wrapped.zFar)),
        Bridge.WithBoxedExternal<UnityEngine.FrustumPlanes>((o, args) => { o.wrapped.zFar = (float) args[1].ToDouble(); })
      );


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
