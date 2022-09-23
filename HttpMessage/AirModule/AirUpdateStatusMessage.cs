using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class AirUpdateStatusMessage : BaseHttpMessage
    {
        public AirUpdateStatusBody body;

        public AirUpdateStatusMessage()
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
                return m_Path + "?id=" + body.id + "&status=" + body.status;
            }
        }
    }

    public struct AirUpdateStatusBody
    {
        public string id;
        public string status;
    }
}
