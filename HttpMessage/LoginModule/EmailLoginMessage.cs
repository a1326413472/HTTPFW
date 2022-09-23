using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class EmailLoginMessage : BaseHttpMessage
    {
        public EmailLoginBody body;

        public EmailLoginMessage()
        {
            messageModuleType = MessageModuleType.Login;
            methodType = HttpMethodType.Post;
            //m_Path = "/v1/public/login";
            m_Path = "/login/";
            headers.Add("Content-Type", "application/json");
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }

    }

    public struct EmailLoginBody
    {
        public string password;
        public string username;
    }
}


