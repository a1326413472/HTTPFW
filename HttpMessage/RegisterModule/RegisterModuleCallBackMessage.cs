using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class RegisterModuleCallBackMessage
    {
    }

    public class RegisterEmailCodeCallBackMessage : BaseHttpCallBackMessage
    {

    }

    public class EmailRegisterCallBackMessage : BaseHttpCallBackMessage
    {
        public LoginCallBackData data;
        public EmailRegisterCallBackMessage()
        {
            messageModuleType = MessageModuleType.Register;
            m_MessageType = MessageType.EmailRegisterType;
        }
    }
}


