using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSKeyCode {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue KeyCodePrototype;
      JavaScriptValue KeyCodeConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.KeyCode),
        (args) => { throw new System.NotImplementedException(); },
        out KeyCodePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("KeyCode", KeyCodeConstructor);


      // Static Fields

      KeyCodeConstructor.SetProperty(
        "None",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.None)
      );


      KeyCodeConstructor.SetProperty(
        "Backspace",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Backspace)
      );


      KeyCodeConstructor.SetProperty(
        "Delete",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Delete)
      );


      KeyCodeConstructor.SetProperty(
        "Tab",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Tab)
      );


      KeyCodeConstructor.SetProperty(
        "Clear",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Clear)
      );


      KeyCodeConstructor.SetProperty(
        "Return",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Return)
      );


      KeyCodeConstructor.SetProperty(
        "Pause",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Pause)
      );


      KeyCodeConstructor.SetProperty(
        "Escape",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Escape)
      );


      KeyCodeConstructor.SetProperty(
        "Space",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Space)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad0)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad1)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad2)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad3)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad4)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad5)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad6)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad7)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad8)
      );


      KeyCodeConstructor.SetProperty(
        "Keypad9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Keypad9)
      );


      KeyCodeConstructor.SetProperty(
        "KeypadPeriod",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.KeypadPeriod)
      );


      KeyCodeConstructor.SetProperty(
        "KeypadDivide",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.KeypadDivide)
      );


      KeyCodeConstructor.SetProperty(
        "KeypadMultiply",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.KeypadMultiply)
      );


      KeyCodeConstructor.SetProperty(
        "KeypadMinus",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.KeypadMinus)
      );


      KeyCodeConstructor.SetProperty(
        "KeypadPlus",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.KeypadPlus)
      );


      KeyCodeConstructor.SetProperty(
        "KeypadEnter",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.KeypadEnter)
      );


      KeyCodeConstructor.SetProperty(
        "KeypadEquals",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.KeypadEquals)
      );


      KeyCodeConstructor.SetProperty(
        "UpArrow",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.UpArrow)
      );


      KeyCodeConstructor.SetProperty(
        "DownArrow",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.DownArrow)
      );


      KeyCodeConstructor.SetProperty(
        "RightArrow",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightArrow)
      );


      KeyCodeConstructor.SetProperty(
        "LeftArrow",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftArrow)
      );


      KeyCodeConstructor.SetProperty(
        "Insert",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Insert)
      );


      KeyCodeConstructor.SetProperty(
        "Home",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Home)
      );


      KeyCodeConstructor.SetProperty(
        "End",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.End)
      );


      KeyCodeConstructor.SetProperty(
        "PageUp",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.PageUp)
      );


      KeyCodeConstructor.SetProperty(
        "PageDown",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.PageDown)
      );


      KeyCodeConstructor.SetProperty(
        "F1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F1)
      );


      KeyCodeConstructor.SetProperty(
        "F2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F2)
      );


      KeyCodeConstructor.SetProperty(
        "F3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F3)
      );


      KeyCodeConstructor.SetProperty(
        "F4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F4)
      );


      KeyCodeConstructor.SetProperty(
        "F5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F5)
      );


      KeyCodeConstructor.SetProperty(
        "F6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F6)
      );


      KeyCodeConstructor.SetProperty(
        "F7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F7)
      );


      KeyCodeConstructor.SetProperty(
        "F8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F8)
      );


      KeyCodeConstructor.SetProperty(
        "F9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F9)
      );


      KeyCodeConstructor.SetProperty(
        "F10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F10)
      );


      KeyCodeConstructor.SetProperty(
        "F11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F11)
      );


      KeyCodeConstructor.SetProperty(
        "F12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F12)
      );


      KeyCodeConstructor.SetProperty(
        "F13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F13)
      );


      KeyCodeConstructor.SetProperty(
        "F14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F14)
      );


      KeyCodeConstructor.SetProperty(
        "F15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F15)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha0)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha1)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha2)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha3)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha4)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha5)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha6)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha7)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha8)
      );


      KeyCodeConstructor.SetProperty(
        "Alpha9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Alpha9)
      );


      KeyCodeConstructor.SetProperty(
        "Exclaim",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Exclaim)
      );


      KeyCodeConstructor.SetProperty(
        "DoubleQuote",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.DoubleQuote)
      );


      KeyCodeConstructor.SetProperty(
        "Hash",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Hash)
      );


      KeyCodeConstructor.SetProperty(
        "Dollar",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Dollar)
      );


      KeyCodeConstructor.SetProperty(
        "Ampersand",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Ampersand)
      );


      KeyCodeConstructor.SetProperty(
        "Quote",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Quote)
      );


      KeyCodeConstructor.SetProperty(
        "LeftParen",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftParen)
      );


      KeyCodeConstructor.SetProperty(
        "RightParen",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightParen)
      );


      KeyCodeConstructor.SetProperty(
        "Asterisk",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Asterisk)
      );


      KeyCodeConstructor.SetProperty(
        "Plus",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Plus)
      );


      KeyCodeConstructor.SetProperty(
        "Comma",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Comma)
      );


      KeyCodeConstructor.SetProperty(
        "Minus",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Minus)
      );


      KeyCodeConstructor.SetProperty(
        "Period",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Period)
      );


      KeyCodeConstructor.SetProperty(
        "Slash",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Slash)
      );


      KeyCodeConstructor.SetProperty(
        "Colon",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Colon)
      );


      KeyCodeConstructor.SetProperty(
        "Semicolon",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Semicolon)
      );


      KeyCodeConstructor.SetProperty(
        "Less",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Less)
      );


      KeyCodeConstructor.SetProperty(
        "Equals",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Equals)
      );


      KeyCodeConstructor.SetProperty(
        "Greater",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Greater)
      );


      KeyCodeConstructor.SetProperty(
        "Question",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Question)
      );


      KeyCodeConstructor.SetProperty(
        "At",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.At)
      );


      KeyCodeConstructor.SetProperty(
        "LeftBracket",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftBracket)
      );


      KeyCodeConstructor.SetProperty(
        "Backslash",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Backslash)
      );


      KeyCodeConstructor.SetProperty(
        "RightBracket",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightBracket)
      );


      KeyCodeConstructor.SetProperty(
        "Caret",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Caret)
      );


      KeyCodeConstructor.SetProperty(
        "Underscore",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Underscore)
      );


      KeyCodeConstructor.SetProperty(
        "BackQuote",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.BackQuote)
      );


      KeyCodeConstructor.SetProperty(
        "A",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.A)
      );


      KeyCodeConstructor.SetProperty(
        "B",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.B)
      );


      KeyCodeConstructor.SetProperty(
        "C",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.C)
      );


      KeyCodeConstructor.SetProperty(
        "D",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.D)
      );


      KeyCodeConstructor.SetProperty(
        "E",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.E)
      );


      KeyCodeConstructor.SetProperty(
        "F",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.F)
      );


      KeyCodeConstructor.SetProperty(
        "G",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.G)
      );


      KeyCodeConstructor.SetProperty(
        "H",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.H)
      );


      KeyCodeConstructor.SetProperty(
        "I",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.I)
      );


      KeyCodeConstructor.SetProperty(
        "J",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.J)
      );


      KeyCodeConstructor.SetProperty(
        "K",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.K)
      );


      KeyCodeConstructor.SetProperty(
        "L",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.L)
      );


      KeyCodeConstructor.SetProperty(
        "M",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.M)
      );


      KeyCodeConstructor.SetProperty(
        "N",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.N)
      );


      KeyCodeConstructor.SetProperty(
        "O",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.O)
      );


      KeyCodeConstructor.SetProperty(
        "P",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.P)
      );


      KeyCodeConstructor.SetProperty(
        "Q",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Q)
      );


      KeyCodeConstructor.SetProperty(
        "R",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.R)
      );


      KeyCodeConstructor.SetProperty(
        "S",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.S)
      );


      KeyCodeConstructor.SetProperty(
        "T",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.T)
      );


      KeyCodeConstructor.SetProperty(
        "U",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.U)
      );


      KeyCodeConstructor.SetProperty(
        "V",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.V)
      );


      KeyCodeConstructor.SetProperty(
        "W",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.W)
      );


      KeyCodeConstructor.SetProperty(
        "X",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.X)
      );


      KeyCodeConstructor.SetProperty(
        "Y",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Y)
      );


      KeyCodeConstructor.SetProperty(
        "Z",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Z)
      );


      KeyCodeConstructor.SetProperty(
        "Numlock",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Numlock)
      );


      KeyCodeConstructor.SetProperty(
        "CapsLock",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.CapsLock)
      );


      KeyCodeConstructor.SetProperty(
        "ScrollLock",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.ScrollLock)
      );


      KeyCodeConstructor.SetProperty(
        "RightShift",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightShift)
      );


      KeyCodeConstructor.SetProperty(
        "LeftShift",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftShift)
      );


      KeyCodeConstructor.SetProperty(
        "RightControl",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightControl)
      );


      KeyCodeConstructor.SetProperty(
        "LeftControl",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftControl)
      );


      KeyCodeConstructor.SetProperty(
        "RightAlt",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightAlt)
      );


      KeyCodeConstructor.SetProperty(
        "LeftAlt",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftAlt)
      );


      KeyCodeConstructor.SetProperty(
        "LeftCommand",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftCommand)
      );


      KeyCodeConstructor.SetProperty(
        "LeftApple",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftApple)
      );


      KeyCodeConstructor.SetProperty(
        "LeftWindows",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.LeftWindows)
      );


      KeyCodeConstructor.SetProperty(
        "RightCommand",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightCommand)
      );


      KeyCodeConstructor.SetProperty(
        "RightApple",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightApple)
      );


      KeyCodeConstructor.SetProperty(
        "RightWindows",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.RightWindows)
      );


      KeyCodeConstructor.SetProperty(
        "AltGr",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.AltGr)
      );


      KeyCodeConstructor.SetProperty(
        "Help",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Help)
      );


      KeyCodeConstructor.SetProperty(
        "Print",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Print)
      );


      KeyCodeConstructor.SetProperty(
        "SysReq",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.SysReq)
      );


      KeyCodeConstructor.SetProperty(
        "Break",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Break)
      );


      KeyCodeConstructor.SetProperty(
        "Menu",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Menu)
      );


      KeyCodeConstructor.SetProperty(
        "Mouse0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Mouse0)
      );


      KeyCodeConstructor.SetProperty(
        "Mouse1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Mouse1)
      );


      KeyCodeConstructor.SetProperty(
        "Mouse2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Mouse2)
      );


      KeyCodeConstructor.SetProperty(
        "Mouse3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Mouse3)
      );


      KeyCodeConstructor.SetProperty(
        "Mouse4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Mouse4)
      );


      KeyCodeConstructor.SetProperty(
        "Mouse5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Mouse5)
      );


      KeyCodeConstructor.SetProperty(
        "Mouse6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Mouse6)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton0)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton1)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton2)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton3)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton4)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton5)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton6)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton7)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton8)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton9)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton10)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton11)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton12)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton13)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton14)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton15)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton16)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton17)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton18)
      );


      KeyCodeConstructor.SetProperty(
        "JoystickButton19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.JoystickButton19)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button0)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button1)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button2)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button3)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button4)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button5)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button6)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button7)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button8)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button9)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button10)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button11)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button12)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button13)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button14)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button15)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button16)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button17)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button18)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick1Button19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick1Button19)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button0)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button1)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button2)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button3)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button4)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button5)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button6)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button7)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button8)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button9)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button10)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button11)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button12)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button13)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button14)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button15)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button16)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button17)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button18)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick2Button19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick2Button19)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button0)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button1)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button2)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button3)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button4)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button5)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button6)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button7)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button8)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button9)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button10)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button11)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button12)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button13)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button14)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button15)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button16)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button17)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button18)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick3Button19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick3Button19)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button0)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button1)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button2)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button3)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button4)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button5)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button6)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button7)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button8)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button9)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button10)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button11)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button12)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button13)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button14)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button15)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button16)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button17)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button18)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick4Button19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick4Button19)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button0)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button1)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button2)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button3)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button4)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button5)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button6)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button7)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button8)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button9)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button10)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button11)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button12)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button13)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button14)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button15)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button16)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button17)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button18)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick5Button19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick5Button19)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button0)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button1)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button2)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button3)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button4)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button5)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button6)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button7)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button8)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button9)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button10)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button11)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button12)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button13)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button14)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button15)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button16)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button17)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button18)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick6Button19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick6Button19)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button0)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button1)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button2)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button3)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button4)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button5)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button6)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button7)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button8)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button9)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button10)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button11)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button12)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button13)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button14)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button15)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button16)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button17)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button18)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick7Button19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick7Button19)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button0",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button0)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button1",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button1)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button2",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button2)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button3",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button3)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button4",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button4)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button5",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button5)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button6",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button6)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button7",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button7)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button8",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button8)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button9",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button9)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button10",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button10)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button11",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button11)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button12",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button12)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button13",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button13)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button14",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button14)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button15",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button15)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button16",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button16)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button17",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button17)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button18",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button18)
      );


      KeyCodeConstructor.SetProperty(
        "Joystick8Button19",
        Bridge.CreateExternalWithPrototype(UnityEngine.KeyCode.Joystick8Button19)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
