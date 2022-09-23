using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class TransferWalletMessage : BaseHttpMessage
    {
        public TransferWalletBody body;

        public TransferWalletMessage()
        {
            messageModuleType = MessageModuleType.Market;
            methodType = HttpMethodType.Post;
            messageType = MessageType.TransferOutType;
            m_Path = "/v1/wallet/transfer";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string ToBodyString()
        {
            return JsonUtility.ToJson(body);
        }

    }
    public struct TransferWalletBody
    {
        //public TransferBO transferBO;
        public string from;
        public string private_key;
        public int speed;
        public string symbol;
        public string to;
        public float value;
    }

    [System.Serializable]
    public struct TransferBO
    {
        public string from;
        public string private_key;
        public int speed;
        public string symbol;
        public string to;
        public float value;
    }

}

