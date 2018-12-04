using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSMonoBehaviour {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue MonoBehaviourPrototype;
      JavaScriptValue MonoBehaviourConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.MonoBehaviour),
        (args) => { throw new System.NotImplementedException(); },
        out MonoBehaviourPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("MonoBehaviour", MonoBehaviourConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods

      MonoBehaviourConstructor.SetProperty(
        "print",
        Bridge.CreateFunction(
          "print",
          (args) => UnityEngine.MonoBehaviour.print(Bridge.GetExternal<System.Object>(args[1]))
        )
      );


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        MonoBehaviourPrototype,
        "useGUILayout",
        Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.useGUILayout)),
        Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => { o.useGUILayout = args[1].ToBoolean(); })
      );


#if UNITY_EDITOR
      Bridge.DefineGetterSetter(
        MonoBehaviourPrototype,
        "runInEditMode",
        Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.runInEditMode)),
        Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => { o.runInEditMode = args[1].ToBoolean(); })
      );
#endif


      // Instance Methods

      MonoBehaviourPrototype.SetProperty(
        "IsInvoking",
        Bridge.CreateFunction(
          "IsInvoking",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.IsInvoking()))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "CancelInvoke",
        Bridge.CreateFunction(
          "CancelInvoke",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => o.CancelInvoke())
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "Invoke",
        Bridge.CreateFunction(
          "Invoke",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => o.Invoke(args[1].ToString(), (float) args[2].ToDouble()))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "InvokeRepeating",
        Bridge.CreateFunction(
          "InvokeRepeating",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => o.InvokeRepeating(args[1].ToString(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "CancelInvoke",
        Bridge.CreateFunction(
          "CancelInvoke",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => o.CancelInvoke(args[1].ToString()))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "IsInvoking",
        Bridge.CreateFunction(
          "IsInvoking",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => JavaScriptValue.FromBoolean(o.IsInvoking(args[1].ToString())))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "StartCoroutine",
        Bridge.CreateFunction(
          "StartCoroutine",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => Bridge.CreateExternalWithPrototype(o.StartCoroutine(args[1].ToString())))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "StartCoroutine",
        Bridge.CreateFunction(
          "StartCoroutine",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => Bridge.CreateExternalWithPrototype(o.StartCoroutine(args[1].ToString(), Bridge.GetExternal<System.Object>(args[2]))))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "StartCoroutine",
        Bridge.CreateFunction(
          "StartCoroutine",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => Bridge.CreateExternalWithPrototype(o.StartCoroutine(Bridge.GetExternal<System.Collections.IEnumerator>(args[1]))))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "StopCoroutine",
        Bridge.CreateFunction(
          "StopCoroutine",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => o.StopCoroutine(Bridge.GetExternal<System.Collections.IEnumerator>(args[1])))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "StopCoroutine",
        Bridge.CreateFunction(
          "StopCoroutine",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => o.StopCoroutine(Bridge.GetExternal<UnityEngine.Coroutine>(args[1])))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "StopCoroutine",
        Bridge.CreateFunction(
          "StopCoroutine",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => o.StopCoroutine(args[1].ToString()))
        )
      );


      MonoBehaviourPrototype.SetProperty(
        "StopAllCoroutines",
        Bridge.CreateFunction(
          "StopAllCoroutines",
          Bridge.WithExternal<UnityEngine.MonoBehaviour>((o, args) => o.StopAllCoroutines())
        )
      );


    }
  }
}
