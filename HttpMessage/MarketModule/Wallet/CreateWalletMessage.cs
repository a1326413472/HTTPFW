using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class CreateWalletMessage : BaseHttpMessage
    {
        public CreateWalletBody body;

        public CreateWalletMessage()
        {
            messageModuleType = MessageModuleType.Market;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/wallet/create";
            headers.Add("Content-Type", "application/json");
            headers.Add("x-token", ServerConfigMgr.Token);
        }
    }

    public struct CreateWalletBody
    { 
        
    }
}

