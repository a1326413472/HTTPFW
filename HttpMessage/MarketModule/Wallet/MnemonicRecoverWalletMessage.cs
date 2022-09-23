using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class MnemonicRecoverWalletMessage : BaseHttpMessage
    {
        public MnemonicRecoverWalletBody body;

        public MnemonicRecoverWalletMessage()
        {
            messageModuleType = MessageModuleType.Market;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/wallet/mnemonicRecover";
            headers.Add("Content-Type", "application/json");
            headers.Add("x-token", ServerConfigMgr.Token);
        }

        public override string path
        {
            get
            {
                return m_Path + "?mnemonic=" + body.mnemonic;
            }
        }

        public struct MnemonicRecoverWalletBody
        {
            public string mnemonic;
        }
    }
}
