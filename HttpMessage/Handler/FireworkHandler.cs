using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class FireworkHandler : Singleton<AirHandler>
    {
        public static async Task FireworkCreateHandler(FireworkCreateCallBackMessage callBackMessage)
        {
            if (FireworkProxy.FireworkCreateAction != null)
            {
                FireworkProxy.FireworkCreateAction();
            }
        }

        public static async Task FireworkListHandler(FireworkListCallBackMessage callBackMessage)
        {
            FireworkCallBackData data = callBackMessage.data;
            await FireworkProxy.FireworkListSuccess(data);
            if (FireworkProxy.FireworkListAction != null)
            {
                FireworkProxy.FireworkListAction();
            }
        }

        public static async Task FireworkUpdateHandler(FireworkUpdateCallBackMessage callBackMessage)
        {
            if (FireworkProxy.FireworkUpdateAction != null)
            {
                FireworkProxy.FireworkUpdateAction();
            }
        }


    }
}

