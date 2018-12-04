using System;
using System.Collections;
using System.Runtime.InteropServices;
using ChakraCore.API;
using UnityEngine;
using UnityEngine.Networking;

namespace JavaScript.API {
  class Http {
    public static void Register(JavaScriptContext context) {
      var http = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.SetProperty("http", http);

      http.SetProperty(
        "get",
        Bridge.CreateFunction((args) => {
          string url = args[1].ToString();
          JavaScriptValue callback = args[2];
          if (callback.ValueType != JavaScriptValueType.Function) throw new Exception("arg 2 not function");
          bool wantsArrayBuffer = args.Length > 3 ? args[3].ToBoolean() : false;

          callback.AddRef(); // call Release later!

          Engine.instance.StartCoroutine(HttpGet(url, MakeHttpCallback(callback, wantsArrayBuffer)));

        })); // http.get

      http.SetProperty(
        "post",
        Bridge.CreateFunction((args) => {
          string url = args[1].ToString();
          string postData = args[2].ToString();
          JavaScriptValue callback = args[3];
          if (callback.ValueType != JavaScriptValueType.Function) throw new Exception("arg 2 not function");
          bool wantsArrayBuffer = args.Length > 4 ? args[4].ToBoolean() : false;

          callback.AddRef(); // call Release later!

          Engine.instance.StartCoroutine(HttpPost(url, postData, MakeHttpCallback(callback, wantsArrayBuffer)));

        })); // http.post

    } // Register


    static Action<UnityWebRequest> MakeHttpCallback(JavaScriptValue callback, bool wantsArrayBuffer = false) {
      return (www) => {
        if (www.isNetworkError || www.isHttpError) {
          Engine.With(() => {
            try {
              callback.CallFunction(
                JavaScriptValue.Undefined,
                JavaScriptValue.FromString(www.error),
                JavaScriptValue.Null
              );
            } catch (Exception e) {
              Debug.LogError(e);
            } finally {
              callback.Release();
            }
          });
          return;
        }

        if (!wantsArrayBuffer) {
          string text = www.downloadHandler.text;
          Engine.With(() => {
            try {
              callback.CallFunction(
                JavaScriptValue.Undefined,
                JavaScriptValue.Null,
                JavaScriptValue.FromString(text)
              );
            } catch (Exception e) {
              Debug.LogError(e);
            } finally {
              callback.Release();
            }
          });

        } else { // ArrayBuffer
          byte[] bytes = www.downloadHandler.data;
          IntPtr unmanagedPointer = Marshal.AllocHGlobal(bytes.Length);
          Marshal.Copy(bytes, 0, unmanagedPointer, bytes.Length);

          Engine.With(() => {
            Debug.Log("created ptr " + unmanagedPointer);
            JavaScriptValue buffer = JavaScriptValue.CreateExternalArrayBuffer(
              unmanagedPointer,
              (uint) bytes.Length,
              (ptr) => {
                Debug.Log("freeing " + ptr);
                Marshal.FreeHGlobal(ptr);
              },
              unmanagedPointer // pass it in since the upvalue will die! (probably)
            );
            try {
              callback.CallFunction(
                JavaScriptValue.Undefined,
                JavaScriptValue.Null,
                buffer
              );
            } catch (Exception e) {
              Debug.LogError(e);
            } finally {
              callback.Release();
            }
          });
        }

      };
    }


    static IEnumerator HttpGet(string url, Action<UnityWebRequest> callback) {
      UnityWebRequest www = UnityWebRequest.Get(url);
      yield return www.SendWebRequest();

      callback(www);
    }

    static IEnumerator HttpGetTexture(string url, Action<UnityWebRequest> callback) {
      UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
      yield return www.SendWebRequest();

      callback(www); // AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
    }

    static IEnumerator HttpPost(string url, string postData, Action<UnityWebRequest> callback) {
      UnityWebRequest www = UnityWebRequest.Post(url, postData);
      yield return www.SendWebRequest();

      callback(www);
    }

  }
}
