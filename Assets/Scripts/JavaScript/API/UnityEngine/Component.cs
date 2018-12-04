using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSComponent {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue ComponentPrototype;
      JavaScriptValue ComponentConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Component),
        (args) => { throw new System.NotImplementedException(); },
        out ComponentPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Component", ComponentConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetter(
        ComponentPrototype,
        "transform",
        Bridge.WithExternal<UnityEngine.Component>((o, args) => Bridge.CreateExternalWithPrototype(o.transform))
      );


      Bridge.DefineGetter(
        ComponentPrototype,
        "gameObject",
        Bridge.WithExternal<UnityEngine.Component>((o, args) => Bridge.CreateExternalWithPrototype(o.gameObject))
      );


      Bridge.DefineGetterSetter(
        ComponentPrototype,
        "tag",
        Bridge.WithExternal<UnityEngine.Component>((o, args) => JavaScriptValue.FromString(o.tag)),
        Bridge.WithExternal<UnityEngine.Component>((o, args) => { o.tag = args[1].ToString(); })
      );


      // Instance Methods

      ComponentPrototype.SetProperty("GetComponent", Bridge.CreateFunction(Bridge.WithExternal<UnityEngine.Component>((o, args) => {
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


      ComponentPrototype.SetProperty(
        "GetComponentInChildren",
        Bridge.CreateFunction(
          "GetComponentInChildren",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => {
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

      ComponentPrototype.SetProperty(
        "GetComponentInParent",
        Bridge.CreateFunction(
          "GetComponentInParent",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => {
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


      ComponentPrototype.SetProperty(
        "GetComponents",
        Bridge.CreateFunction(
          "GetComponents",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => {
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


      ComponentPrototype.SetProperty(
        "GetComponentsInChildren",
        Bridge.CreateFunction(
          "GetComponentsInChildren",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => {
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


      ComponentPrototype.SetProperty(
        "GetComponentsInParent",
        Bridge.CreateFunction(
          "GetComponentsInParent",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => {
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


      ComponentPrototype.SetProperty(
        "CompareTag",
        Bridge.CreateFunction(
          "CompareTag",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => JavaScriptValue.FromBoolean(o.CompareTag(args[1].ToString())))
        )
      );


      ComponentPrototype.SetProperty(
        "SendMessageUpwards",
        Bridge.CreateFunction(
          "SendMessageUpwards",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.SendMessageUpwards(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2]), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[3])))
        )
      );


      ComponentPrototype.SetProperty(
        "SendMessageUpwards",
        Bridge.CreateFunction(
          "SendMessageUpwards",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.SendMessageUpwards(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2])))
        )
      );


      ComponentPrototype.SetProperty(
        "SendMessageUpwards",
        Bridge.CreateFunction(
          "SendMessageUpwards",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.SendMessageUpwards(args[1].ToString()))
        )
      );


      ComponentPrototype.SetProperty(
        "SendMessageUpwards",
        Bridge.CreateFunction(
          "SendMessageUpwards",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.SendMessageUpwards(args[1].ToString(), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[2])))
        )
      );


      ComponentPrototype.SetProperty(
        "SendMessage",
        Bridge.CreateFunction(
          "SendMessage",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.SendMessage(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2])))
        )
      );


      ComponentPrototype.SetProperty(
        "SendMessage",
        Bridge.CreateFunction(
          "SendMessage",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.SendMessage(args[1].ToString()))
        )
      );


      ComponentPrototype.SetProperty(
        "SendMessage",
        Bridge.CreateFunction(
          "SendMessage",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.SendMessage(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2]), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[3])))
        )
      );


      ComponentPrototype.SetProperty(
        "SendMessage",
        Bridge.CreateFunction(
          "SendMessage",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.SendMessage(args[1].ToString(), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[2])))
        )
      );


      ComponentPrototype.SetProperty(
        "BroadcastMessage",
        Bridge.CreateFunction(
          "BroadcastMessage",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.BroadcastMessage(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2]), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[3])))
        )
      );


      ComponentPrototype.SetProperty(
        "BroadcastMessage",
        Bridge.CreateFunction(
          "BroadcastMessage",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.BroadcastMessage(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2])))
        )
      );


      ComponentPrototype.SetProperty(
        "BroadcastMessage",
        Bridge.CreateFunction(
          "BroadcastMessage",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.BroadcastMessage(args[1].ToString()))
        )
      );


      ComponentPrototype.SetProperty(
        "BroadcastMessage",
        Bridge.CreateFunction(
          "BroadcastMessage",
          Bridge.WithExternal<UnityEngine.Component>((o, args) => o.BroadcastMessage(args[1].ToString(), Bridge.GetExternal<UnityEngine.SendMessageOptions>(args[2])))
        )
      );


    }
  }
}
