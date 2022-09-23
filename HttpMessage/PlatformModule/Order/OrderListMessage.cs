using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class OrderListMessage : BaseHttpMessage
    {
        public OrderListBody body;

        public OrderListMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/order/list";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?pageNum=" + body.pageNum + "&pageSize=" + body.pageSize;
            }
        }
    }

    public struct OrderListBody
    {
        public int pageNum;
        public string pageSize;
    }
}
