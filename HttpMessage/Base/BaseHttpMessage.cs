using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public enum HttpMethodType
    {
        None = 0,
        Post = 1,
        Get = 2,
        Put = 3
    }

    public enum MessageModuleType
    {
        None = 0,
        Register = 1,
        Login = 2,
        Air = 3,
        Market = 5,
        Platform = 6,
        My = 7,
        Firework = 9,
        Version = 10
    }

    public enum MessageType
    {
        /// <summary>
        /// ************************************************************************* 登录退出（0-99） *************************************************************************
        /// </summary>
        None = 0,
        AdvanceAccountLoginType = 1,            //  账号密码预登录
        AccountLoginType = 2,                   //  账号密码登录
        AdvancePhoneLoginType = 3,              //  手机号预登录
        PhoneLoginType = 4,                     //  手机登录
        AdvanceEmailLoginType = 5,              //  邮箱预登录
        EmailLoginType = 6,                     //  邮箱登录
        LogoutType = 7,                         //  退出
        LogOnQueryType = 8,                     //  登录查询
        ForgetPwdType = 9,                      //  忘记密码

        CaptchaCodeType = 20,                   //  获取图形验证码
        
        LoginSmsCodeType = 30,                  //  获取手机验证码(登录)
        LoginEmailCodeType = 31,                //  获取邮箱验证码(登录)

        /// <summary>
        /// ************************************************************************* 注册（100-199） *************************************************************************
        /// </summary>
        EmailRegisterType = 106,                       //  邮箱注册
        RegisterEmailCodeType = 131,                //  获取邮箱验证码(注册)

        /// <summary>
        /// ************************************************************************* 忘记密码（200-299） *************************************************************************
        /// </summary>
        ForgetPassSmsCodeType = 201,             //  获取手机验证码(忘记密码)
        VerifyForgetPassCodeType = 202,          //  验证手机验证码(忘记密码)
        ResetForgetPassSMSType = 203,            //  重设忘记密码(手机)
       
        ForgetPassEmailCodeType = 211,           //  获取邮箱验证码(忘记密码)
        VerifyForgetPassEmailCodeType = 212,     //  验证邮箱验证码(忘记密码)
        ResetForgetPassEmailType = 213,         //  重设忘记密码(邮箱)

        /// <summary>
        /// ************************************************************************* 用户信息（500-699） *************************************************************************
        /// </summary>
        GetUserInfoType = 500,
        SetRoleType = 501,

        /// <summary>
        /// ************************************************************************* 机票（700-799） *************************************************************************
        /// </summary>
        AirAddType = 700,
        AirGetOneType = 701,
        AirGetOneByToType = 702,
        AirListType = 703,
        AirUpdateType = 704,
        AirUpdateStatusType = 705,

        /// <summary>
        /// ************************************************************************* 烟花（800-899） *************************************************************************
        /// </summary>
        FireworkCreateType = 800,
        FireworkListType = 801,
        FireworkUpdateType = 802,

        /// <summary>
        /// ************************************************************************* 版本（900-999） *************************************************************************
        /// </summary>
        GetVersionType = 900,
        UpdateVersionType = 901,

        /// <summary>
        /// ************************************************************************* 市场（5000-9999） *************************************************************************
        /// </summary>
        CreateWalletType = 5000,
        PrivateKeyRecoverWalletType = 5001,
        MnemonicRecoverWalletType = 5002,
        WalletBalanceType = 5003,
        WalletGetNftList = 5004,
        WalletGetBalanceList = 5005,

        TransferOutType = 5500,
        TransferInType = 5501,

        /// <summary>
        /// ************************************************************************* 平台（10000-19999） *************************************************************************
        /// </summary>
        ProductCreateType = 12000,
        ProductListType = 12001,
        ProductListByCidType = 12002,
        ProductTypeListType = 12003,

        OrderAddType = 15001,
        OrderGetOrderType = 15002,
        OrderListType = 15003,







    }

    public class BaseHttpMessage
    {
        public MessageModuleType messageModuleType = MessageModuleType.None;
        public HttpMethodType methodType = HttpMethodType.None;
        public MessageType messageType = MessageType.None;

        protected string m_Path;
        public virtual string path
        {
            get
            {
                return m_Path;
            }
        }
        public Dictionary<string, string> headers = new Dictionary<string, string>();
        public virtual string ToBodyString()
        {
            return string.Empty;
        }
    }

    public class MarketHttpMessage : BaseHttpMessage
    {
        public MarketHttpMessage()
        { 
            
        }
    }

    public class MyHttpMessage : BaseHttpMessage
    {
        public MyHttpMessage()
        {
            messageModuleType = MessageModuleType.My;
            headers.Add("x-token", ServerConfigMgr.Token);
        }
    }

}


