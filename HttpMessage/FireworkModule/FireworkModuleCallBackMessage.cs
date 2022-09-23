using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class FireworkModuleCallBackMessage : BaseHttpCallBackMessage
    {
    }

    public class FireworkCreateCallBackMessage : BaseHttpCallBackMessage
    {
    }

    public class FireworkListCallBackMessage : BaseHttpCallBackMessage
    {
        public FireworkCallBackData data;

        public FireworkListCallBackMessage()
        {
            messageModuleType = MessageModuleType.Firework;
            m_MessageType = MessageType.FireworkCreateType;
        }
    }

    public class FireworkUpdateCallBackMessage : BaseHttpCallBackMessage
    {
    }

    [System.Serializable]
    public class FireworkCallBackData : FireworkInfo, ICallData
    {

    }
}
