using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class BalanceWalletMessage : BaseHttpMessage
    {
        public BalanceWalletBody body;

        public BalanceWalletMessage()
        {
            messageModuleType = MessageModuleType.Market;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/wallet/balance";
            headers.Add("Content-Type", "application/json");
            headers.Add("X-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?account=" + body.account + "&symbol=" + body.symbol;
            }
        }
    }

    public struct BalanceWalletBody
    {
        public string account;
        public string symbol;
    }
}
