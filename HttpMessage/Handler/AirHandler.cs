using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class AirHandler : Singleton<AirHandler>
    {
        public static async Task AirAddHandler(AirAddCallBackMessage callBackMessage)
        {
            AirAddCallBackData data = callBackMessage.data;
            await AirProxy.AirAddSuccess(data);
            if (AirProxy.AirAddAction != null)
            {
                AirProxy.AirAddAction();
            }
        }

        public static async Task AirGetOneHandler(AirGetOneCallBackMessage callBackMessage)
        {
            AirCallBackData data = callBackMessage.data;
            await AirProxy.AirGetSuccess(data);
            if (AirProxy.AirGetOneAction != null)
            {
                AirProxy.AirGetOneAction();
            }
        }

        public static async Task AirGetOneByToHandler(AirGetOneByToCallBackMessage callBackMessage)
        {
            AirCallBackData data = callBackMessage.data;
            await AirProxy.AirGetSuccess(data);
            if (AirProxy.AirGetOneByToAction != null)
            {
                AirProxy.AirGetOneByToAction();
            }
        }

        public static async Task AirListHandler(AirListCallBackMessage callBackMessage)
        {
            AirCallBackData data = callBackMessage.data;
            await AirProxy.AirGetSuccess(data);
            if (AirProxy.AirListAction != null)
            {
                AirProxy.AirListAction();
            }
        }

        public static async Task AirUpdateHandler(AirUpdateCallBackMessage callBackMessage)
        {
            AirCallBackData data = callBackMessage.data;
            await AirProxy.AirUpdateSuccess(data);
            if (AirProxy.AirUpdateAction != null)
            {
                AirProxy.AirUpdateAction();
            }
        }

        public static async Task AirUpdateStatusHandler(AirUpdateStatusCallBackMessage callBackMessage)
        {
            AirCallBackData data = callBackMessage.data;
            await AirProxy.AirUpdateSuccess(data);
            if (AirProxy.AirUpdateStatusAction != null)
            {
                AirProxy.AirUpdateStatusAction();
            }
        }
    }
}
