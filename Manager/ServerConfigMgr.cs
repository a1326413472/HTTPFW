using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;
using Alpha.Unity.Http;
using LitJson;

public static class ServerConfigMgr
{
    public static string Company = "";

    public static string Token = "";
    public static string Address = "";
    public static string Mnemonic = "";
    public static string Private_Key = "";
    public static string Password = "";
    public static string WalletName = "";
    public static int Speed = 2;
    public static string Version = "2.0";
    /// <summary>
    /// BNB/BEP20
    /// </summary>
    public static string Symbol = "BNB";
    //public static string LoginUrl = "https://www.yourmetaspace.cc/transfer";
    //public static string LoginUrl = "http://182.87.223.130";
    public static string LoginUrl = "http://47.100.201.161:81";

    static ServerConfigMgr()
    {
        Init();



    }

    static void Init()
    {
        LoginCallBackData loginData = new LoginCallBackData();
        LitJsonMgr.Instance.ReadEncryJson("LoginData", ref loginData);
        Token = loginData.token;
        DynamicUserModel.Instance.userInfo = loginData.userInfo;
        Debug.Log("loginData : " + JsonMapper.ToJson(loginData));

        WalletCallBackData walletData = new WalletCallBackData();
        LitJsonMgr.Instance.ReadEncryJson("WalletData", ref walletData);
        Address = walletData.address;
        Mnemonic = walletData.mnemonic;
        Private_Key = walletData.private_key;
        DynamicUserModel.Instance.walletInfo = new WalletInfo();
        DynamicUserModel.Instance.walletInfo.address = walletData.address;
        DynamicUserModel.Instance.walletInfo.mnemonic = walletData.mnemonic;
        DynamicUserModel.Instance.walletInfo.private_key = walletData.private_key;
        Debug.Log("loginData : " + JsonMapper.ToJson(walletData));

        WalletLocalInfo walletLocalInfo = new WalletLocalInfo();
        LitJsonMgr.Instance.ReadEncryJson("WalletLocalInfo", ref walletLocalInfo);
        ServerConfigMgr.WalletName = walletLocalInfo.walletName;
        ServerConfigMgr.Password = walletLocalInfo.password;
        Debug.Log("walletLocalInfo : " + JsonMapper.ToJson(walletLocalInfo));

        LitJsonMgr.Instance.ReadEncryJson("TransferRecordsList", ref DynamicWalletModel.Instance.transferRecordsList);
        Debug.Log("TransferRecordsList : " + JsonMapper.ToJson(DynamicWalletModel.Instance.transferRecordsList));
    }

}


