using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class FireworkListMessage : BaseHttpMessage
    {
        public FireworkListBody body;

        public FireworkListMessage()
        {
            messageModuleType = MessageModuleType.Firework;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/firework/list";
            headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?uid=" + body.uid;
            }
        }
    }

    public struct FireworkListBody
    {
        public string uid;
    }
}
