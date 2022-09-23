using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class EmailRegisterMessage : BaseHttpMessage
    {
        public EmailRegisterBody body;

        public EmailRegisterMessage()
        {
            messageModuleType = MessageModuleType.Register;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/public/register";
            headers.Add("Content-Type", "application/json");
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }

    }

    public struct EmailRegisterBody
    {
        public string code;
        public string email;
        public string ucode;
        public string pwd;
    }
}

