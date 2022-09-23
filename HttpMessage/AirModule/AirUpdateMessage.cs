using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class AirUpdateMessage : BaseHttpMessage
    {
        public AirAddBody body;

        public AirUpdateMessage()
        {
            messageModuleType = MessageModuleType.Air;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/air/update";
            headers.Add("Content-Type", "application/json");
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }
    }
}
