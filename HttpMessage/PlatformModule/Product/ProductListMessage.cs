using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class ProductListMessage : BaseHttpMessage
    {
        public ProductListMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/product/list";
            headers.Add("Content-Type", "application/json");
        }
    }


}
