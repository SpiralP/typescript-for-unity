declare namespace UnityEngine {
  class GUI {
    // Static Fields

    // Static Property Accessors

    static color: UnityEngine.Color;

    static backgroundColor: UnityEngine.Color;

    static contentColor: UnityEngine.Color;

    static changed: boolean;

    static enabled: boolean;

    static depth: number;

    static skin: UnityEngine.GUISkin;

    static matrix: UnityEngine.Matrix4x4;

    static tooltip: string;

    // Static Methods

    static SetNextControlName(name: string): void;

    static GetNameOfFocusedControl(): string;

    static FocusControl(name: string): void;

    static DragWindow(position: UnityEngine.Rect): void;

    static BringWindowToFront(windowID: number): void;

    static BringWindowToBack(windowID: number): void;

    static FocusWindow(windowID: number): void;

    static UnfocusWindow(): void;

    static Label(position: UnityEngine.Rect, text: string): void;

    static Label(position: UnityEngine.Rect, image: UnityEngine.Texture): void;

    static Label(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent
    ): void;

    static Label(
      position: UnityEngine.Rect,
      text: string,
      style: UnityEngine.GUIStyle
    ): void;

    static Label(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      style: UnityEngine.GUIStyle
    ): void;

    static Label(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): void;

    static DrawTexture(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture
    ): void;

    static DrawTexture(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      scaleMode: UnityEngine.ScaleMode
    ): void;

    static DrawTexture(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      scaleMode: UnityEngine.ScaleMode,
      alphaBlend: boolean
    ): void;

    static DrawTexture(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      scaleMode: UnityEngine.ScaleMode,
      alphaBlend: boolean,
      imageAspect: number
    ): void;

    static DrawTexture(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      scaleMode: UnityEngine.ScaleMode,
      alphaBlend: boolean,
      imageAspect: number,
      color: UnityEngine.Color,
      borderWidth: number,
      borderRadius: number
    ): void;

    static DrawTexture(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      scaleMode: UnityEngine.ScaleMode,
      alphaBlend: boolean,
      imageAspect: number,
      color: UnityEngine.Color,
      borderWidths: UnityEngine.Vector4,
      borderRadius: number
    ): void;

    static DrawTexture(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      scaleMode: UnityEngine.ScaleMode,
      alphaBlend: boolean,
      imageAspect: number,
      color: UnityEngine.Color,
      borderWidths: UnityEngine.Vector4,
      borderRadiuses: UnityEngine.Vector4
    ): void;

    static DrawTextureWithTexCoords(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      texCoords: UnityEngine.Rect
    ): void;

    static DrawTextureWithTexCoords(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      texCoords: UnityEngine.Rect,
      alphaBlend: boolean
    ): void;

    static Box(position: UnityEngine.Rect, text: string): void;

    static Box(position: UnityEngine.Rect, image: UnityEngine.Texture): void;

    static Box(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent
    ): void;

    static Box(
      position: UnityEngine.Rect,
      text: string,
      style: UnityEngine.GUIStyle
    ): void;

    static Box(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      style: UnityEngine.GUIStyle
    ): void;

    static Box(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): void;

    static Button(position: UnityEngine.Rect, text: string): boolean;

    static Button(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture
    ): boolean;

    static Button(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent
    ): boolean;

    static Button(
      position: UnityEngine.Rect,
      text: string,
      style: UnityEngine.GUIStyle
    ): boolean;

    static Button(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      style: UnityEngine.GUIStyle
    ): boolean;

    static Button(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): boolean;

    static RepeatButton(position: UnityEngine.Rect, text: string): boolean;

    static RepeatButton(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture
    ): boolean;

    static RepeatButton(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent
    ): boolean;

    static RepeatButton(
      position: UnityEngine.Rect,
      text: string,
      style: UnityEngine.GUIStyle
    ): boolean;

    static RepeatButton(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      style: UnityEngine.GUIStyle
    ): boolean;

    static RepeatButton(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): boolean;

    static TextField(position: UnityEngine.Rect, text: string): string;

    static TextField(
      position: UnityEngine.Rect,
      text: string,
      maxLength: number
    ): string;

    static TextField(
      position: UnityEngine.Rect,
      text: string,
      style: UnityEngine.GUIStyle
    ): string;

    static TextField(
      position: UnityEngine.Rect,
      text: string,
      maxLength: number,
      style: UnityEngine.GUIStyle
    ): string;

    static PasswordField(
      position: UnityEngine.Rect,
      password: string,
      maskChar: System.Char
    ): string;

    static PasswordField(
      position: UnityEngine.Rect,
      password: string,
      maskChar: System.Char,
      maxLength: number
    ): string;

    static PasswordField(
      position: UnityEngine.Rect,
      password: string,
      maskChar: System.Char,
      style: UnityEngine.GUIStyle
    ): string;

    static PasswordField(
      position: UnityEngine.Rect,
      password: string,
      maskChar: System.Char,
      maxLength: number,
      style: UnityEngine.GUIStyle
    ): string;

    static TextArea(position: UnityEngine.Rect, text: string): string;

    static TextArea(
      position: UnityEngine.Rect,
      text: string,
      maxLength: number
    ): string;

    static TextArea(
      position: UnityEngine.Rect,
      text: string,
      style: UnityEngine.GUIStyle
    ): string;

    static TextArea(
      position: UnityEngine.Rect,
      text: string,
      maxLength: number,
      style: UnityEngine.GUIStyle
    ): string;

    static Toggle(
      position: UnityEngine.Rect,
      value: boolean,
      text: string
    ): boolean;

    static Toggle(
      position: UnityEngine.Rect,
      value: boolean,
      image: UnityEngine.Texture
    ): boolean;

    static Toggle(
      position: UnityEngine.Rect,
      value: boolean,
      content: UnityEngine.GUIContent
    ): boolean;

    static Toggle(
      position: UnityEngine.Rect,
      value: boolean,
      text: string,
      style: UnityEngine.GUIStyle
    ): boolean;

    static Toggle(
      position: UnityEngine.Rect,
      value: boolean,
      image: UnityEngine.Texture,
      style: UnityEngine.GUIStyle
    ): boolean;

    static Toggle(
      position: UnityEngine.Rect,
      value: boolean,
      content: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): boolean;

    static Toggle(
      position: UnityEngine.Rect,
      id: number,
      value: boolean,
      content: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): boolean;

    static Toolbar(
      position: UnityEngine.Rect,
      selected: number,
      texts: System.String[]
    ): number;

    static Toolbar(
      position: UnityEngine.Rect,
      selected: number,
      images: UnityEngine.Texture[]
    ): number;

    static Toolbar(
      position: UnityEngine.Rect,
      selected: number,
      contents: UnityEngine.GUIContent[]
    ): number;

    static Toolbar(
      position: UnityEngine.Rect,
      selected: number,
      texts: System.String[],
      style: UnityEngine.GUIStyle
    ): number;

    static Toolbar(
      position: UnityEngine.Rect,
      selected: number,
      images: UnityEngine.Texture[],
      style: UnityEngine.GUIStyle
    ): number;

    static Toolbar(
      position: UnityEngine.Rect,
      selected: number,
      contents: UnityEngine.GUIContent[],
      style: UnityEngine.GUIStyle
    ): number;

    static Toolbar(
      position: UnityEngine.Rect,
      selected: number,
      contents: UnityEngine.GUIContent[],
      style: UnityEngine.GUIStyle,
      buttonSize: UnityEngine.GUI.ToolbarButtonSize
    ): number;

    static SelectionGrid(
      position: UnityEngine.Rect,
      selected: number,
      texts: System.String[],
      xCount: number
    ): number;

    static SelectionGrid(
      position: UnityEngine.Rect,
      selected: number,
      images: UnityEngine.Texture[],
      xCount: number
    ): number;

    static SelectionGrid(
      position: UnityEngine.Rect,
      selected: number,
      content: UnityEngine.GUIContent[],
      xCount: number
    ): number;

    static SelectionGrid(
      position: UnityEngine.Rect,
      selected: number,
      texts: System.String[],
      xCount: number,
      style: UnityEngine.GUIStyle
    ): number;

    static SelectionGrid(
      position: UnityEngine.Rect,
      selected: number,
      images: UnityEngine.Texture[],
      xCount: number,
      style: UnityEngine.GUIStyle
    ): number;

    static SelectionGrid(
      position: UnityEngine.Rect,
      selected: number,
      contents: UnityEngine.GUIContent[],
      xCount: number,
      style: UnityEngine.GUIStyle
    ): number;

    static HorizontalSlider(
      position: UnityEngine.Rect,
      value: number,
      leftValue: number,
      rightValue: number
    ): number;

    static HorizontalSlider(
      position: UnityEngine.Rect,
      value: number,
      leftValue: number,
      rightValue: number,
      slider: UnityEngine.GUIStyle,
      thumb: UnityEngine.GUIStyle
    ): number;

    static VerticalSlider(
      position: UnityEngine.Rect,
      value: number,
      topValue: number,
      bottomValue: number
    ): number;

    static VerticalSlider(
      position: UnityEngine.Rect,
      value: number,
      topValue: number,
      bottomValue: number,
      slider: UnityEngine.GUIStyle,
      thumb: UnityEngine.GUIStyle
    ): number;

    static Slider(
      position: UnityEngine.Rect,
      value: number,
      size: number,
      start: number,
      end: number,
      slider: UnityEngine.GUIStyle,
      thumb: UnityEngine.GUIStyle,
      horiz: boolean,
      id: number
    ): number;

    static HorizontalScrollbar(
      position: UnityEngine.Rect,
      value: number,
      size: number,
      leftValue: number,
      rightValue: number
    ): number;

    static HorizontalScrollbar(
      position: UnityEngine.Rect,
      value: number,
      size: number,
      leftValue: number,
      rightValue: number,
      style: UnityEngine.GUIStyle
    ): number;

    static VerticalScrollbar(
      position: UnityEngine.Rect,
      value: number,
      size: number,
      topValue: number,
      bottomValue: number
    ): number;

    static VerticalScrollbar(
      position: UnityEngine.Rect,
      value: number,
      size: number,
      topValue: number,
      bottomValue: number,
      style: UnityEngine.GUIStyle
    ): number;

    static BeginClip(
      position: UnityEngine.Rect,
      scrollOffset: UnityEngine.Vector2,
      renderOffset: UnityEngine.Vector2,
      resetOffset: boolean
    ): void;

    static BeginGroup(position: UnityEngine.Rect): void;

    static BeginGroup(position: UnityEngine.Rect, text: string): void;

    static BeginGroup(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture
    ): void;

    static BeginGroup(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent
    ): void;

    static BeginGroup(
      position: UnityEngine.Rect,
      style: UnityEngine.GUIStyle
    ): void;

    static BeginGroup(
      position: UnityEngine.Rect,
      text: string,
      style: UnityEngine.GUIStyle
    ): void;

    static BeginGroup(
      position: UnityEngine.Rect,
      image: UnityEngine.Texture,
      style: UnityEngine.GUIStyle
    ): void;

    static BeginGroup(
      position: UnityEngine.Rect,
      content: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): void;

    static EndGroup(): void;

    static BeginClip(position: UnityEngine.Rect): void;

    static EndClip(): void;

    static BeginScrollView(
      position: UnityEngine.Rect,
      scrollPosition: UnityEngine.Vector2,
      viewRect: UnityEngine.Rect
    ): UnityEngine.Vector2;

    static BeginScrollView(
      position: UnityEngine.Rect,
      scrollPosition: UnityEngine.Vector2,
      viewRect: UnityEngine.Rect,
      alwaysShowHorizontal: boolean,
      alwaysShowVertical: boolean
    ): UnityEngine.Vector2;

    static BeginScrollView(
      position: UnityEngine.Rect,
      scrollPosition: UnityEngine.Vector2,
      viewRect: UnityEngine.Rect,
      horizontalScrollbar: UnityEngine.GUIStyle,
      verticalScrollbar: UnityEngine.GUIStyle
    ): UnityEngine.Vector2;

    static BeginScrollView(
      position: UnityEngine.Rect,
      scrollPosition: UnityEngine.Vector2,
      viewRect: UnityEngine.Rect,
      alwaysShowHorizontal: boolean,
      alwaysShowVertical: boolean,
      horizontalScrollbar: UnityEngine.GUIStyle,
      verticalScrollbar: UnityEngine.GUIStyle
    ): UnityEngine.Vector2;

    static EndScrollView(): void;

    static EndScrollView(handleScrollWheel: boolean): void;

    static ScrollTo(position: UnityEngine.Rect): void;

    static ScrollTowards(position: UnityEngine.Rect, maxDelta: number): boolean;

    static Window(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      text: string
    ): UnityEngine.Rect;

    static Window(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      image: UnityEngine.Texture
    ): UnityEngine.Rect;

    static Window(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      content: UnityEngine.GUIContent
    ): UnityEngine.Rect;

    static Window(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      text: string,
      style: UnityEngine.GUIStyle
    ): UnityEngine.Rect;

    static Window(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      image: UnityEngine.Texture,
      style: UnityEngine.GUIStyle
    ): UnityEngine.Rect;

    static Window(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      title: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): UnityEngine.Rect;

    static ModalWindow(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      text: string
    ): UnityEngine.Rect;

    static ModalWindow(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      image: UnityEngine.Texture
    ): UnityEngine.Rect;

    static ModalWindow(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      content: UnityEngine.GUIContent
    ): UnityEngine.Rect;

    static ModalWindow(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      text: string,
      style: UnityEngine.GUIStyle
    ): UnityEngine.Rect;

    static ModalWindow(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      image: UnityEngine.Texture,
      style: UnityEngine.GUIStyle
    ): UnityEngine.Rect;

    static ModalWindow(
      id: number,
      clientRect: UnityEngine.Rect,
      func: UnityEngine.GUI.WindowFunction,
      content: UnityEngine.GUIContent,
      style: UnityEngine.GUIStyle
    ): UnityEngine.Rect;

    static DragWindow(): void;

    // Instance Fields

    // Instance Property Accessors

    // Instance Methods
  }
}
