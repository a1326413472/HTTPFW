using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class OrderGetOrderMessage : BaseHttpMessage
    {
        public OrderGetOrderBody body;

        public OrderGetOrderMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/order/getOrder";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?orderId=" + body.orderId;
            }
        }
    }

    public struct OrderGetOrderBody
    {
        public string orderId;
    }
}