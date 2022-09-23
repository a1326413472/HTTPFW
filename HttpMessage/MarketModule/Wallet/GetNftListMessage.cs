using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class GetNftListMessage : BaseHttpMessage
    {
        public GetNftListBody body;

        public GetNftListMessage()
        {
            messageModuleType = MessageModuleType.Market;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/wallet/getNftList";
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
    }

    [System.Serializable]
    public struct GetNftListBody
    {
        public string account;
    }
}
