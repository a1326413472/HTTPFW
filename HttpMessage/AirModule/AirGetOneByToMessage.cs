using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class AirGetOneByToMessage : BaseHttpMessage
    {
        public AirGetOneByToBody body;

        public AirGetOneByToMessage()
        {
            messageModuleType = MessageModuleType.Air;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/air/add";
            headers.Add("Content-Type", "application/json");
        }

        public override string path
        {
            get
            {
                return m_Path + "?to=" + body.to;
            }
        }
    }

    public struct AirGetOneByToBody
    {
        public string to;
    }
}
