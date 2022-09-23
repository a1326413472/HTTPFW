using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class AirAddMessage : BaseHttpMessage
    {
        public AirAddBody body;

        public AirAddMessage()
        {
            messageModuleType = MessageModuleType.Air;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/air/add";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }
    }

    public struct AirAddBody
    {
        public Air air;
    }


    [System.Serializable]
    public class Air
    {
        public int createTime;
        public string from;
        public string id;
        public int num;
        public string price;
        public int status;
        public string to;
        public int updateTime;
    }
}
