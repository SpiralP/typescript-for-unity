using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSPhysicMaterial {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue PhysicMaterialPrototype;
      JavaScriptValue PhysicMaterialConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.PhysicMaterial),
        (args) => { throw new System.NotImplementedException(); },
        out PhysicMaterialPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("PhysicMaterial", PhysicMaterialConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        PhysicMaterialPrototype,
        "bounciness",
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => JavaScriptValue.FromDouble(o.bounciness)),
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => { o.bounciness = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        PhysicMaterialPrototype,
        "dynamicFriction",
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => JavaScriptValue.FromDouble(o.dynamicFriction)),
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => { o.dynamicFriction = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        PhysicMaterialPrototype,
        "staticFriction",
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => JavaScriptValue.FromDouble(o.staticFriction)),
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => { o.staticFriction = (float) args[1].ToDouble(); })
      );


      Bridge.DefineGetterSetter(
        PhysicMaterialPrototype,
        "frictionCombine",
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => Bridge.CreateExternalWithPrototype(o.frictionCombine)),
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => { o.frictionCombine = Bridge.GetExternal<UnityEngine.PhysicMaterialCombine>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        PhysicMaterialPrototype,
        "bounceCombine",
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => Bridge.CreateExternalWithPrototype(o.bounceCombine)),
        Bridge.WithExternal<UnityEngine.PhysicMaterial>((o, args) => { o.bounceCombine = Bridge.GetExternal<UnityEngine.PhysicMaterialCombine>(args[1]); })
      );


      // Instance Methods

    }
  }
}
