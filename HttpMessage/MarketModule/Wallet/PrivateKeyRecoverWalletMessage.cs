using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class PrivateKeyRecoverWalletMessage : BaseHttpMessage
    {
        public PrivateKeyRecoverWalletBody body;

        public PrivateKeyRecoverWalletMessage()
        {
            messageModuleType = MessageModuleType.Market;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/wallet/privateKeyRecover";
            headers.Add("Content-Type", "application/json");
            headers.Add("x-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?privateKey=" + body.privateKey;
            }
        }
    }

    public struct PrivateKeyRecoverWalletBody
    {
        public string privateKey;
    }

}

