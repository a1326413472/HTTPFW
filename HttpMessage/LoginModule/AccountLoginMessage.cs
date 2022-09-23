using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class AccountLoginMessage : BaseHttpMessage
    {
        public AccountLoginBody body;

        public AccountLoginMessage()
        {
            messageModuleType = MessageModuleType.Login;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/accountLogin";
            headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }
    }

    public struct AccountLoginBody
    {
        /// <summary>
        /// 账户
        /// </summary>
        public string account;
        /// <summary>
        /// 密码
        /// </summary>
        public string password;
        /// <summary>
        /// 设备id
        /// </summary>
        public string deviceId;
        /// <summary>
        /// 设备类型
        /// </summary>
        public string deviceType;
        /// <summary>
        /// 设备系统
        /// </summary>
        public string deviceOS;
        /// <summary>
        /// 登陆设备来源
        /// </summary>
        public string source;
        /// <summary>
        /// 验证码id(必须)
        /// </summary>
        public string captchaId;
        /// <summary>
        /// 验证码(必须)
        /// </summary>
        public string captchaValue;
    }

}