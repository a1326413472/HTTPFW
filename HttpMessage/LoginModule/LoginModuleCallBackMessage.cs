using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{

    public class LoginModuleCallBackMessage
    {
    }

    //public class AccountLoginCallBackMessage : BaseHttpCallBackMessage
    //{
    //    public LoginCallBackData data;
    //    public AccountLoginCallBackMessage()
    //    {
    //        messageModuleType = MessageModuleType.Login;
    //        m_MessageType = MessageType.AccountLoginType;
    //    }
    //}

    [System.Serializable]
    public class LoginCallBackData : ICallData
    {
        public LoginCallBackData()
        {
            token = "";
            userInfo = new UserInfo();
        }

        public string token;//登录token
        public UserInfo userInfo;
        //public string unionId;//用户uuid
        //public string platformToken;//平台Token
    }


    public class LoginEmailCodeCallBackMessage : BaseHttpCallBackMessage
    { 
        
    }

    public class EmailLoginCallBackMessage : BaseHttpCallBackMessage
    {        
        public LoginCallBackData data;
        public EmailLoginCallBackMessage()
        {
            messageModuleType = MessageModuleType.Login;
            m_MessageType = MessageType.EmailLoginType;
        }
    }

    public class ForgetPwdCallBackMessage : BaseHttpCallBackMessage
    {

    }
}
