using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class LoginHandler : Singleton<LoginHandler>
    {

        ///// <summary>
        ///// 账号登陆返回信息
        ///// </summary>
        ///// <param name="accountLoginCallBackMessage"></param>
        //public static async Task AccountLoginHandler(AccountLoginCallBackMessage accountLoginCallBackMessage)
        //{
        //    AccountLoginCallBackData data = accountLoginCallBackMessage.data;
        //    await LoginSuccess(data.token, data.unionId, data.platformToken);
        //    if (AccountLoginAction != null)
        //    {
        //        AccountLoginAction();
        //    }
        //}

        public static async Task LoginEmailCodeHandler(LoginEmailCodeCallBackMessage callBackMessage)
        {
            if (LoginProxy.EmailCodeAction != null)
            {
                LoginProxy.EmailCodeAction();
            }
        }

        public static async Task EmailLoginHandler(EmailLoginCallBackMessage callBackMessage)
        {
            LoginCallBackData data = callBackMessage.data;
            await LoginProxy.LoginSuccess(data);
            if (LoginProxy.EmailLoginAction != null)
            {
                LoginProxy.EmailLoginAction(data);
            }
        }

        public static async Task ForgetPwdHandler(ForgetPwdCallBackMessage callBackMessage)
        {
            if (LoginProxy.ForgetPwdAction != null)
            {
                LoginProxy.ForgetPwdAction();
            }
        }

        /// <summary>
        /// 错误信息汇总
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="code"></param>
        /// <param name="codeMessage"></param>
        /// <param name="baseHttpCallBackMessage"></param>
        public static async Task LoginErrorHandler(MessageType messageType, int code, string codeMessage, BaseHttpCallBackMessage baseHttpCallBackMessage = null)
        {
            switch (messageType)
            {
                case MessageType.None:
                    break;
                case MessageType.AdvanceAccountLoginType:
                case MessageType.AccountLoginType:
                case MessageType.CaptchaCodeType:
                    LoginProxy.AccountLoginErrorAction?.Invoke(messageType, code, codeMessage);
                    break;
                case MessageType.AdvancePhoneLoginType:
                case MessageType.PhoneLoginType:
                case MessageType.LoginSmsCodeType:
                    LoginProxy.PhoneSMSLoginErrorAction?.Invoke(messageType, code, codeMessage);
                    break;
                case MessageType.AdvanceEmailLoginType:
                case MessageType.EmailLoginType:
                case MessageType.LoginEmailCodeType:
                    LoginProxy.EmailSMSLoginErrorAction?.Invoke(messageType, code, codeMessage);
                    break;
                case MessageType.LogoutType:
                    LoginProxy.LogoutErrorAction?.Invoke(messageType, code, codeMessage);
                    break;
                case MessageType.LogOnQueryType:
                    LoginProxy.LogOnQueryErrorAction?.Invoke(messageType, code, codeMessage);
                    break;
            }
        }
    }

}
