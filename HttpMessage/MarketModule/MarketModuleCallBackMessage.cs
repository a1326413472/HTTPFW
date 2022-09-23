using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class MarketModuleCallBackMessage
    {
    }

    public class BalanceWalletCallBackMessage : BaseHttpCallBackMessage
    {
        public BalanceWalletCallBackData data;

        public BalanceWalletCallBackMessage()
        {
            messageModuleType = MessageModuleType.Market;
            m_MessageType = MessageType.WalletBalanceType;
        }
    }

    public class CreateWalletCallBackMessage : BaseHttpCallBackMessage
    {
        public WalletCallBackData data;

        public CreateWalletCallBackMessage()
        {
            messageModuleType = MessageModuleType.Market;
            m_MessageType = MessageType.CreateWalletType;
        }
    }

    public class GetBalanceListCallBackMessage : BaseHttpCallBackMessage
    {
        public BalanceWalletCallBackData data;
        public GetBalanceListCallBackMessage()
        {
            messageModuleType = MessageModuleType.Market;
            m_MessageType = MessageType.WalletGetBalanceList;
        }
    }

    public class GetNftListCallBackMessage : BaseHttpCallBackMessage
    {
        public GetNFTListCallBackData data;
        public GetNftListCallBackMessage()
        {
            messageModuleType = MessageModuleType.Market;
            m_MessageType = MessageType.WalletGetNftList;
        }
    }

    public class PrivateKeyRecoverWalletCallBackMessage : BaseHttpCallBackMessage
    {
        public PrivateKeyRecoverWalletCallBackData data;
        public PrivateKeyRecoverWalletCallBackMessage()
        {
            messageModuleType = MessageModuleType.Market;
            m_MessageType = MessageType.PrivateKeyRecoverWalletType;
        }
    }

    public class MnemonicRecoverWalletCallBackMessage : BaseHttpCallBackMessage
    {
        public WalletCallBackData data;

        public MnemonicRecoverWalletCallBackMessage()
        {
            messageModuleType = MessageModuleType.Market;
            m_MessageType = MessageType.MnemonicRecoverWalletType;
        }
    }
    
    [System.Serializable]
    public class WalletCallBackData : ICallData
    {
        public WalletCallBackData()
        {
            address = "";
            mnemonic = "";
            private_key = "";
        }

        public string address;
        public string mnemonic;
        public string private_key;
    }


    [System.Serializable]
    public class TransferOutCallBackData : ICallData
    {
        public TransferOutCallBackData()
        {
            id = "";
            index = 0;
            message = "";
        }

        public string id;
        public int index;
        public string message;
    }

    [System.Serializable]
    public class BalanceWalletCallBackData : ICallData
    {
        public BalanceWalletCallBackData()
        {
            balance = "";
            symbol = "";
        }

        public string balance;
        public string symbol;
    }

    [System.Serializable]
    public class GetNFTListCallBackData : ICallData
    {
    }

    [System.Serializable]
    public class PrivateKeyRecoverWalletCallBackData : ICallData
    {
        public PrivateKeyRecoverWalletCallBackData()
        {
            id = "";
        }

        public string id;
    }

    public class TransferOutCallBackMessage : BaseHttpCallBackMessage
    {
        public TransferOutCallBackData data;

        public TransferOutCallBackMessage()
        {
            messageModuleType = MessageModuleType.Market;
            m_MessageType = MessageType.TransferOutType;
        }
    }
}


