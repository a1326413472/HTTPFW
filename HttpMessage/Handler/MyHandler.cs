using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class MyHandler : Singleton<MyHandler>
    {
        public static async Task GetUserInfoHandler(GetUserInfoCallBackMessage callBackMessage, Action<UserCallBackData> callBack = null)
        {
            UserCallBackData data = callBackMessage.data;
            await MyProxy.GetUserInfoSuccess(data);
            callBack?.Invoke(data);
        }

        public static async Task SetRoleHandler(SetRoleCallBackMessage callBackMessage, Action<UserCallBackData> callBack = null)
        {
            UserCallBackData data = callBackMessage.data;
            await MyProxy.SetRoleSuccess(data);
            callBack?.Invoke(data);
        }
    }
}


