using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSMeshCollider {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue MeshColliderPrototype;
      JavaScriptValue MeshColliderConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.MeshCollider),
        (args) => { throw new System.NotImplementedException(); },
        out MeshColliderPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("MeshCollider", MeshColliderConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        MeshColliderPrototype,
        "sharedMesh",
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => Bridge.CreateExternalWithPrototype(o.sharedMesh)),
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => { o.sharedMesh = Bridge.GetExternal<UnityEngine.Mesh>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshColliderPrototype,
        "convex",
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => JavaScriptValue.FromBoolean(o.convex)),
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => { o.convex = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        MeshColliderPrototype,
        "inflateMesh",
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => JavaScriptValue.FromBoolean(o.inflateMesh)),
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => { o.inflateMesh = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        MeshColliderPrototype,
        "cookingOptions",
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => Bridge.CreateExternalWithPrototype(o.cookingOptions)),
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => { o.cookingOptions = Bridge.GetExternal<UnityEngine.MeshColliderCookingOptions>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MeshColliderPrototype,
        "skinWidth",
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => JavaScriptValue.FromDouble(o.skinWidth)),
        Bridge.WithExternal<UnityEngine.MeshCollider>((o, args) => { o.skinWidth = (float) args[1].ToDouble(); })
      );


      // Instance Methods

    }
  }
}
