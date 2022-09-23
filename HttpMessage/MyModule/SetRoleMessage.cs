using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class SetRoleMessage : BaseHttpMessage
    {
        public SetRoleBody body;

        public SetRoleMessage()
        {
            messageModuleType = MessageModuleType.My;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/client/setRole";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?color=" + body.color + "&nickName=" + body.nickName + "&sex=" + body.sex;
            }
        }
    }

    [System.Serializable]
    public struct SetRoleBody
    {
        public string color;
        public string nickName;
        public string sex;
    }
}
