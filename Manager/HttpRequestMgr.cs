using XRTools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace XRTools
{
    public class HttpRequestMgr : SingletonMono<HttpRequestMgr>
    {
        public static async Task Post(string url, Dictionary<string, string> header, string encryptData, Action<string> successCallback = null, Action<string> failCallback = null)
        {
            await Request(url, UnityWebRequest.kHttpVerbPOST, header, encryptData, successCallback, failCallback);
        }

        public static async Task Get(string url, Dictionary<string, string> header, string encryptData, Action<string> successCallback = null, Action<string> failCallback = null)
        {
            await Request(url, UnityWebRequest.kHttpVerbGET, header, encryptData, successCallback, failCallback);
        }

        public static async Task Request(string url, string webMethod, Dictionary<string, string> header, string encryptData, Action<string> successCallback = null, Action<string> failCallback = null)
        {
            Debug.Log("url : " + url);
            Debug.Log("header : " + JsonUtility.ToJson(header));
            Debug.Log("encryptData : " + encryptData);

            using (UnityWebRequest webRequest = new UnityWebRequest(url, webMethod))
            {
                if (webMethod == UnityWebRequest.kHttpVerbPOST && !string.IsNullOrEmpty(encryptData))
                {
                    webRequest.uploadHandler = (UploadHandler)new UploadHandlerRaw(Encoding.Default.GetBytes(encryptData));
                }

                webRequest.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();

                foreach (var v in header)
                {
                    webRequest.SetRequestHeader(v.Key, v.Value);
                }
                
                await webRequest.SendWebRequest();

                if (webRequest.isNetworkError || webRequest.isHttpError)
                {
                    if (failCallback != null)
                    {
                        failCallback(webRequest.error);
                        Debug.Log("failCallback : " + webRequest.error);
                    }
                }
                else
                {
                    if (successCallback != null)
                    {
                        successCallback(webRequest.downloadHandler.text);
                        Debug.Log("successCallback : " + webRequest.downloadHandler.text);
                    }
                }
            }
        }

        public IEnumerator GetsDataQueue(string url, Dictionary<string, string> header, string encryptData, Action<string> successCallback = null, Action<string> failCallback = null)
        {
            yield return StartCoroutine(RequestsDataQueue(url, UnityWebRequest.kHttpVerbGET, header, encryptData, successCallback, failCallback));
        }

        public IEnumerator PostsDataQueue(string url, Dictionary<string, string> header, string encryptData, Action<string> successCallback = null, Action<string> failCallback = null)
        {
            yield return StartCoroutine(RequestsDataQueue(url, UnityWebRequest.kHttpVerbPOST, header, encryptData, successCallback, failCallback));
        }

        public IEnumerator RequestsDataQueue(string url, string webMethod, Dictionary<string, string> header, string encryptData, Action<string> successCallback = null, Action<string> failCallback = null)
        {
            using (UnityWebRequest webRequest = new UnityWebRequest(url, webMethod))
            {
                if (webMethod == UnityWebRequest.kHttpVerbPOST && !string.IsNullOrEmpty(encryptData))
                {
                    webRequest.uploadHandler = (UploadHandler)new UploadHandlerRaw(Encoding.Default.GetBytes(encryptData));
                }

                webRequest.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();

                foreach (var v in header)
                {
                    webRequest.SetRequestHeader(v.Key, v.Value);
                }

                yield return webRequest.SendWebRequest();

                if (webRequest.isNetworkError || webRequest.isHttpError)
                {
                    if (failCallback != null)
                    {
                        failCallback(webRequest.error);
                    }
                }
                else
                {
                    if (successCallback != null)
                    {
                        successCallback(webRequest.downloadHandler.text);
                    }
                }
            }
        }
    }

}

