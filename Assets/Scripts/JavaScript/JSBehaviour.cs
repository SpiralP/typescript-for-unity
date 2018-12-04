using System;
using ChakraCore.API;
using UnityEngine;

namespace JavaScript {
  public class JSBehaviour : MonoBehaviour {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue JSBehaviourPrototype;
      JavaScriptValue JSBehaviourConstructor = Bridge.CreateConstructor(
        typeof(JavaScript.JSBehaviour),
        (args) => {
          args[0].SetProperty("monoBehaviour", args[1]);
          args[0].SetProperty("_delegates", JavaScriptValue.CreateArray(0));
        },
        out JSBehaviourPrototype
      );
      JavaScriptValue.GlobalObject.SetProperty("JSBehaviour", JSBehaviourConstructor);

      JSBehaviourPrototype.SetProperty(
        "AddDelegate",
        Bridge.CreateFunction(
          "AddDelegate",
          (args) => {
            if (args[1].ValueType != JavaScriptValueType.Object) {
              throw new Exception("Invalid object passed to AddDelegate");
            }
            var _delegates = args[0].GetProperty("_delegates");
            _delegates.GetProperty("push").CallFunction(_delegates, args[1]);
          }
        )
      );

    }

    public string moduleSpecifier = "";
    // private JavaScriptValue? jsClass = null;
    private JavaScriptValue? jsInstance = null;

    void SetupJavaScriptClassInstance() {
      if (jsInstance.HasValue) return;

      Engine.With(() => {
        JavaScriptValue clazz = Engine.Import(
          moduleSpecifier,
          (path) => { // file changed callback
            Debug.Log("reloading " + moduleSpecifier);
            JavaScript.API.UpdateHelper.addOneUpdateHook(() => {
              this.Reload();
            });
          }
        ).GetProperty("default");
        clazz.AddRef();
        // jsClass = clazz;

        JavaScriptValue instance = clazz.ConstructObject(
          JavaScriptValue.Undefined,
          Bridge.CreateExternalWithPrototype(this)
        );
        instance.AddRef();
        jsInstance = instance;
      });
    }

    void Start() {
      if (moduleSpecifier == "") {
        throw new Exception("A JSBehaviour was created with no module specifier. The module specifier is required.");
      }

      this.SetupJavaScriptClassInstance();

      CallInstanceMethod("Start");
    }

    void Update() {
      CallInstanceMethod("Update");
    }

    void FixedUpdate() {
      CallInstanceMethod("FixedUpdate");
    }

    void LateUpdate() {
      CallInstanceMethod("LateUpdate");
    }

    void OnGUI() {
      CallInstanceMethod("OnGUI");
    }

    void OnDisable() {
      CallInstanceMethod("OnDisable");
    }

    void OnEnable() {
      CallInstanceMethod("OnEnable");
    }

    void OnDestroy() {
      CallInstanceMethod("OnDestroy");
    }

    private void CallInstanceMethod(string name) {
      if (!jsInstance.HasValue) { return; }


      Engine.WithIfRunning(() => {
        JavaScriptValue method = jsInstance.Value.GetProperty(name);
        if (method.ValueType == JavaScriptValueType.Function) {
          method.CallFunction(jsInstance.Value);
        }

        JavaScriptValue _delegates = jsInstance.Value.GetProperty("_delegates");
        foreach (JavaScriptValue instance in _delegates.ToList()) {
          JavaScriptValue delegateMethod = instance.GetProperty(name);
          if (delegateMethod.ValueType == JavaScriptValueType.Function) {
            delegateMethod.CallFunction(instance);
          }
        }
      });
    }

    public void Reload() {
      this.OnDestroy();

      // this.jsClass = null;
      this.jsInstance = null;

      this.Start();
    }

    public static void ReloadAll() {
      throw new NotImplementedException();
    }

  }
}
