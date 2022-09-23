using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class VersionProxy
    {
        public static Action GetVersionAction;
        public static Action UpdateVersionAction;

        /// <summary>
        /// 查询 版本信息
        /// </summary>
        public static async Task RequestGetVersion(Action<VersionInfo> callBackAction = null)
        {
            await NetworkHeaders.GetVersion(callBackAction);
        }

        /// <summary>
        /// 版本 更新
        /// </summary>
        public static async Task RequestUpdateVersion(VersionInfo versionInfo)
        {
            await NetworkHeaders.UpdateVersion(versionInfo);
        }

        public static async Task GetVersionSuccess(VersionInfo callBackData)
        {
            DynamicVersionModel.Instance.versionInfo = callBackData;
            Debug.Log("查询版本信息成功 ：" + JsonMapper.ToJson(callBackData));
        }

        public static async Task UpdateVersionSuccess(VersionInfo callBackData)
        {
            DynamicVersionModel.Instance.versionInfo = callBackData;
            Debug.Log("版本更新成功 ：" + JsonMapper.ToJson(callBackData));
        }
    }
}
