using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class LoginEmailCodeMessage : BaseHttpMessage
    {
        public LoginEmailCodeBody body;

        public LoginEmailCodeMessage()
        {
            messageModuleType = MessageModuleType.Login;
            methodType = HttpMethodType.Get;

            m_Path = "/v1/public/sendMail";
        }

        public override string path
        {
            get
            {
                return m_Path + "?email=" + body.email;
            }
        }
    }

    public struct LoginEmailCodeBody
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        public string email;
    }
}


