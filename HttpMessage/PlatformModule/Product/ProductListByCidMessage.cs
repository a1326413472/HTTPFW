using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class ProductListByCidMessage : BaseHttpMessage
    {
        public ProductListByCidBody body;

        public ProductListByCidMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/product/listByCid";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?cityId=" + body.cityId;
            }
        }
    }

    public struct ProductListByCidBody
    {
        public string cityId;
    }
}


