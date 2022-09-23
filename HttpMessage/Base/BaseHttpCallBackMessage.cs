using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{

    public interface ICallData
    {

    }
    [System.Serializable]
    public class BaseHttpCallBackMessage
    {
        public int code;
        public string message;
        public string data;
        public ICallData callData;
        protected MessageType m_MessageType;
        public MessageType MessageType
        {
            get => m_MessageType;
        }
        public MessageModuleType messageModuleType = MessageModuleType.None;
    }

}


