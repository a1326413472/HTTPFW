using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{

    public class VersionCallBackMessage
    {
    }

    [System.Serializable]
    public class VersionCallBackData : VersionInfo ,ICallData
    {
    }

    public class GetVersionCallBackMessage : BaseHttpCallBackMessage
    {
        public VersionCallBackData data;
        public GetVersionCallBackMessage()
        {
            messageModuleType = MessageModuleType.Version;
            m_MessageType = MessageType.GetVersionType;
        }
    }

    public class UpdateVersionCallBackMessage : BaseHttpCallBackMessage
    {
        public VersionCallBackData data;
        public UpdateVersionCallBackMessage()
        {
            messageModuleType = MessageModuleType.Version;
            m_MessageType = MessageType.UpdateVersionType;
        }
    }
}
