using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSGUI {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue GUIPrototype;
      JavaScriptValue GUIConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.GUI),
        (args) => { throw new System.NotImplementedException(); },
        out GUIPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("GUI", GUIConstructor);


      // Static Fields


      // Static Property Accessors

      Bridge.DefineGetterSetter(
        GUIConstructor,
        "color",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.color),
        (args) => { UnityEngine.GUI.color = Bridge.GetBoxedExternal<UnityEngine.Color>(args[1]).wrapped; }
      );


      Bridge.DefineGetterSetter(
        GUIConstructor,
        "backgroundColor",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.backgroundColor),
        (args) => { UnityEngine.GUI.backgroundColor = Bridge.GetBoxedExternal<UnityEngine.Color>(args[1]).wrapped; }
      );


      Bridge.DefineGetterSetter(
        GUIConstructor,
        "contentColor",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.contentColor),
        (args) => { UnityEngine.GUI.contentColor = Bridge.GetBoxedExternal<UnityEngine.Color>(args[1]).wrapped; }
      );


      Bridge.DefineGetterSetter(
        GUIConstructor,
        "changed",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.changed),
        (args) => { UnityEngine.GUI.changed = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        GUIConstructor,
        "enabled",
        (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.enabled),
        (args) => { UnityEngine.GUI.enabled = args[1].ToBoolean(); }
      );


      Bridge.DefineGetterSetter(
        GUIConstructor,
        "depth",
        (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.depth),
        (args) => { UnityEngine.GUI.depth = args[1].ToInt32(); }
      );


      Bridge.DefineGetterSetter(
        GUIConstructor,
        "skin",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.skin),
        (args) => { UnityEngine.GUI.skin = Bridge.GetExternal<UnityEngine.GUISkin>(args[1]); }
      );


      Bridge.DefineGetterSetter(
        GUIConstructor,
        "matrix",
        (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.matrix),
        (args) => { UnityEngine.GUI.matrix = Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[1]).wrapped; }
      );


      Bridge.DefineGetterSetter(
        GUIConstructor,
        "tooltip",
        (args) => JavaScriptValue.FromString(UnityEngine.GUI.tooltip),
        (args) => { UnityEngine.GUI.tooltip = args[1].ToString(); }
      );


      // Static Methods

      GUIConstructor.SetProperty(
        "SetNextControlName",
        Bridge.CreateFunction(
          "SetNextControlName",
          (args) => UnityEngine.GUI.SetNextControlName(args[1].ToString())
        )
      );


      GUIConstructor.SetProperty(
        "GetNameOfFocusedControl",
        Bridge.CreateFunction(
          "GetNameOfFocusedControl",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.GetNameOfFocusedControl())
        )
      );


      GUIConstructor.SetProperty(
        "FocusControl",
        Bridge.CreateFunction(
          "FocusControl",
          (args) => UnityEngine.GUI.FocusControl(args[1].ToString())
        )
      );


      GUIConstructor.SetProperty(
        "DragWindow",
        Bridge.CreateFunction(
          "DragWindow",
          (args) => UnityEngine.GUI.DragWindow(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped)
        )
      );


      GUIConstructor.SetProperty(
        "BringWindowToFront",
        Bridge.CreateFunction(
          "BringWindowToFront",
          (args) => UnityEngine.GUI.BringWindowToFront(args[1].ToInt32())
        )
      );


      GUIConstructor.SetProperty(
        "BringWindowToBack",
        Bridge.CreateFunction(
          "BringWindowToBack",
          (args) => UnityEngine.GUI.BringWindowToBack(args[1].ToInt32())
        )
      );


      GUIConstructor.SetProperty(
        "FocusWindow",
        Bridge.CreateFunction(
          "FocusWindow",
          (args) => UnityEngine.GUI.FocusWindow(args[1].ToInt32())
        )
      );


      GUIConstructor.SetProperty(
        "UnfocusWindow",
        Bridge.CreateFunction(
          "UnfocusWindow",
          (args) => UnityEngine.GUI.UnfocusWindow()
        )
      );


      GUIConstructor.SetProperty(
        "Label",
        Bridge.CreateFunction(
          "Label",
          (args) => UnityEngine.GUI.Label(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString())
        )
      );


      GUIConstructor.SetProperty(
        "Label",
        Bridge.CreateFunction(
          "Label",
          (args) => UnityEngine.GUI.Label(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]))
        )
      );


      GUIConstructor.SetProperty(
        "Label",
        Bridge.CreateFunction(
          "Label",
          (args) => UnityEngine.GUI.Label(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2]))
        )
      );


      GUIConstructor.SetProperty(
        "Label",
        Bridge.CreateFunction(
          "Label",
          (args) => UnityEngine.GUI.Label(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "Label",
        Bridge.CreateFunction(
          "Label",
          (args) => UnityEngine.GUI.Label(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "Label",
        Bridge.CreateFunction(
          "Label",
          (args) => UnityEngine.GUI.Label(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "DrawTexture",
        Bridge.CreateFunction(
          "DrawTexture",
          (args) => UnityEngine.GUI.DrawTexture(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]))
        )
      );


      GUIConstructor.SetProperty(
        "DrawTexture",
        Bridge.CreateFunction(
          "DrawTexture",
          (args) => UnityEngine.GUI.DrawTexture(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.ScaleMode>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "DrawTexture",
        Bridge.CreateFunction(
          "DrawTexture",
          (args) => UnityEngine.GUI.DrawTexture(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.ScaleMode>(args[3]), args[4].ToBoolean())
        )
      );


      GUIConstructor.SetProperty(
        "DrawTexture",
        Bridge.CreateFunction(
          "DrawTexture",
          (args) => UnityEngine.GUI.DrawTexture(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.ScaleMode>(args[3]), args[4].ToBoolean(), (float) args[5].ToDouble())
        )
      );


      GUIConstructor.SetProperty(
        "DrawTexture",
        Bridge.CreateFunction(
          "DrawTexture",
          (args) => UnityEngine.GUI.DrawTexture(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.ScaleMode>(args[3]), args[4].ToBoolean(), (float) args[5].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Color>(args[6]).wrapped, (float) args[7].ToDouble(), (float) args[8].ToDouble())
        )
      );


      GUIConstructor.SetProperty(
        "DrawTexture",
        Bridge.CreateFunction(
          "DrawTexture",
          (args) => UnityEngine.GUI.DrawTexture(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.ScaleMode>(args[3]), args[4].ToBoolean(), (float) args[5].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Color>(args[6]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[7]).wrapped, (float) args[8].ToDouble())
        )
      );


      GUIConstructor.SetProperty(
        "DrawTexture",
        Bridge.CreateFunction(
          "DrawTexture",
          (args) => UnityEngine.GUI.DrawTexture(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.ScaleMode>(args[3]), args[4].ToBoolean(), (float) args[5].ToDouble(), Bridge.GetBoxedExternal<UnityEngine.Color>(args[6]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[7]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[8]).wrapped)
        )
      );


      GUIConstructor.SetProperty(
        "DrawTextureWithTexCoords",
        Bridge.CreateFunction(
          "DrawTextureWithTexCoords",
          (args) => UnityEngine.GUI.DrawTextureWithTexCoords(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[3]).wrapped)
        )
      );


      GUIConstructor.SetProperty(
        "DrawTextureWithTexCoords",
        Bridge.CreateFunction(
          "DrawTextureWithTexCoords",
          (args) => UnityEngine.GUI.DrawTextureWithTexCoords(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[3]).wrapped, args[4].ToBoolean())
        )
      );


      GUIConstructor.SetProperty(
        "Box",
        Bridge.CreateFunction(
          "Box",
          (args) => UnityEngine.GUI.Box(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString())
        )
      );


      GUIConstructor.SetProperty(
        "Box",
        Bridge.CreateFunction(
          "Box",
          (args) => UnityEngine.GUI.Box(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]))
        )
      );


      GUIConstructor.SetProperty(
        "Box",
        Bridge.CreateFunction(
          "Box",
          (args) => UnityEngine.GUI.Box(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2]))
        )
      );


      GUIConstructor.SetProperty(
        "Box",
        Bridge.CreateFunction(
          "Box",
          (args) => UnityEngine.GUI.Box(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "Box",
        Bridge.CreateFunction(
          "Box",
          (args) => UnityEngine.GUI.Box(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "Box",
        Bridge.CreateFunction(
          "Box",
          (args) => UnityEngine.GUI.Box(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "Button",
        Bridge.CreateFunction(
          "Button",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Button(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString()))
        )
      );


      GUIConstructor.SetProperty(
        "Button",
        Bridge.CreateFunction(
          "Button",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Button(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2])))
        )
      );


      GUIConstructor.SetProperty(
        "Button",
        Bridge.CreateFunction(
          "Button",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Button(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2])))
        )
      );


      GUIConstructor.SetProperty(
        "Button",
        Bridge.CreateFunction(
          "Button",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Button(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "Button",
        Bridge.CreateFunction(
          "Button",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Button(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "Button",
        Bridge.CreateFunction(
          "Button",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Button(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "RepeatButton",
        Bridge.CreateFunction(
          "RepeatButton",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.RepeatButton(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString()))
        )
      );


      GUIConstructor.SetProperty(
        "RepeatButton",
        Bridge.CreateFunction(
          "RepeatButton",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.RepeatButton(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2])))
        )
      );


      GUIConstructor.SetProperty(
        "RepeatButton",
        Bridge.CreateFunction(
          "RepeatButton",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.RepeatButton(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2])))
        )
      );


      GUIConstructor.SetProperty(
        "RepeatButton",
        Bridge.CreateFunction(
          "RepeatButton",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.RepeatButton(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "RepeatButton",
        Bridge.CreateFunction(
          "RepeatButton",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.RepeatButton(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "RepeatButton",
        Bridge.CreateFunction(
          "RepeatButton",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.RepeatButton(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "TextField",
        Bridge.CreateFunction(
          "TextField",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.TextField(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString()))
        )
      );


      GUIConstructor.SetProperty(
        "TextField",
        Bridge.CreateFunction(
          "TextField",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.TextField(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), args[3].ToInt32()))
        )
      );


      GUIConstructor.SetProperty(
        "TextField",
        Bridge.CreateFunction(
          "TextField",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.TextField(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "TextField",
        Bridge.CreateFunction(
          "TextField",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.TextField(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), args[3].ToInt32(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "PasswordField",
        Bridge.CreateFunction(
          "PasswordField",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.PasswordField(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetBoxedExternal<System.Char>(args[3]).wrapped))
        )
      );


      GUIConstructor.SetProperty(
        "PasswordField",
        Bridge.CreateFunction(
          "PasswordField",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.PasswordField(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetBoxedExternal<System.Char>(args[3]).wrapped, args[4].ToInt32()))
        )
      );


      GUIConstructor.SetProperty(
        "PasswordField",
        Bridge.CreateFunction(
          "PasswordField",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.PasswordField(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetBoxedExternal<System.Char>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "PasswordField",
        Bridge.CreateFunction(
          "PasswordField",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.PasswordField(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetBoxedExternal<System.Char>(args[3]).wrapped, args[4].ToInt32(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "TextArea",
        Bridge.CreateFunction(
          "TextArea",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.TextArea(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString()))
        )
      );


      GUIConstructor.SetProperty(
        "TextArea",
        Bridge.CreateFunction(
          "TextArea",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.TextArea(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), args[3].ToInt32()))
        )
      );


      GUIConstructor.SetProperty(
        "TextArea",
        Bridge.CreateFunction(
          "TextArea",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.TextArea(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "TextArea",
        Bridge.CreateFunction(
          "TextArea",
          (args) => JavaScriptValue.FromString(UnityEngine.GUI.TextArea(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), args[3].ToInt32(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Toggle",
        Bridge.CreateFunction(
          "Toggle",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Toggle(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToBoolean(), args[3].ToString()))
        )
      );


      GUIConstructor.SetProperty(
        "Toggle",
        Bridge.CreateFunction(
          "Toggle",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Toggle(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToBoolean(), Bridge.GetExternal<UnityEngine.Texture>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "Toggle",
        Bridge.CreateFunction(
          "Toggle",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Toggle(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToBoolean(), Bridge.GetExternal<UnityEngine.GUIContent>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "Toggle",
        Bridge.CreateFunction(
          "Toggle",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Toggle(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToBoolean(), args[3].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Toggle",
        Bridge.CreateFunction(
          "Toggle",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Toggle(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToBoolean(), Bridge.GetExternal<UnityEngine.Texture>(args[3]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Toggle",
        Bridge.CreateFunction(
          "Toggle",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Toggle(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToBoolean(), Bridge.GetExternal<UnityEngine.GUIContent>(args[3]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Toggle",
        Bridge.CreateFunction(
          "Toggle",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.Toggle(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), args[3].ToBoolean(), Bridge.GetExternal<UnityEngine.GUIContent>(args[4]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "Toolbar",
        Bridge.CreateFunction(
          "Toolbar",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.Toolbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<System.String[]>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "Toolbar",
        Bridge.CreateFunction(
          "Toolbar",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.Toolbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Texture[]>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "Toolbar",
        Bridge.CreateFunction(
          "Toolbar",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.Toolbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.GUIContent[]>(args[3])))
        )
      );


      GUIConstructor.SetProperty(
        "Toolbar",
        Bridge.CreateFunction(
          "Toolbar",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.Toolbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<System.String[]>(args[3]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Toolbar",
        Bridge.CreateFunction(
          "Toolbar",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.Toolbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Texture[]>(args[3]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Toolbar",
        Bridge.CreateFunction(
          "Toolbar",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.Toolbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.GUIContent[]>(args[3]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Toolbar",
        Bridge.CreateFunction(
          "Toolbar",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.Toolbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.GUIContent[]>(args[3]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[4]), Bridge.GetExternal<UnityEngine.GUI.ToolbarButtonSize>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "SelectionGrid",
        Bridge.CreateFunction(
          "SelectionGrid",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.SelectionGrid(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<System.String[]>(args[3]), args[4].ToInt32()))
        )
      );


      GUIConstructor.SetProperty(
        "SelectionGrid",
        Bridge.CreateFunction(
          "SelectionGrid",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.SelectionGrid(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Texture[]>(args[3]), args[4].ToInt32()))
        )
      );


      GUIConstructor.SetProperty(
        "SelectionGrid",
        Bridge.CreateFunction(
          "SelectionGrid",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.SelectionGrid(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.GUIContent[]>(args[3]), args[4].ToInt32()))
        )
      );


      GUIConstructor.SetProperty(
        "SelectionGrid",
        Bridge.CreateFunction(
          "SelectionGrid",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.SelectionGrid(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<System.String[]>(args[3]), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "SelectionGrid",
        Bridge.CreateFunction(
          "SelectionGrid",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.SelectionGrid(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.Texture[]>(args[3]), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "SelectionGrid",
        Bridge.CreateFunction(
          "SelectionGrid",
          (args) => JavaScriptValue.FromInt32(UnityEngine.GUI.SelectionGrid(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToInt32(), Bridge.GetExternal<UnityEngine.GUIContent[]>(args[3]), args[4].ToInt32(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "HorizontalSlider",
        Bridge.CreateFunction(
          "HorizontalSlider",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.HorizontalSlider(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble()))
        )
      );


      GUIConstructor.SetProperty(
        "HorizontalSlider",
        Bridge.CreateFunction(
          "HorizontalSlider",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.HorizontalSlider(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[6])))
        )
      );


      GUIConstructor.SetProperty(
        "VerticalSlider",
        Bridge.CreateFunction(
          "VerticalSlider",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.VerticalSlider(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble()))
        )
      );


      GUIConstructor.SetProperty(
        "VerticalSlider",
        Bridge.CreateFunction(
          "VerticalSlider",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.VerticalSlider(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[6])))
        )
      );


      GUIConstructor.SetProperty(
        "Slider",
        Bridge.CreateFunction(
          "Slider",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.Slider(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[6]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[7]), args[8].ToBoolean(), args[9].ToInt32()))
        )
      );


      GUIConstructor.SetProperty(
        "HorizontalScrollbar",
        Bridge.CreateFunction(
          "HorizontalScrollbar",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.HorizontalScrollbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble()))
        )
      );


      GUIConstructor.SetProperty(
        "HorizontalScrollbar",
        Bridge.CreateFunction(
          "HorizontalScrollbar",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.HorizontalScrollbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[6])))
        )
      );


      GUIConstructor.SetProperty(
        "VerticalScrollbar",
        Bridge.CreateFunction(
          "VerticalScrollbar",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.VerticalScrollbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble()))
        )
      );


      GUIConstructor.SetProperty(
        "VerticalScrollbar",
        Bridge.CreateFunction(
          "VerticalScrollbar",
          (args) => JavaScriptValue.FromDouble(UnityEngine.GUI.VerticalScrollbar(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble(), (float) args[3].ToDouble(), (float) args[4].ToDouble(), (float) args[5].ToDouble(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[6])))
        )
      );


      GUIConstructor.SetProperty(
        "BeginClip",
        Bridge.CreateFunction(
          "BeginClip",
          (args) => UnityEngine.GUI.BeginClip(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[3]).wrapped, args[4].ToBoolean())
        )
      );


      GUIConstructor.SetProperty(
        "BeginGroup",
        Bridge.CreateFunction(
          "BeginGroup",
          (args) => UnityEngine.GUI.BeginGroup(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped)
        )
      );


      GUIConstructor.SetProperty(
        "BeginGroup",
        Bridge.CreateFunction(
          "BeginGroup",
          (args) => UnityEngine.GUI.BeginGroup(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString())
        )
      );


      GUIConstructor.SetProperty(
        "BeginGroup",
        Bridge.CreateFunction(
          "BeginGroup",
          (args) => UnityEngine.GUI.BeginGroup(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]))
        )
      );


      GUIConstructor.SetProperty(
        "BeginGroup",
        Bridge.CreateFunction(
          "BeginGroup",
          (args) => UnityEngine.GUI.BeginGroup(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2]))
        )
      );


      GUIConstructor.SetProperty(
        "BeginGroup",
        Bridge.CreateFunction(
          "BeginGroup",
          (args) => UnityEngine.GUI.BeginGroup(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIStyle>(args[2]))
        )
      );


      GUIConstructor.SetProperty(
        "BeginGroup",
        Bridge.CreateFunction(
          "BeginGroup",
          (args) => UnityEngine.GUI.BeginGroup(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, args[2].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "BeginGroup",
        Bridge.CreateFunction(
          "BeginGroup",
          (args) => UnityEngine.GUI.BeginGroup(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Texture>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "BeginGroup",
        Bridge.CreateFunction(
          "BeginGroup",
          (args) => UnityEngine.GUI.BeginGroup(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.GUIContent>(args[2]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[3]))
        )
      );


      GUIConstructor.SetProperty(
        "EndGroup",
        Bridge.CreateFunction(
          "EndGroup",
          (args) => UnityEngine.GUI.EndGroup()
        )
      );


      GUIConstructor.SetProperty(
        "BeginClip",
        Bridge.CreateFunction(
          "BeginClip",
          (args) => UnityEngine.GUI.BeginClip(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped)
        )
      );


      GUIConstructor.SetProperty(
        "EndClip",
        Bridge.CreateFunction(
          "EndClip",
          (args) => UnityEngine.GUI.EndClip()
        )
      );


      GUIConstructor.SetProperty(
        "BeginScrollView",
        Bridge.CreateFunction(
          "BeginScrollView",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.BeginScrollView(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Rect>(args[3]).wrapped))
        )
      );


      GUIConstructor.SetProperty(
        "BeginScrollView",
        Bridge.CreateFunction(
          "BeginScrollView",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.BeginScrollView(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Rect>(args[3]).wrapped, args[4].ToBoolean(), args[5].ToBoolean()))
        )
      );


      GUIConstructor.SetProperty(
        "BeginScrollView",
        Bridge.CreateFunction(
          "BeginScrollView",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.BeginScrollView(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Rect>(args[3]).wrapped, Bridge.GetExternal<UnityEngine.GUIStyle>(args[4]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "BeginScrollView",
        Bridge.CreateFunction(
          "BeginScrollView",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.BeginScrollView(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Rect>(args[3]).wrapped, args[4].ToBoolean(), args[5].ToBoolean(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[6]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[7])))
        )
      );


      GUIConstructor.SetProperty(
        "EndScrollView",
        Bridge.CreateFunction(
          "EndScrollView",
          (args) => UnityEngine.GUI.EndScrollView()
        )
      );


      GUIConstructor.SetProperty(
        "EndScrollView",
        Bridge.CreateFunction(
          "EndScrollView",
          (args) => UnityEngine.GUI.EndScrollView(args[1].ToBoolean())
        )
      );


      GUIConstructor.SetProperty(
        "ScrollTo",
        Bridge.CreateFunction(
          "ScrollTo",
          (args) => UnityEngine.GUI.ScrollTo(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped)
        )
      );


      GUIConstructor.SetProperty(
        "ScrollTowards",
        Bridge.CreateFunction(
          "ScrollTowards",
          (args) => JavaScriptValue.FromBoolean(UnityEngine.GUI.ScrollTowards(Bridge.GetBoxedExternal<UnityEngine.Rect>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


      GUIConstructor.SetProperty(
        "Window",
        Bridge.CreateFunction(
          "Window",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.Window(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), args[4].ToString()))
        )
      );


      GUIConstructor.SetProperty(
        "Window",
        Bridge.CreateFunction(
          "Window",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.Window(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), Bridge.GetExternal<UnityEngine.Texture>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Window",
        Bridge.CreateFunction(
          "Window",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.Window(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), Bridge.GetExternal<UnityEngine.GUIContent>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "Window",
        Bridge.CreateFunction(
          "Window",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.Window(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), args[4].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "Window",
        Bridge.CreateFunction(
          "Window",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.Window(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), Bridge.GetExternal<UnityEngine.Texture>(args[4]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "Window",
        Bridge.CreateFunction(
          "Window",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.Window(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), Bridge.GetExternal<UnityEngine.GUIContent>(args[4]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "ModalWindow",
        Bridge.CreateFunction(
          "ModalWindow",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.ModalWindow(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), args[4].ToString()))
        )
      );


      GUIConstructor.SetProperty(
        "ModalWindow",
        Bridge.CreateFunction(
          "ModalWindow",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.ModalWindow(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), Bridge.GetExternal<UnityEngine.Texture>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "ModalWindow",
        Bridge.CreateFunction(
          "ModalWindow",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.ModalWindow(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), Bridge.GetExternal<UnityEngine.GUIContent>(args[4])))
        )
      );


      GUIConstructor.SetProperty(
        "ModalWindow",
        Bridge.CreateFunction(
          "ModalWindow",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.ModalWindow(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), args[4].ToString(), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "ModalWindow",
        Bridge.CreateFunction(
          "ModalWindow",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.ModalWindow(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), Bridge.GetExternal<UnityEngine.Texture>(args[4]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "ModalWindow",
        Bridge.CreateFunction(
          "ModalWindow",
          (args) => Bridge.CreateExternalWithPrototype(UnityEngine.GUI.ModalWindow(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Rect>(args[2]).wrapped, Bridge.GetExternal<UnityEngine.GUI.WindowFunction>(args[3]), Bridge.GetExternal<UnityEngine.GUIContent>(args[4]), Bridge.GetExternal<UnityEngine.GUIStyle>(args[5])))
        )
      );


      GUIConstructor.SetProperty(
        "DragWindow",
        Bridge.CreateFunction(
          "DragWindow",
          (args) => UnityEngine.GUI.DragWindow()
        )
      );


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
