using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSRuntimePlatform {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue RuntimePlatformPrototype;
      JavaScriptValue RuntimePlatformConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.RuntimePlatform),
        (args) => { throw new System.NotImplementedException(); },
        out RuntimePlatformPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("RuntimePlatform", RuntimePlatformConstructor);


      // Static Fields

      RuntimePlatformConstructor.SetProperty(
        "OSXEditor",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.OSXEditor)
      );


      RuntimePlatformConstructor.SetProperty(
        "OSXPlayer",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.OSXPlayer)
      );


      RuntimePlatformConstructor.SetProperty(
        "WindowsPlayer",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.WindowsPlayer)
      );


      RuntimePlatformConstructor.SetProperty(
        "WindowsEditor",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.WindowsEditor)
      );


      RuntimePlatformConstructor.SetProperty(
        "IPhonePlayer",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.IPhonePlayer)
      );


      RuntimePlatformConstructor.SetProperty(
        "Android",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.Android)
      );


      RuntimePlatformConstructor.SetProperty(
        "LinuxPlayer",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.LinuxPlayer)
      );


      RuntimePlatformConstructor.SetProperty(
        "LinuxEditor",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.LinuxEditor)
      );


      RuntimePlatformConstructor.SetProperty(
        "WebGLPlayer",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.WebGLPlayer)
      );


      RuntimePlatformConstructor.SetProperty(
        "WSAPlayerX86",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.WSAPlayerX86)
      );


      RuntimePlatformConstructor.SetProperty(
        "WSAPlayerX64",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.WSAPlayerX64)
      );


      RuntimePlatformConstructor.SetProperty(
        "WSAPlayerARM",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.WSAPlayerARM)
      );


      RuntimePlatformConstructor.SetProperty(
        "PSP2",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.PSP2)
      );


      RuntimePlatformConstructor.SetProperty(
        "PS4",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.PS4)
      );


      RuntimePlatformConstructor.SetProperty(
        "XboxOne",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.XboxOne)
      );


      RuntimePlatformConstructor.SetProperty(
        "tvOS",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.tvOS)
      );


      RuntimePlatformConstructor.SetProperty(
        "Switch",
        Bridge.CreateExternalWithPrototype(UnityEngine.RuntimePlatform.Switch)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
