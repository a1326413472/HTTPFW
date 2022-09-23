using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class RegisterEmailCodeMessage : BaseHttpMessage
    {
        public RegisterEmailCodeBody body;

        public RegisterEmailCodeMessage()
        {
            messageModuleType = MessageModuleType.Register;
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

    public struct RegisterEmailCodeBody
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        public string email;
    }
}


