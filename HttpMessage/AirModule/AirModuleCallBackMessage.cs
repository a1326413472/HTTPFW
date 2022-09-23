using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class AirModuleCallBackMessage
    {
    }

    [System.Serializable]
    public class AirCallBackData : AirInfo, ICallData
    {
        public AirCallBackData()
        { 
            
        }
    }

    [System.Serializable]
    public class AirAddCallBackData : ICallData
    {
        public AirAddCallBackData()
        {
            id = "";
        }

        public string id;
    }

    public class AirAddCallBackMessage : BaseHttpCallBackMessage
    {
        public AirAddCallBackData data;
        public AirAddCallBackMessage()
        {
            messageModuleType = MessageModuleType.Air;
            m_MessageType = MessageType.AirAddType;
        }
    }

    public class AirGetOneCallBackMessage : BaseHttpCallBackMessage
    {
        public AirCallBackData data;
        public AirGetOneCallBackMessage()
        {
            messageModuleType = MessageModuleType.Air;
            m_MessageType = MessageType.AirGetOneType;
        }
    }

    public class AirGetOneByToCallBackMessage : BaseHttpCallBackMessage
    {
        public AirCallBackData data;
        public AirGetOneByToCallBackMessage()
        {
            messageModuleType = MessageModuleType.Air;
            m_MessageType = MessageType.AirGetOneByToType;
        }
    }

    public class AirListCallBackMessage : BaseHttpCallBackMessage
    {
        public AirCallBackData data;
        public AirListCallBackMessage()
        {
            messageModuleType = MessageModuleType.Air;
            m_MessageType = MessageType.AirListType;
        }
    }

    public class AirUpdateCallBackMessage : BaseHttpCallBackMessage
    {
        public AirCallBackData data;
        public AirUpdateCallBackMessage()
        {
            messageModuleType = MessageModuleType.Air;
            m_MessageType = MessageType.AirUpdateType;
        }
    }

    public class AirUpdateStatusCallBackMessage : BaseHttpCallBackMessage
    {
        public AirCallBackData data;
        public AirUpdateStatusCallBackMessage()
        {
            messageModuleType = MessageModuleType.Air;
            m_MessageType = MessageType.AirUpdateStatusType;
        }
    }
}
