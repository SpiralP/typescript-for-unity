using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSInput {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue InputPrototype;
      JavaScriptValue InputConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Input),
        (args) => { throw new System.NotImplementedException(); },
        out InputPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Input", InputConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetterSetter(
        InputConstructor,
        "compensateSensors",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.compensateSensors),
        (args) => { UnityEngine.Input.compensateSensors = args[1].ToBoolean(); }
      );


      Bridge.DefineGetter(
        InputConstructor,
        "gyro",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.gyro)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "mousePosition",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.mousePosition)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "mouseScrollDelta",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.mouseScrollDelta)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "mousePresent",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.mousePresent)
      );


      Bridge.DefineGetterSetter(
        InputConstructor,
        "simulateMouseWithTouches",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.simulateMouseWithTouches),
        (args) => { UnityEngine.Input.simulateMouseWithTouches = args[1].ToBoolean(); }
      );


      Bridge.DefineGetter(
        InputConstructor,
        "anyKey",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.anyKey)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "anyKeyDown",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.anyKeyDown)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "inputString",
        (args) => JavaScriptValue.FromString(UnityEngine.Input.inputString)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "acceleration",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.acceleration)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "accelerationEvents",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.accelerationEvents)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "accelerationEventCount",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Input.accelerationEventCount)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "touches",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.touches)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "touchCount",
        (args) => JavaScriptValue.FromInt32(UnityEngine.Input.touchCount)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "touchPressureSupported",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.touchPressureSupported)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "stylusTouchSupported",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.stylusTouchSupported)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "touchSupported",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.touchSupported)
      );


      Bridge.DefineGetterSetter(
        InputConstructor,
        "multiTouchEnabled",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.multiTouchEnabled),
        (args) => { UnityEngine.Input.multiTouchEnabled = args[1].ToBoolean(); }
      );


      Bridge.DefineGetter(
        InputConstructor,
        "location",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.location)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "compass",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.compass)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "deviceOrientation",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.deviceOrientation)
      );


      Bridge.DefineGetterSetter(
        InputConstructor,
        "imeCompositionMode",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.imeCompositionMode),
        (args) => { UnityEngine.Input.imeCompositionMode = Bridge.GetExternal<UnityEngine.IMECompositionMode>(args[1]); }
      );


      Bridge.DefineGetter(
        InputConstructor,
        "compositionString",
        (args) => JavaScriptValue.FromString(UnityEngine.Input.compositionString)
      );


      Bridge.DefineGetter(
        InputConstructor,
        "imeIsSelected",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.imeIsSelected)
      );


      Bridge.DefineGetterSetter(
        InputConstructor,
        "compositionCursorPos",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.compositionCursorPos),
        (args) => { UnityEngine.Input.compositionCursorPos = Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped; }
      );


      Bridge.DefineGetterSetter(
        InputConstructor,
        "backButtonLeavesApp",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.backButtonLeavesApp),
        (args) => { UnityEngine.Input.backButtonLeavesApp = args[1].ToBoolean(); }
      );


      // Static Methods

      InputConstructor.SetProperty(
        "GetAxis",
        Bridge.CreateFunction(
          "GetAxis",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Input.GetAxis(args[1].ToString()))
        )
      );


      InputConstructor.SetProperty(
        "GetAxisRaw",
        Bridge.CreateFunction(
          "GetAxisRaw",
          (args) => JavaScriptValue.FromDouble(UnityEngine.Input.GetAxisRaw(args[1].ToString()))
        )
      );


      InputConstructor.SetProperty(
        "GetButton",
        Bridge.CreateFunction(
          "GetButton",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.GetButton(args[1].ToString()))
        )
      );


      InputConstructor.SetProperty(
        "GetButtonDown",
        Bridge.CreateFunction(
          "GetButtonDown",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.GetButtonDown(args[1].ToString()))
        )
      );


      InputConstructor.SetProperty(
        "GetButtonUp",
        Bridge.CreateFunction(
          "GetButtonUp",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.GetButtonUp(args[1].ToString()))
        )
      );


      InputConstructor.SetProperty(
        "GetKey",
        Bridge.CreateFunction(
          "GetKey",
          (args) => {
            if (args[1].ValueType == JavaScriptValueType.String)
              return JavaScriptValue.FromBoolean(UnityEngine.Input.GetKey(args[1].ToString()));
            else
              return JavaScriptValue.FromBoolean(UnityEngine.Input.GetKey(Bridge.GetExternal<UnityEngine.KeyCode>(args[1])));
          }
        )
      );


      InputConstructor.SetProperty(
        "GetKeyDown",
        Bridge.CreateFunction(
          "GetKeyDown",
          (args) => {
            if (args[1].ValueType == JavaScriptValueType.String)
              return JavaScriptValue.FromBoolean(UnityEngine.Input.GetKeyDown(args[1].ToString()));
            else
              return JavaScriptValue.FromBoolean(UnityEngine.Input.GetKeyDown(Bridge.GetExternal<UnityEngine.KeyCode>(args[1])));
          }
        )
      );


      InputConstructor.SetProperty(
        "GetKeyUp",
        Bridge.CreateFunction(
          "GetKeyUp",
          (args) => {
            if (args[1].ValueType == JavaScriptValueType.String)
              return JavaScriptValue.FromBoolean(UnityEngine.Input.GetKeyUp(args[1].ToString()));
            else
              return JavaScriptValue.FromBoolean(UnityEngine.Input.GetKeyUp(Bridge.GetExternal<UnityEngine.KeyCode>(args[1])));
          }
        )
      );


      InputConstructor.SetProperty(
        "GetJoystickNames",
        Bridge.CreateFunction(
          "GetJoystickNames",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.GetJoystickNames())
        )
      );


#if UNITY_EDITOR
      InputConstructor.SetProperty(
        "IsJoystickPreconfigured",
        Bridge.CreateFunction(
          "IsJoystickPreconfigured",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.IsJoystickPreconfigured(args[1].ToString()))
        )
      );
#endif


      InputConstructor.SetProperty(
        "GetMouseButton",
        Bridge.CreateFunction(
          "GetMouseButton",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.GetMouseButton(args[1].ToInt32()))
        )
      );


      InputConstructor.SetProperty(
        "GetMouseButtonDown",
        Bridge.CreateFunction(
          "GetMouseButtonDown",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.GetMouseButtonDown(args[1].ToInt32()))
        )
      );


      InputConstructor.SetProperty(
        "GetMouseButtonUp",
        Bridge.CreateFunction(
          "GetMouseButtonUp",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.Input.GetMouseButtonUp(args[1].ToInt32()))
        )
      );


      InputConstructor.SetProperty(
        "ResetInputAxes",
        Bridge.CreateFunction(
          "ResetInputAxes",
          (args) => UnityEngine.Input.ResetInputAxes()
        )
      );


      InputConstructor.SetProperty(
        "GetAccelerationEvent",
        Bridge.CreateFunction(
          "GetAccelerationEvent",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.GetAccelerationEvent(args[1].ToInt32()))
        )
      );


      InputConstructor.SetProperty(
        "GetTouch",
        Bridge.CreateFunction(
          "GetTouch",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.Input.GetTouch(args[1].ToInt32()))
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
