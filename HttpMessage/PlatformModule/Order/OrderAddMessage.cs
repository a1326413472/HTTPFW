using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class OrderAddMessage : BaseHttpMessage
    {
        public PlatformOrderInfo body;

        public OrderAddMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/order/add";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }
    }


}