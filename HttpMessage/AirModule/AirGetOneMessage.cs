using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class AirGetOneMessage : BaseHttpMessage
    {
        public AirGetOneBody body;

        public AirGetOneMessage()
        {
            messageModuleType = MessageModuleType.Air;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/air/getOne";
            headers.Add("Content-Type", "application/json");
        }

        public override string path
        {
            get
            {
                return m_Path + "?id=" + body.id;
            }
        }
    }

    public struct AirGetOneBody
    {
        public string id;
    }
}
