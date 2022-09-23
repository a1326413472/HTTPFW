using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class FireworkUpdateMessage : BaseHttpMessage
    {
        public FireworkUpdateBody body;

        public FireworkUpdateMessage()
        {
            messageModuleType = MessageModuleType.Firework;
            methodType = HttpMethodType.Get;
            m_Path = "/v1/firework/update";
            headers = new Dictionary<string, string>();
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?id=" + body.id;
            }
        }
    }

    public struct FireworkUpdateBody
    {
        public string id;
    }

}
