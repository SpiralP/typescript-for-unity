# TypeScript for Unity

This repo lets you use modern ES2018 JavaScript and TypeScript for scripting or as an embedded language in Unity. It was extracted from an unreleased game created by [SpiralP](http://github.com/SpiralP) and [suchipi](http://github.com/suchipi). It supports Windows, Mac, and Linux.

## Features

- Use TypeScript or JavaScript for scripting in your game or as an embedded user-facing language
- Supports ES2018 features and syntax with no compilation step
- Native ECMAScript modules support (`import`/`export`)
- Simple `JSBehaviour` object lets you write `MonoBehaviour`s in JS/TS
- Generated TypeScript bindings for Unity classes
- Code generation utilities for writing your own bindings between C# and JavaScript

## Getting Started

This repo contains an example Unity Project already set up for you. Clone it and init submodules, then open it in the Unity Editor.
Open the scene "Default Scene"; you should see a cube move away from the camera. The code for this is in `src/JSCubeBehaviour.ts`.

```
git clone git@github.com:SpiralP/typescript-for-unity.git
cd typescript-for-unity
git submodule init
git submodule update
```

## Usage

### Setup

To use this in your own Unity Project:

- Copy in `tsconfig.json`, the `src` folder, and everything from `Assets/Plugins` and `Assets/Scripts`
- Make sure your Project has a `StreamingAssets` folder
- Add a `GameObject` in your scene and add the `JavaScript.Engine` script to it. This will initialize the JavaScript Engine.
  - You need a `GameObject` with `JavaScript.Engine` in every scene where you want to run JavaScript. You should only have one per scene.

### Running code

Now, there are a few ways to execute code:

#### `JavaScript.Engine.RunScript(string script)`

You can call `JavaScript.Engine.RunScript(code)` to execute a code string. For example:

```cs
JavaScript.Engine.RunScript("console.log('hi')");
```

#### `JavaScript.Engine.RunFile(string filename)`

You can call `JavaScript.Engine.RunFile(moduleSpecifier)` to load and run a file in `src` as a _Script_. For example:

```cs
Engine.RunFile("vendor/inspect");
```

#### `JavaScript.Engine.Import(string specifier)`

You can call `JavaScript.Engine.Import(moduleSpecifier)` to import and run a file in `src` as a _Module_. For example:

```cs
Engine.Import("JSCubeBehaviour");
```

#### `JavaScript.Runner`

You can add a `JavaScript.Runner` script to a `GameObject`. This is an interface to `JavaScript.Engine.RunScript` and `JavaScript.Engine.Import`.

- It has two values you can set from the Unity Editor: `Code` and `Module Specifier`. You should use one or the other.
- If you put a string of JavaScript code in the `Code` property, it will run that code (eg `console.log('hi')`).
- If you put the name of a file in `src` in the `Module Specifier` property, it will import and run that module (can be JS or TS).

#### `JSBehaviour`

You can add a `JSBehaviour` script to a `GameObject`.

- `JSBehaviour` provides a `MonoBehaviour`-like interface for writing scripts from JS/TS.
- In the editor, set its `Module Specifier` property to the name of a file in `src`. That file's default export should be a class that extends the global `JSBehaviour`.
- The JS/TS class's `Start`, `Update`, etc methods will be called just like in a `MonoBehaviour`.
- You can use `this.monoBehaviour` to get a reference to the `MonoBehaviour` that wraps your class, in order to get access to components on the object.
- See `src/JSCubeBehaviour.ts` for an example.

### A note about module specifiers

Non-relative `import`s are resolved relative to the `src` directory:

```js
import JSCubeBehaviour from "JSCubeBehaviour"; // loads `src/JSCubeBehaviour.ts`
```

You do not need to specify the `.js` or `.ts` extension (but you can if you want). If importing a `.json` file, you need to specify the extension.

The same lookup algorithm is used when you give a module specifier to a `JavaScript.Runner` script, a `JSBehaviour` script, or any of the methods on `JavaScript.Engine` that accept a path to a JS/TS file.

### Accessing Unity objects from JS/TS

When writing your scripts, you may need access to Unity `GameObject`s and prefabs. There are two ways to get access to them:

- If you are using a `JSBehaviour`, you can use `this.monoBehaviour` to access the instance of the `MonoBehaviour` class that wraps your `JSBehaviour`. You can use that to get the `GameObject` your `JSBehaviour` script is attached to, and any other components on that `GameObject`.
- You can add "bindings" to the engine to make objects globally-available. View the `GameObject` you put a `JavaScript.Engine` script on in the Inspector; you'll notice one of its properties is a list called "Bindings". Increase the list length to add a new entry, give the entry a name, and then drag an object into the "Bound Object" slot. After doing this, you can use the global function `bindings.get` from JavaScript to get a bound object by name; for instance, `bindings.get("player")`. If you are using TypeScript, you can specify the type of the bound object with `bindings.get<UnityEngine.GameObject>("player")`.

### Creating bindings between JS and C# code

You can use the `JavaScript.Bridge` class to create wrapper objects for C# classes that makes them available in JS/TS. There are already bindings for several classes in the `JavaScript.API` namespace which you can reference for examples.

A good way to write bindings is to use the code generation utilities in `JSClassGenerator` and `JSTypeScriptGenerator` to create C# bridging classes and `*.d.ts` files for your C# object. The generator can't automatically write bridging code for everything, but it provides a good starting point.

- Open `JSClassGenerator` and `JSTypeScriptGenerator` and look for `[MenuItem("JSClassGenerator/Generate Class Files")]` and `[MenuItem("JSClassGenerator/Generate TypeScript Files")]`.
- Add your types to the `for` loop in each file.
- In the Unity Editor, click `JSClassGenerator` -> `Generate Class Files` and `JSClassGenerator` -> `Generate TypeScript Files`. This will generate a `*.cs` file and a `*.d.ts` file for each type and put them in the `Scripts/JavaScript/API/.Generated/` directory.
- Go review the generated files, edit them as necessary, and then move them out of `.Generated` into `Scripts/JavaScript/API`.
- Call your generated class's `Register` method in `JavaScript.Engine`'s `Awake` method:

```cs
void Awake() {
  // ...
  Engine.With(() => {
    Module.Loader.Register(context);
    API.JSSystem.JSSystem.Register(context);
    API.Console.Register(context);
    API.DOM.Register(context);
    API.Inspect.Register(context);
    API.TypescriptServices.Register(context);
    API.File.Register(context);
    API.Http.Register(context);
    API.UpdateHelper.Register(context);
    API.Timer.Register(context);
    API.PromiseContinuation.Register(context);
    API.ChakraInternals.Register(context);
    API.JSUnityEngine.JSUnityEngine.Register(context);
    JavaScript.JSBehaviour.Register(context);
    // Add your new class here

    // ...
```

### Updating TypeScript

This repo has TypeScript 3.0. If you want to use a different version, you can replace the files `src/vendor/typeScriptServices.js` and `src/vendor/typeScriptServices.d.ts` with newer versions from [the TypeScript repo](https://github.com/Microsoft/TypeScript/tree/master/lib).

### Updating Chakra Core

This repo uses Chakra Core (Microsoft Edge's JavaScript engine) to run JavaScript and TypeScript. It includes some binaries in `Assets/Plugins`:

- `ChakraCore.bundle` - macOS binary
- `libChakraCore.so` - Linux binary (untested)
- `ChakraCore.dll` - Windows binary

You can replace these with a newer [release of ChakraCore](https://github.com/Microsoft/ChakraCore/releases) to get new language features.

### Adding support for importing more filetypes

If you want to support Coffeescript, Reason, or importing `png` files (webpack style), you can add code to the following places:

- If you want to allow importing your type without the extension in the module specifier (`import Foo from "foo"` instead of `import Foo from "foo.png"`), add it to `JavaScript.Module.Loader`'s `SupportedExtensions` List.
- Handle your filetype extension in `JavaScript.Module.Loader`'s `ConvertSourceToJS` method; you need to return a string of JavaScript code.

## License

This code is licensed under the MIT license. The owner(s) of this repo have no social obligation to support or maintain this code; they made it for fun during their own time and are sharing it because they think it could be useful to others. Fork it or leave it.
