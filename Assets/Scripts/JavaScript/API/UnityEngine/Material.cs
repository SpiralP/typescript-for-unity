using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSMaterial {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue MaterialPrototype;
      JavaScriptValue MaterialConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Material),
        (args) => { throw new System.NotImplementedException(); },
        out MaterialPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Material", MaterialConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "shader",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.shader)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.shader = Bridge.GetExternal<UnityEngine.Shader>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "color",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.color)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.color = Bridge.GetBoxedExternal<UnityEngine.Color>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "mainTexture",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.mainTexture)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.mainTexture = Bridge.GetExternal<UnityEngine.Texture>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "mainTextureOffset",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.mainTextureOffset)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.mainTextureOffset = Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "mainTextureScale",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.mainTextureScale)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.mainTextureScale = Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "renderQueue",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromInt32(o.renderQueue)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.renderQueue = args[1].ToInt32(); })
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "globalIlluminationFlags",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.globalIlluminationFlags)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.globalIlluminationFlags = Bridge.GetExternal<UnityEngine.MaterialGlobalIlluminationFlags>(args[1]); })
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "doubleSidedGI",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromBoolean(o.doubleSidedGI)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.doubleSidedGI = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "enableInstancing",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromBoolean(o.enableInstancing)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.enableInstancing = args[1].ToBoolean(); })
      );


      Bridge.DefineGetter(
        MaterialPrototype,
        "passCount",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromInt32(o.passCount))
      );


      Bridge.DefineGetterSetter(
        MaterialPrototype,
        "shaderKeywords",
        Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.shaderKeywords)),
        Bridge.WithExternal<UnityEngine.Material>((o, args) => { o.shaderKeywords = Bridge.GetExternal<System.String[]>(args[1]); })
      );


      // Instance Methods

      MaterialPrototype.SetProperty(
        "GetTexturePropertyNames",
        Bridge.CreateFunction(
          "GetTexturePropertyNames",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTexturePropertyNames()))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTexturePropertyNameIDs",
        Bridge.CreateFunction(
          "GetTexturePropertyNameIDs",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTexturePropertyNameIDs()))
        )
      );


      /*
        Material GetTexturePropertyNames
        System.Collections.Generic.List`1[System.String] has generics
      */


      /*
        Material GetTexturePropertyNameIDs
        System.Collections.Generic.List`1[System.Int32] has generics
      */


      MaterialPrototype.SetProperty(
        "HasProperty",
        Bridge.CreateFunction(
          "HasProperty",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromBoolean(o.HasProperty(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "HasProperty",
        Bridge.CreateFunction(
          "HasProperty",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromBoolean(o.HasProperty(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "EnableKeyword",
        Bridge.CreateFunction(
          "EnableKeyword",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.EnableKeyword(args[1].ToString()))
        )
      );


      MaterialPrototype.SetProperty(
        "DisableKeyword",
        Bridge.CreateFunction(
          "DisableKeyword",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.DisableKeyword(args[1].ToString()))
        )
      );


      MaterialPrototype.SetProperty(
        "IsKeywordEnabled",
        Bridge.CreateFunction(
          "IsKeywordEnabled",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromBoolean(o.IsKeywordEnabled(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "SetShaderPassEnabled",
        Bridge.CreateFunction(
          "SetShaderPassEnabled",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetShaderPassEnabled(args[1].ToString(), args[2].ToBoolean()))
        )
      );


      MaterialPrototype.SetProperty(
        "GetShaderPassEnabled",
        Bridge.CreateFunction(
          "GetShaderPassEnabled",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromBoolean(o.GetShaderPassEnabled(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetPassName",
        Bridge.CreateFunction(
          "GetPassName",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromString(o.GetPassName(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "FindPass",
        Bridge.CreateFunction(
          "FindPass",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromInt32(o.FindPass(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "SetOverrideTag",
        Bridge.CreateFunction(
          "SetOverrideTag",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetOverrideTag(args[1].ToString(), args[2].ToString()))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTag",
        Bridge.CreateFunction(
          "GetTag",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromString(o.GetTag(args[1].ToString(), args[2].ToBoolean(), args[3].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTag",
        Bridge.CreateFunction(
          "GetTag",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromString(o.GetTag(args[1].ToString(), args[2].ToBoolean())))
        )
      );


      MaterialPrototype.SetProperty(
        "Lerp",
        Bridge.CreateFunction(
          "Lerp",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.Lerp(Bridge.GetExternal<UnityEngine.Material>(args[1]), Bridge.GetExternal<UnityEngine.Material>(args[2]), (float) args[3].ToDouble()))
        )
      );


      MaterialPrototype.SetProperty(
        "SetPass",
        Bridge.CreateFunction(
          "SetPass",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromBoolean(o.SetPass(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "CopyPropertiesFromMaterial",
        Bridge.CreateFunction(
          "CopyPropertiesFromMaterial",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.CopyPropertiesFromMaterial(Bridge.GetExternal<UnityEngine.Material>(args[1])))
        )
      );


      MaterialPrototype.SetProperty(
        "SetFloat",
        Bridge.CreateFunction(
          "SetFloat",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetFloat(args[1].ToString(), (float) args[2].ToDouble()))
        )
      );


      MaterialPrototype.SetProperty(
        "SetFloat",
        Bridge.CreateFunction(
          "SetFloat",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetFloat(args[1].ToInt32(), (float) args[2].ToDouble()))
        )
      );


      MaterialPrototype.SetProperty(
        "SetInt",
        Bridge.CreateFunction(
          "SetInt",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetInt(args[1].ToString(), args[2].ToInt32()))
        )
      );


      MaterialPrototype.SetProperty(
        "SetInt",
        Bridge.CreateFunction(
          "SetInt",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetInt(args[1].ToInt32(), args[2].ToInt32()))
        )
      );


      MaterialPrototype.SetProperty(
        "SetColor",
        Bridge.CreateFunction(
          "SetColor",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetColor(args[1].ToString(), Bridge.GetBoxedExternal<UnityEngine.Color>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetColor",
        Bridge.CreateFunction(
          "SetColor",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetColor(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Color>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetVector",
        Bridge.CreateFunction(
          "SetVector",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetVector(args[1].ToString(), Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetVector",
        Bridge.CreateFunction(
          "SetVector",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetVector(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Vector4>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetMatrix",
        Bridge.CreateFunction(
          "SetMatrix",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetMatrix(args[1].ToString(), Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetMatrix",
        Bridge.CreateFunction(
          "SetMatrix",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetMatrix(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Matrix4x4>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetTexture",
        Bridge.CreateFunction(
          "SetTexture",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetTexture(args[1].ToString(), Bridge.GetExternal<UnityEngine.Texture>(args[2])))
        )
      );


      MaterialPrototype.SetProperty(
        "SetTexture",
        Bridge.CreateFunction(
          "SetTexture",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetTexture(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Texture>(args[2])))
        )
      );


      MaterialPrototype.SetProperty(
        "SetBuffer",
        Bridge.CreateFunction(
          "SetBuffer",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetBuffer(args[1].ToString(), Bridge.GetExternal<UnityEngine.ComputeBuffer>(args[2])))
        )
      );


      MaterialPrototype.SetProperty(
        "SetBuffer",
        Bridge.CreateFunction(
          "SetBuffer",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetBuffer(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.ComputeBuffer>(args[2])))
        )
      );


      /*
        Material SetFloatArray
        System.Collections.Generic.List`1[System.Single] has generics
      */


      /*
        Material SetFloatArray
        System.Collections.Generic.List`1[System.Single] has generics
      */


      MaterialPrototype.SetProperty(
        "SetFloatArray",
        Bridge.CreateFunction(
          "SetFloatArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetFloatArray(args[1].ToString(), Bridge.GetExternal<System.Single[]>(args[2])))
        )
      );


      MaterialPrototype.SetProperty(
        "SetFloatArray",
        Bridge.CreateFunction(
          "SetFloatArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetFloatArray(args[1].ToInt32(), Bridge.GetExternal<System.Single[]>(args[2])))
        )
      );


      /*
        Material SetColorArray
        System.Collections.Generic.List`1[UnityEngine.Color] has generics
      */


      /*
        Material SetColorArray
        System.Collections.Generic.List`1[UnityEngine.Color] has generics
      */


      MaterialPrototype.SetProperty(
        "SetColorArray",
        Bridge.CreateFunction(
          "SetColorArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetColorArray(args[1].ToString(), Bridge.GetExternal<UnityEngine.Color[]>(args[2])))
        )
      );


      MaterialPrototype.SetProperty(
        "SetColorArray",
        Bridge.CreateFunction(
          "SetColorArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetColorArray(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Color[]>(args[2])))
        )
      );


      /*
        Material SetVectorArray
        System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
      */


      /*
        Material SetVectorArray
        System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
      */


      MaterialPrototype.SetProperty(
        "SetVectorArray",
        Bridge.CreateFunction(
          "SetVectorArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetVectorArray(args[1].ToString(), Bridge.GetExternal<UnityEngine.Vector4[]>(args[2])))
        )
      );


      MaterialPrototype.SetProperty(
        "SetVectorArray",
        Bridge.CreateFunction(
          "SetVectorArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetVectorArray(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Vector4[]>(args[2])))
        )
      );


      /*
        Material SetMatrixArray
        System.Collections.Generic.List`1[UnityEngine.Matrix4x4] has generics
      */


      /*
        Material SetMatrixArray
        System.Collections.Generic.List`1[UnityEngine.Matrix4x4] has generics
      */


      MaterialPrototype.SetProperty(
        "SetMatrixArray",
        Bridge.CreateFunction(
          "SetMatrixArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetMatrixArray(args[1].ToString(), Bridge.GetExternal<UnityEngine.Matrix4x4[]>(args[2])))
        )
      );


      MaterialPrototype.SetProperty(
        "SetMatrixArray",
        Bridge.CreateFunction(
          "SetMatrixArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetMatrixArray(args[1].ToInt32(), Bridge.GetExternal<UnityEngine.Matrix4x4[]>(args[2])))
        )
      );


      MaterialPrototype.SetProperty(
        "GetFloat",
        Bridge.CreateFunction(
          "GetFloat",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromDouble(o.GetFloat(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetFloat",
        Bridge.CreateFunction(
          "GetFloat",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromDouble(o.GetFloat(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetInt",
        Bridge.CreateFunction(
          "GetInt",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromInt32(o.GetInt(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetInt",
        Bridge.CreateFunction(
          "GetInt",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => JavaScriptValue.FromInt32(o.GetInt(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetColor",
        Bridge.CreateFunction(
          "GetColor",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetColor(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetColor",
        Bridge.CreateFunction(
          "GetColor",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetColor(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetVector",
        Bridge.CreateFunction(
          "GetVector",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetVector(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetVector",
        Bridge.CreateFunction(
          "GetVector",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetVector(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetMatrix",
        Bridge.CreateFunction(
          "GetMatrix",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetMatrix(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetMatrix",
        Bridge.CreateFunction(
          "GetMatrix",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetMatrix(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTexture",
        Bridge.CreateFunction(
          "GetTexture",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTexture(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTexture",
        Bridge.CreateFunction(
          "GetTexture",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTexture(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetFloatArray",
        Bridge.CreateFunction(
          "GetFloatArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetFloatArray(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetFloatArray",
        Bridge.CreateFunction(
          "GetFloatArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetFloatArray(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetColorArray",
        Bridge.CreateFunction(
          "GetColorArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetColorArray(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetColorArray",
        Bridge.CreateFunction(
          "GetColorArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetColorArray(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetVectorArray",
        Bridge.CreateFunction(
          "GetVectorArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetVectorArray(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetVectorArray",
        Bridge.CreateFunction(
          "GetVectorArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetVectorArray(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetMatrixArray",
        Bridge.CreateFunction(
          "GetMatrixArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetMatrixArray(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetMatrixArray",
        Bridge.CreateFunction(
          "GetMatrixArray",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetMatrixArray(args[1].ToInt32())))
        )
      );


      /*
        Material GetFloatArray
        System.Collections.Generic.List`1[System.Single] has generics
      */


      /*
        Material GetFloatArray
        System.Collections.Generic.List`1[System.Single] has generics
      */


      /*
        Material GetColorArray
        System.Collections.Generic.List`1[UnityEngine.Color] has generics
      */


      /*
        Material GetColorArray
        System.Collections.Generic.List`1[UnityEngine.Color] has generics
      */


      /*
        Material GetVectorArray
        System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
      */


      /*
        Material GetVectorArray
        System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
      */


      /*
        Material GetMatrixArray
        System.Collections.Generic.List`1[UnityEngine.Matrix4x4] has generics
      */


      /*
        Material GetMatrixArray
        System.Collections.Generic.List`1[UnityEngine.Matrix4x4] has generics
      */


      MaterialPrototype.SetProperty(
        "SetTextureOffset",
        Bridge.CreateFunction(
          "SetTextureOffset",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetTextureOffset(args[1].ToString(), Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetTextureOffset",
        Bridge.CreateFunction(
          "SetTextureOffset",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetTextureOffset(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetTextureScale",
        Bridge.CreateFunction(
          "SetTextureScale",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetTextureScale(args[1].ToString(), Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "SetTextureScale",
        Bridge.CreateFunction(
          "SetTextureScale",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => o.SetTextureScale(args[1].ToInt32(), Bridge.GetBoxedExternal<UnityEngine.Vector2>(args[2]).wrapped))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTextureOffset",
        Bridge.CreateFunction(
          "GetTextureOffset",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTextureOffset(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTextureOffset",
        Bridge.CreateFunction(
          "GetTextureOffset",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTextureOffset(args[1].ToInt32())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTextureScale",
        Bridge.CreateFunction(
          "GetTextureScale",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTextureScale(args[1].ToString())))
        )
      );


      MaterialPrototype.SetProperty(
        "GetTextureScale",
        Bridge.CreateFunction(
          "GetTextureScale",
          Bridge.WithExternal<UnityEngine.Material>((o, args) => Bridge.CreateExternalWithPrototype(o.GetTextureScale(args[1].ToInt32())))
        )
      );


    }
  }
}
