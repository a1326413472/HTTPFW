using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;
using System;
using System.Threading.Tasks;
using LitJson;

namespace Alpha.Unity.Http
{
    public class LoginProxy : Singleton<LoginProxy>
    {
        /// <summary>
        /// 账号登录
        /// </summary>
        public static Action AccountLoginAction;
        /// <summary>
        /// 邮箱验证码
        /// </summary>
        public static Action EmailCodeAction;
        /// <summary>
        /// 邮箱登录
        /// </summary>
        public static Action<LoginCallBackData> EmailLoginAction;
        /// <summary>
        /// 忘记密码
        /// </summary>
        public static Action ForgetPwdAction;

        /// <summary>
        /// 错误码
        /// </summary>       
        public static Action<MessageType, int, string> AccountLoginErrorAction;
        public static Action<MessageType, int, string> PhoneSMSLoginErrorAction;
        public static Action<MessageType, int, string> EmailSMSLoginErrorAction;
        public static Action<MessageType, int, string> LogoutErrorAction;
        public static Action<MessageType, int, string> LogOnQueryErrorAction;

        ///// <summary>
        ///// 账号登录
        ///// </summary>
        ///// <param name="account"></param>
        ///// <param name="password"></param>
        ///// <param name="captchaId"></param>
        ///// <param name="captchaValue"></param>
        //public static async Task RequestAccountLogin(string account, string password)
        //{
        //    await NetworkHeaders.AccountLogin(account, password);
        //}

        /// <summary>
        /// 获取邮箱登录验证码
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static async Task RequestEmailCode(string email)
        {
            await NetworkHeaders.LoginEmailCode(email);
        }

        public static async Task RequestEmailLogin(string pwd, string email)
        {
            await NetworkHeaders.EmailLogin(pwd, email);
        }

        public static async Task RequestForgetPwd(string code, string email, string pwd, string ucode)
        {
            await NetworkHeaders.ForgetPwd(code, email, pwd, ucode);
        }

        /// <summary>
        /// 登录成功
        /// </summary>
        public static async Task LoginSuccess(LoginCallBackData loginCallBackData)
        {
            ServerConfigMgr.Token = loginCallBackData.token;
            DynamicUserModel.Instance.userInfo = loginCallBackData.userInfo;
            LitJsonMgr.Instance.WriteEncryJson<LoginCallBackData>("LoginData", loginCallBackData);
            Debug.Log("登陆成功 ：" + JsonMapper.ToJson(loginCallBackData));
        }
        
    }
}
