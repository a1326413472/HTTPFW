using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class FireworkCreateMessage : BaseHttpMessage
    {
        public FireworkInfo body;

        public FireworkCreateMessage()
        {
            messageModuleType = MessageModuleType.Firework;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/firework/create";
            headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }
    }
}
