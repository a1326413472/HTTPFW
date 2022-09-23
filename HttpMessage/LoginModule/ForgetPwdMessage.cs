using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class ForgetPwdMessage : BaseHttpMessage
    {
        public ForgetPwdBody body;

        public ForgetPwdMessage()
        {
            messageModuleType = MessageModuleType.Login;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/public/forgetPwd";
            headers.Add("Content-Type", "application/json");
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }
    }

    public struct ForgetPwdBody
    {
        public string code;
        public string email;
        public string pwd;
        public string ucode;
    }
}
