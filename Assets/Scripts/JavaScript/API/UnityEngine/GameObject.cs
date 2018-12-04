using ChakraCore.API;
using UnityEngine;

namespace JavaScript.API.JSUnityEngine {
  class JSGameObject {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue GameObjectPrototype;
      JavaScriptValue GameObjectConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.GameObject),
        (args) => {
          GameObject obj;

          if (args.Length > 1 && args[1].ValueType == JavaScriptValueType.String)
            obj = new GameObject(args[1].ToString());
          else
            obj = new GameObject();

          return Bridge.CreateExternalWithPrototype(obj);
        },
        out GameObjectPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("GameObject", GameObjectConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      GameObjectConstructor.SetProperty(
        "CreatePrimitive",
        Bridge.CreateFunction(
          "CreatePrimitive",
          (args) => {
            PrimitiveType type;
            switch (args[1].ToString().ToLower()) // TODO lowercase? can these collide?
            {
              case "capsule":
                type = PrimitiveType.Capsule;
                break;
              case "cube":
                type = PrimitiveType.Cube;
                break;
              case "cylinder":
                type = PrimitiveType.Cylinder;
                break;
              case "plane":
                type = PrimitiveType.Plane;
                break;
              case "quad":
                type = PrimitiveType.Quad;
                break;
              case "sphere":
                type = PrimitiveType.Sphere;
                break;
              default:
                throw new System.Exception("invalid type");
            }
            return Bridge.CreateExternalWithPrototype(GameObject.CreatePrimitive(type), GameObjectPrototype);
          }
        )
      );


      GameObjectConstructor.SetProperty(
        "FindWithTag",
        Bridge.CreateFunction(
          "FindWithTag",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GameObject.FindWithTag(args[1].ToString()))
        )
      );


      GameObjectConstructor.SetProperty(
        "FindGameObjectWithTag",
        Bridge.CreateFunction(
          "FindGameObjectWithTag",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GameObject.FindGameObjectWithTag(args[1].ToString()))
        )
      );


      GameObjectConstructor.SetProperty(
        "FindGameObjectsWithTag",
        Bridge.CreateFunction(
          "FindGameObjectsWithTag",
          (args) => { // TODO make an array creator helper
            GameObject[] foundObjects = UnityEngine.GameObject.FindGameObjectsWithTag(args[1].ToString());
            JavaScriptValue jsArray = JavaScriptValue.CreateArray(0);

            for (int i = 0; i < foundObjects.Length; i++) {
              jsArray.SetIndexedProperty(i, Bridge.CreateExternalWithPrototype(foundObjects[i]));
            }

            return jsArray;
          }
        )
      );


      GameObjectConstructor.SetProperty(
        "Find",
        Bridge.CreateFunction(
          "Find",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GameObject.Find(args[1].ToString()))
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        GameObjectPrototype,
        "transform",
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => Bridge.CreateExternalWithPrototype(o.transform))
      );


      Bridge.DefineGetterSetter(
        GameObjectPrototype,
        "layer",
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => JavaScriptValue.FromInt32(o.layer)),
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => { o.layer = args[1].ToInt32(); })
      );


      Bridge.DefineGetter(
        GameObjectPrototype,
        "activeSelf",
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => JavaScriptValue.FromBoolean(o.activeSelf))
      );


      Bridge.DefineGetter(
        GameObjectPrototype,
        "activeInHierarchy",
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => JavaScriptValue.FromBoolean(o.activeInHierarchy))
      );


      Bridge.DefineGetterSetter(
        GameObjectPrototype,
        "isStatic",
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => JavaScriptValue.FromBoolean(o.isStatic)),
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => { o.isStatic = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        GameObjectPrototype,
        "tag",
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => JavaScriptValue.FromString(o.tag)),
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => { o.tag = args[1].ToString(); })
      );


      Bridge.DefineGetter(
        GameObjectPrototype,
        "scene",
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => Bridge.CreateExternalWithPrototype(o.scene))
      );


      Bridge.DefineGetter(
        GameObjectPrototype,
        "gameObject",
        Bridge.WithExternal<UnityEngine.GameObject>((o, args) => Bridge.CreateExternalWithPrototype(o.gameObject))
      );


      // Instance Methods

      GameObjectPrototype.SetProperty("GetComponent", Bridge.CreateFunction(Bridge.WithExternal<UnityEngine.GameObject>((o, args) => {
        string typeName;
        if (args[1].ValueType == JavaScriptValueType.Function) {
          typeName = args[1].GetProperty("name").ToString();
        } else if (args[1].ValueType == JavaScriptValueType.String) {
          typeName = args[1].ToString();
        } else {
          throw new System.Exception("Argument passed to GetComponent must be a class or string");
        }

        System.Type type = Bridge.GetType(typeName);
        JavaScriptValue prototype = Bridge.GetPrototype(typeName);

        return Bridge.CreateExternalWithPrototype(
          o.GetComponent(type),
          prototype
        );
      })));


      GameObjectPrototype.SetProperty(
        "GetComponentInChildren",
        Bridge.CreateFunction(
          "GetComponentInChildren",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => {
            string typeName = args[1].GetProperty("name").ToString();

            System.Type type = Bridge.GetType(typeName);
            JavaScriptValue prototype = Bridge.GetPrototype(typeName);

            if (args.Length == 2) {
              return Bridge.CreateExternalWithPrototype(
                o.GetComponentInChildren(type),
                prototype
              );
            } else {
              return Bridge.CreateExternalWithPrototype(
                o.GetComponentInChildren(type, args[2].ToBoolean()),
                prototype
              );
            }
          })
        )
      );

      GameObjectPrototype.SetProperty(
        "GetComponentInParent",
        Bridge.CreateFunction(
          "GetComponentInParent",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => {
            string typeName = args[1].GetProperty("name").ToString();

            System.Type type = Bridge.GetType(typeName);
            JavaScriptValue prototype = Bridge.GetPrototype(typeName);

            return Bridge.CreateExternalWithPrototype(
              o.GetComponentInParent(type),
              prototype
            );
          })
        )
      );


      GameObjectPrototype.SetProperty(
        "GetComponents",
        Bridge.CreateFunction(
          "GetComponents",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => {
            string typeName = args[1].GetProperty("name").ToString();

            System.Type type = Bridge.GetType(typeName);
            JavaScriptValue prototype = Bridge.GetPrototype(typeName);


            JavaScriptValue array = JavaScriptValue.CreateArray(0);

            foreach (var component in o.GetComponents(type)) {
              array.GetProperty("push").CallFunction(array, Bridge.CreateExternalWithPrototype(
                component,
                prototype
              ));
            }

            return array;
          })
        )
      );


      GameObjectPrototype.SetProperty(
        "GetComponentsInChildren",
        Bridge.CreateFunction(
          "GetComponentsInChildren",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => {
            string typeName = args[1].GetProperty("name").ToString();

            System.Type type = Bridge.GetType(typeName);
            JavaScriptValue prototype = Bridge.GetPrototype(typeName);
            bool includeInactive = args.Length == 3 ? args[2].ToBoolean() : false;

            JavaScriptValue array = JavaScriptValue.CreateArray(0);

            foreach (var component in o.GetComponentsInChildren(type, includeInactive)) {
              array.GetProperty("push").CallFunction(array, Bridge.CreateExternalWithPrototype(
                component,
                prototype
              ));
            }

            return array;
          })
        )
      );


      GameObjectPrototype.SetProperty(
        "GetComponentsInParent",
        Bridge.CreateFunction(
          "GetComponentsInParent",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => {
            string typeName = args[1].GetProperty("name").ToString();

            System.Type type = Bridge.GetType(typeName);
            JavaScriptValue prototype = Bridge.GetPrototype(typeName);
            bool includeInactive = args.Length == 3 ? args[2].ToBoolean() : false;

            JavaScriptValue array = JavaScriptValue.CreateArray(0);

            foreach (var component in o.GetComponentsInParent(type, includeInactive)) {
              array.GetProperty("push").CallFunction(array, Bridge.CreateExternalWithPrototype(
                component,
                prototype
              ));
            }

            return array;
          })
        )
      );


      GameObjectPrototype.SetProperty(
        "SendMessageUpwards",
        Bridge.CreateFunction(
          "SendMessageUpwards",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SendMessageUpwards(args[1].ToString(), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[2])))
        )
      );


      GameObjectPrototype.SetProperty(
        "SendMessage",
        Bridge.CreateFunction(
          "SendMessage",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SendMessage(args[1].ToString(), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[2])))
        )
      );


      GameObjectPrototype.SetProperty(
        "BroadcastMessage",
        Bridge.CreateFunction(
          "BroadcastMessage",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.BroadcastMessage(args[1].ToString(), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[2])))
        )
      );


      GameObjectPrototype.SetProperty(
        "AddComponent",
        Bridge.CreateFunction(
          "AddComponent",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => {
            string typeName = args[1].GetProperty("name").ToString();

            System.Type type = Bridge.GetType(typeName);
            JavaScriptValue prototype = Bridge.GetPrototype(typeName);

            return Bridge.CreateExternalWithPrototype(o.AddComponent(type), prototype);
          })
        )
      );


      /*
        GameObject AddComponent
        method has generics
      */


      GameObjectPrototype.SetProperty(
        "SetActive",
        Bridge.CreateFunction(
          "SetActive",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SetActive(args[1].ToBoolean()))
        )
      );


      GameObjectPrototype.SetProperty(
        "CompareTag",
        Bridge.CreateFunction(
          "CompareTag",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => JavaScriptValue.FromBoolean(o.CompareTag(args[1].ToString())))
        )
      );


      GameObjectPrototype.SetProperty(
        "SendMessageUpwards",
        Bridge.CreateFunction(
          "SendMessageUpwards",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SendMessageUpwards(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2]), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[3])))
        )
      );


      GameObjectPrototype.SetProperty(
        "SendMessageUpwards",
        Bridge.CreateFunction(
          "SendMessageUpwards",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SendMessageUpwards(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2])))
        )
      );


      GameObjectPrototype.SetProperty(
        "SendMessageUpwards",
        Bridge.CreateFunction(
          "SendMessageUpwards",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SendMessageUpwards(args[1].ToString()))
        )
      );


      GameObjectPrototype.SetProperty(
        "SendMessage",
        Bridge.CreateFunction(
          "SendMessage",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SendMessage(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2]), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[3])))
        )
      );


      GameObjectPrototype.SetProperty(
        "SendMessage",
        Bridge.CreateFunction(
          "SendMessage",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SendMessage(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2])))
        )
      );


      GameObjectPrototype.SetProperty(
        "SendMessage",
        Bridge.CreateFunction(
          "SendMessage",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.SendMessage(args[1].ToString()))
        )
      );


      GameObjectPrototype.SetProperty(
        "BroadcastMessage",
        Bridge.CreateFunction(
          "BroadcastMessage",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.BroadcastMessage(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2]), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[3])))
        )
      );


      GameObjectPrototype.SetProperty(
        "BroadcastMessage",
        Bridge.CreateFunction(
          "BroadcastMessage",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.BroadcastMessage(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2])))
        )
      );


      GameObjectPrototype.SetProperty(
        "BroadcastMessage",
        Bridge.CreateFunction(
          "BroadcastMessage",
          Bridge.WithExternal<UnityEngine.GameObject>((o, args) => o.BroadcastMessage(args[1].ToString()))
        )
      );


    }
  }
}
