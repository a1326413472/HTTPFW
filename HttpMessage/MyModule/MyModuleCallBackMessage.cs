using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{

    public class MyModuleCallBackMessage
    {

    }

    [System.Serializable]
    public class UserCallBackData : UserInfo, ICallData
    {
    }

    [System.Serializable]
    public class GetUserInfoCallBackMessage : BaseHttpCallBackMessage
    {
        public UserCallBackData data;
        public GetUserInfoCallBackMessage()
        {
            m_MessageType = MessageType.GetUserInfoType;
            messageModuleType = MessageModuleType.My;
        }
    }

    [System.Serializable]
    public class SetRoleCallBackMessage : BaseHttpCallBackMessage
    {
        public UserCallBackData data;
        public SetRoleCallBackMessage()
        {
            m_MessageType = MessageType.SetRoleType;
            messageModuleType = MessageModuleType.My;
        }
    }
}