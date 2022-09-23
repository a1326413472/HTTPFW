using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Alpha.Unity.Http;
public class HttpTest : MonoBehaviour
{
    public static HttpTest Main;

    public string m_Token;
    public string m_PrivateKey;

    //[Header("Email")]
    public string m_Email;

    //[Header("Register Email Code")]
    public string m_RegisterEmailCode;
    public string m_RegisterEmailUCode;

    //[Header("Login Email Code")]
    public string m_LoginEmailCode;

    public string m_Pwd;
    public string m_ucode;
    //[Header("Login Email Code")]
    //public string privateKey;

    //[Header("TransferWallet")]
    public string m_ToAddress;
    public float m_Value;

    public Air m_AirInfo;

    public string m_Id;

    public string m_Account;
    public string m_Symbol;


    public PlatformProductInfo m_PlatformProductInfo;
    public string m_CityId;
    public string m_Type;


    public PlatformOrderInfo m_PlatformOrderInfo;
    public string m_OrderId;
    public int m_PageNum;
    public string m_PageSize;

    public FireworkInfo m_FireworkInfo;
    public string m_FireworkUid;
    public string m_FireworkId;

    public VersionInfo m_VersionInfo;


    private void Awake()
    {
        Main = this;
    }

    // ------------------------------------------------------------ Login Module ------------------------------------------------------------
    public async void RequestEmailCode()
    {
        await RegisterProxy.RequestEmailCode(m_Email);
    }

    public async void RequestEmailRegister()
    {
        //await RegisterProxy.RequestEmailRegister(m_RegisterEmailCode, m_Email, m_RegisterEmailUCode);
    }

    public async void RequestLoginEmailCode()
    {
        await LoginProxy.RequestEmailCode(m_Email);
    }

    public async void RequestEmailLogin()
    {
        await LoginProxy.RequestEmailLogin(m_LoginEmailCode, m_Email);
    }

    public async void RequestForgetPwd()
    {
        await LoginProxy.RequestForgetPwd(m_LoginEmailCode, m_Email, m_Pwd, m_ucode);
    }

    // ------------------------------------------------------------ Wallet Module ------------------------------------------------------------
    public async void RequestBalanceWallet()
    {
        await MarketProxy.RequestBalanceWallet(m_Account, m_Symbol);
    }

    public async void RequestCreateWallet()
    {
        await MarketProxy.RequestCreateWallet();
    }

    public async void RequestGetNFTList()
    {
        await MarketProxy.RequestGetNftList();
    }

    public async void RequestPrivateKeyRecoverWallet()
    {
        await MarketProxy.RequestPrivateKeyRecoverWallet(ServerConfigMgr.Private_Key);
    }

    public async void RequestMnemonicRecoverWallet()
    {
        await MarketProxy.RequestMnemonicRecoverWallet(ServerConfigMgr.Mnemonic);
    }

    public async void RequestTransferWallet()
    {
        await MarketProxy.RequestTransferWallet(m_ToAddress, m_Value);
    }

    // ------------------------------------------------------------ My Module ------------------------------------------------------------
    public async void RequestGetUserInfo()
    {
        await MyProxy.RequestGetUserInfo();
    }

    public string m_Color;
    public string m_NickName;
    public string m_Sex;
    public async void RequestSetRole()
    {
        await MyProxy.RequestSetRole(m_Color, m_NickName, m_Sex);
    }

    // ------------------------------------------------------------ Air Module ------------------------------------------------------------
    public async void RequestAirAdd()
    {
        await AirProxy.RequestAirAdd(m_AirInfo);
    }

    public async void RequestAirGetOne()
    {
        await AirProxy.RequestAirGetOne(m_Id);
    }

    // ------------------------------------------------------------ Platform Module ------------------------------------------------------------
    public async void ProductCreate()
    {
        await PlatformProxy.RequestProductCreate(m_PlatformProductInfo);
    }
    public async void ProductList()
    {
        await PlatformProxy.RequestProductList();
    }
    public async void ProductListByCid()
    {
        await PlatformProxy.RequestProductListByCid(m_CityId);
    }
    public async void ProductTypeList()
    {
        await PlatformProxy.RequestProductTypeList(m_Type);
    }

    public async void OrderAdd()
    {
        await PlatformProxy.RequestOrderAdd(m_PlatformOrderInfo);
    }
    public async void OrderGetOrder()
    {
        await PlatformProxy.RequestOrderGetOrder(m_OrderId);
    }
    public async void OrderList()
    {
        await PlatformProxy.RequestOrderList(m_PageNum, m_PageSize);
    }

    // ------------------------------------------------------------ Firework Module ------------------------------------------------------------
    public async void RequestFireworkCreate()
    {
        await FireworkProxy.RequestFireworkCreate(m_FireworkInfo);
    }
    public async void RequestFireworkList()
    {
        await FireworkProxy.RequestFireworkList(m_FireworkUid);
    }
    public async void RequestFireworkUpdate()
    {
        await FireworkProxy.RequestFireworkUpdate(m_FireworkId);
    }

    // ------------------------------------------------------------ Version Module ------------------------------------------------------------ 
    public async void RequestGetVersion()
    {
        await VersionProxy.RequestGetVersion();
    }

    public async void RequestUpdateVersion()
    {
        await VersionProxy.RequestUpdateVersion(m_VersionInfo);
    }

}
