declare namespace UnityEngine {
  class Material extends UnityEngine.Object {
    // Static Fields

    // Static Property Accessors

    // Static Methods

    // Instance Fields

    // Instance Property Accessors

    shader: UnityEngine.Shader;

    color: UnityEngine.Color;

    mainTexture: UnityEngine.Texture;

    mainTextureOffset: UnityEngine.Vector2;

    mainTextureScale: UnityEngine.Vector2;

    renderQueue: number;

    globalIlluminationFlags: UnityEngine.MaterialGlobalIlluminationFlags;

    doubleSidedGI: boolean;

    enableInstancing: boolean;

    readonly passCount: number;

    shaderKeywords: System.String[];

    // Instance Methods

    GetTexturePropertyNames(): System.String[];

    GetTexturePropertyNameIDs(): System.Int32[];

    /*
            Material GetTexturePropertyNames
            System.Collections.Generic.List`1[System.String] has generics
          */

    /*
            Material GetTexturePropertyNameIDs
            System.Collections.Generic.List`1[System.Int32] has generics
          */

    HasProperty(nameID: number): boolean;

    HasProperty(name: string): boolean;

    EnableKeyword(keyword: string): void;

    DisableKeyword(keyword: string): void;

    IsKeywordEnabled(keyword: string): boolean;

    SetShaderPassEnabled(passName: string, enabled: boolean): void;

    GetShaderPassEnabled(passName: string): boolean;

    GetPassName(pass: number): string;

    FindPass(passName: string): number;

    SetOverrideTag(tag: string, val: string): void;

    GetTag(tag: string, searchFallbacks: boolean, defaultValue: string): string;

    GetTag(tag: string, searchFallbacks: boolean): string;

    Lerp(
      start: UnityEngine.Material,
      end: UnityEngine.Material,
      t: number
    ): void;

    SetPass(pass: number): boolean;

    CopyPropertiesFromMaterial(mat: UnityEngine.Material): void;

    SetFloat(name: string, value: number): void;

    SetFloat(nameID: number, value: number): void;

    SetInt(name: string, value: number): void;

    SetInt(nameID: number, value: number): void;

    SetColor(name: string, value: UnityEngine.Color): void;

    SetColor(nameID: number, value: UnityEngine.Color): void;

    SetVector(name: string, value: UnityEngine.Vector4): void;

    SetVector(nameID: number, value: UnityEngine.Vector4): void;

    SetMatrix(name: string, value: UnityEngine.Matrix4x4): void;

    SetMatrix(nameID: number, value: UnityEngine.Matrix4x4): void;

    SetTexture(name: string, value: UnityEngine.Texture): void;

    SetTexture(nameID: number, value: UnityEngine.Texture): void;

    SetBuffer(name: string, value: UnityEngine.ComputeBuffer): void;

    SetBuffer(nameID: number, value: UnityEngine.ComputeBuffer): void;

    /*
            Material SetFloatArray
            System.Collections.Generic.List`1[System.Single] has generics
          */

    /*
            Material SetFloatArray
            System.Collections.Generic.List`1[System.Single] has generics
          */

    SetFloatArray(name: string, values: System.Single[]): void;

    SetFloatArray(nameID: number, values: System.Single[]): void;

    /*
            Material SetColorArray
            System.Collections.Generic.List`1[UnityEngine.Color] has generics
          */

    /*
            Material SetColorArray
            System.Collections.Generic.List`1[UnityEngine.Color] has generics
          */

    SetColorArray(name: string, values: UnityEngine.Color[]): void;

    SetColorArray(nameID: number, values: UnityEngine.Color[]): void;

    /*
            Material SetVectorArray
            System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
          */

    /*
            Material SetVectorArray
            System.Collections.Generic.List`1[UnityEngine.Vector4] has generics
          */

    SetVectorArray(name: string, values: UnityEngine.Vector4[]): void;

    SetVectorArray(nameID: number, values: UnityEngine.Vector4[]): void;

    /*
            Material SetMatrixArray
            System.Collections.Generic.List`1[UnityEngine.Matrix4x4] has generics
          */

    /*
            Material SetMatrixArray
            System.Collections.Generic.List`1[UnityEngine.Matrix4x4] has generics
          */

    SetMatrixArray(name: string, values: UnityEngine.Matrix4x4[]): void;

    SetMatrixArray(nameID: number, values: UnityEngine.Matrix4x4[]): void;

    GetFloat(name: string): number;

    GetFloat(nameID: number): number;

    GetInt(name: string): number;

    GetInt(nameID: number): number;

    GetColor(name: string): UnityEngine.Color;

    GetColor(nameID: number): UnityEngine.Color;

    GetVector(name: string): UnityEngine.Vector4;

    GetVector(nameID: number): UnityEngine.Vector4;

    GetMatrix(name: string): UnityEngine.Matrix4x4;

    GetMatrix(nameID: number): UnityEngine.Matrix4x4;

    GetTexture(name: string): UnityEngine.Texture;

    GetTexture(nameID: number): UnityEngine.Texture;

    GetFloatArray(name: string): System.Single[];

    GetFloatArray(nameID: number): System.Single[];

    GetColorArray(name: string): UnityEngine.Color[];

    GetColorArray(nameID: number): UnityEngine.Color[];

    GetVectorArray(name: string): UnityEngine.Vector4[];

    GetVectorArray(nameID: number): UnityEngine.Vector4[];

    GetMatrixArray(name: string): UnityEngine.Matrix4x4[];

    GetMatrixArray(nameID: number): UnityEngine.Matrix4x4[];

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

    SetTextureOffset(name: string, value: UnityEngine.Vector2): void;

    SetTextureOffset(nameID: number, value: UnityEngine.Vector2): void;

    SetTextureScale(name: string, value: UnityEngine.Vector2): void;

    SetTextureScale(nameID: number, value: UnityEngine.Vector2): void;

    GetTextureOffset(name: string): UnityEngine.Vector2;

    GetTextureOffset(nameID: number): UnityEngine.Vector2;

    GetTextureScale(name: string): UnityEngine.Vector2;

    GetTextureScale(nameID: number): UnityEngine.Vector2;
  }
}
