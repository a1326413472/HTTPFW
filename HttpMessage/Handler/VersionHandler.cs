using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class VersionHandler : Singleton<VersionHandler>
    {
        public static async Task GetVersionHandler(GetVersionCallBackMessage callBackMessage, Action<VersionCallBackData> callBack = null)
        {
            VersionCallBackData data = callBackMessage.data;
            await VersionProxy.GetVersionSuccess(data);
            callBack?.Invoke(data);
        }

        public static async Task UpdateVersionHandler(UpdateVersionCallBackMessage callBackMessage)
        {
            VersionInfo data = callBackMessage.data;
            await VersionProxy.UpdateVersionSuccess(data);
            if (VersionProxy.UpdateVersionAction != null)
            {
                VersionProxy.UpdateVersionAction();
            }
        }
    }
}
