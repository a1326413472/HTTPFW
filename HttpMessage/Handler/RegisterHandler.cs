using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class RegisterHandler : Singleton<RegisterHandler>
    {

        public static async Task RegisterEmailCodeHandler(RegisterEmailCodeCallBackMessage callBackMessage)
        {
            if (RegisterProxy.EmailCodeAction != null)
            {
                RegisterProxy.EmailCodeAction();
            }
        }

        public static async Task EmailRegisterHandler(EmailRegisterCallBackMessage callBackMessage)
        {
            if (RegisterProxy.EmailRegisterAction != null)
            {
                RegisterProxy.EmailRegisterAction();
            }
        }

        /// <summary>
        /// 错误信息汇总
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="code"></param>
        /// <param name="codeMessage"></param>
        /// <param name="baseHttpCallBackMessage"></param>
        public static async Task RegisterErrorHandler(MessageType messageType, int code, string codeMessage, BaseHttpCallBackMessage baseHttpCallBackMessage = null)
        {
            switch (messageType)
            {
                case MessageType.EmailRegisterType:
                case MessageType.RegisterEmailCodeType:
                    RegisterProxy.EmailSMSRegisterErrorAction?.Invoke(messageType, code, codeMessage);
                    break;
            }
        }
    }
}
