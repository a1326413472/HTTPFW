using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class GetBalanceListMessage : BaseHttpMessage
    {
        public GetBalanceListBody body;
        public GetBalanceListMessage()
        {
            messageModuleType = MessageModuleType.Market;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/wallet/getBalanceList";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?account=" + body.account;
            }
        }

        [System.Serializable]
        public struct GetBalanceListBody
        {
            public string account;
        }
    }
}
