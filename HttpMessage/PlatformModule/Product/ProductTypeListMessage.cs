using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class ProductTypeListMessage : BaseHttpMessage
    {
        public ProductTypeListBody body;

        public ProductTypeListMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            methodType = HttpMethodType.Get;
            m_Path = "/v1/product/typeList";
            headers.Add("Content-Type", "application/json");
        }

        public override string path
        {
            get
            {
                return m_Path + "?type=" + body.type;
            }
        }
    }

    public struct ProductTypeListBody
    {
        public string type;
    }
}
