using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class RegisterProxy : SingletonMono<RegisterProxy>
    {
        /// <summary>
        /// 邮箱验证码
        /// </summary>
        public static Action EmailCodeAction;
        /// <summary>
        /// 邮箱注册
        /// </summary>
        public static Action EmailRegisterAction;

        /// <summary>
        /// 错误码
        /// </summary>       
        public static Action<MessageType, int, string> EmailSMSRegisterErrorAction;

        /// <summary>
        /// 获取邮箱注册验证码
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static async Task RequestEmailCode(string email)
        {
            await NetworkHeaders.RegisterEmailCode(email);
        }

        internal static Task RegisterSuccess(EmailRegisterCallBackMessage data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 邮箱注册
        /// </summary>
        /// <returns></returns>
        public static async Task RequestEmailRegister(string code, string email, string ucode , string pwd)
        {
            await NetworkHeaders.EmailRegister(code, email, ucode , pwd);
        }
    }
}


