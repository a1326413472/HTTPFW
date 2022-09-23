using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;

public enum BNBSymbol
{
    BNB = 0,
    USDT = 1,
    FRD = 2,
    TTS1 = 3,
    METAS = 4
}

public struct BNBBalance
{
    public string balance;
    public string symbol;
}

public enum BSCFormsEnum
{ 
    Asset = 0,
    NFT = 1
}

[System.Serializable]
public class TransferRecord
{
    public string address = "";
    public string dataTime = "";
    public string balance = "";
}

public class DynamicWalletModel : Singleton<DynamicWalletModel>
{
    //public string balance = "$0";
    //public string symbol = "BNB";


    public BSCFormsEnum presentBSCFormsEnum = BSCFormsEnum.Asset;

    public BNBSymbol presentSymbol;
    public BNBSymbol presentSelectedSymbol;

    public string Symbol
    {
        get
        {
            switch (presentSymbol)
            {
                case BNBSymbol.BNB:
                    return "BNB";
                case BNBSymbol.USDT:
                    return "USDT";
                case BNBSymbol.FRD:
                    return "FRD";
                case BNBSymbol.TTS1:
                    return "TTS1";
                case BNBSymbol.METAS:
                    return "METAS";
            }
            return "BNB";
        }
    }

    public Dictionary<BNBSymbol, double> BNBsDic = new Dictionary<BNBSymbol, double>();

    // public Dictionary<string, List<TransferRecord>> transferOutsDic = new Dictionary<string, List<TransferRecord>>();

    //public Dictionary<string, TransferRecord> transferOutsDic = new Dictionary<string, TransferRecord>();

    public List<TransferRecord> transferRecordsList = new List<TransferRecord>();

    public TransferRecord presentTransferOut = new TransferRecord();

    //public Dictionary<string, Dictionary<BNBSymbol, string>> WalletsDic = new Dictionary<string, Dictionary<BNBSymbol, string>>();

    //public float GetBalance(string walletName ,BNBSymbol symbol)
    //{
    //    switch (symbol)
    //    {
    //        case BNBSymbol.BNB:
    //            return float.Parse(GetBalance("BNB"));
    //        case BNBSymbol.USDT:
    //            return float.Parse(GetBalance("USDT"));
    //        case BNBSymbol.FRD:
    //            return float.Parse(GetBalance("FRD"));
    //        case BNBSymbol.TTS1:
    //            return float.Parse(GetBalance("TTS1"));
    //        case BNBSymbol.METAS:
    //            return float.Parse(GetBalance("METAS"));
    //    }
    //    return 0;
    //}

    //public string GetBalance(string symbol)
    //{
    //    if (BNBsDic.ContainsKey(symbol))
    //    {
    //        return BNBsDic[symbol];
    //    }
    //    return "0";
    //}

    public double GetBalance(BNBSymbol symbol)
    {
        if (BNBsDic.ContainsKey(symbol))
        {
            return BNBsDic[symbol];
        }
        return 0;
    }


    public void SetBalance(BNBSymbol symbol, double balance)
    {
        if (BNBsDic.ContainsKey(symbol))
        {
            BNBsDic[symbol] = balance;
        }
        else
        {
            BNBsDic.Add(symbol, balance);
        }
    }
}
