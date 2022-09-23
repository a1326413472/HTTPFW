using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;
using System;
using UnityEngine.Networking;
using System.Threading.Tasks;
using LitJson;

namespace Alpha.Unity.Http
{

    public class NetworkHeaders
    {        
        #region My
        public static async Task GetUserInfo(Action<UserCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            GetUserInfoMessage message = new GetUserInfoMessage();
            await DoHttp<GetUserInfoCallBackMessage, UserCallBackData>(message, callBackAction, errorAction);
        }

        public static async Task SetRole(string color, string nickName, string sex, Action<UserCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            SetRoleMessage message = new SetRoleMessage();
            message.body.color = color;
            message.body.nickName = nickName;
            message.body.sex = sex;
            await DoHttp<SetRoleCallBackMessage, UserCallBackData>(message, callBackAction, errorAction);
        }
        #endregion

        #region Login
        ///// <summary>
        ///// 用户账号登录
        ///// </summary>
        ///// <param name="account"></param>
        ///// <param name="password"></param>
        //public static async Task AccountLogin(string account, string password)
        //{
        //    AccountLoginMessage message = new AccountLoginMessage();
        //    message.body.account = account;
        //    message.body.password = password;
        //    message.body.deviceId = "Null";
        //    message.body.deviceType = "Window AR";
        //    message.body.deviceOS = "Null";
        //    message.body.source = Application.platform.ToString();
        //    message.body.captchaId = "";
        //    message.body.captchaValue = "";
        //    await DoHttp<AccountLoginCallBackMessage>(message);
        //}

        /// <summary>
        /// 获取邮箱登录验证码
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static async Task LoginEmailCode(string email)
        {
            LoginEmailCodeMessage message = new LoginEmailCodeMessage();
            message.body.email = email;
            await DoHttp<LoginEmailCodeCallBackMessage>(message);
        }

        public static async Task EmailLogin(string pwd, string email)
        {
            EmailLoginMessage message = new EmailLoginMessage();
            message.body.password = pwd;
            message.body.username = email;
            await DoHttp<EmailLoginCallBackMessage>(message);
        }

        public static async Task ForgetPwd(string code, string email, string pwd, string ucode)
        {
            ForgetPwdMessage message = new ForgetPwdMessage();
            message.body.code = code;
            message.body.email = email;
            message.body.pwd = pwd;
            message.body.ucode = ucode;
            await DoHttp<ForgetPwdCallBackMessage>(message);
        }
        #endregion

        #region Register

        /// <summary>
        /// 获取邮箱注册验证码
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static async Task RegisterEmailCode(string email)
        {
            RegisterEmailCodeMessage message = new RegisterEmailCodeMessage();
            message.body.email = email;
            await DoHttp<RegisterEmailCodeCallBackMessage>(message);
        }

        /// <summary>
        /// 邮箱注册
        /// </summary>
        /// <param name="code"></param>
        /// <param name="email"></param>
        /// <param name="ucode"></param>
        /// <returns></returns>
        public static async Task EmailRegister(string code, string email, string ucode , string pwd)
        {
            EmailRegisterMessage message = new EmailRegisterMessage();
            message.body.code = code;
            message.body.email = email;
            message.body.ucode = ucode;
            message.body.pwd = pwd;

            Debug.Log(message.messageModuleType);
            
            await DoHttp<EmailRegisterCallBackMessage>(message);
        }
        #endregion

        #region Market
        public static async Task BalanceWallet(string account, string symbol, Action<BalanceWalletCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            BalanceWalletMessage message = new BalanceWalletMessage();
            //message.body.account = account;
            //message.body.symbol = symbol;
            message.body.account = ServerConfigMgr.Address;
            message.body.symbol = ServerConfigMgr.Symbol; ;
            await DoHttp<BalanceWalletCallBackMessage, BalanceWalletCallBackData>(message, callBackAction, errorAction);
        }

        public static async Task CreateWallet(Action<WalletCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            CreateWalletMessage message = new CreateWalletMessage();
            await DoHttp<CreateWalletCallBackMessage, WalletCallBackData>(message, callBackAction, errorAction);
        }

        public static async Task GetBalanceList(Action<BalanceWalletCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            GetBalanceListMessage message = new GetBalanceListMessage();
            message.body.account = ServerConfigMgr.Address;
            await DoHttp<GetBalanceListCallBackMessage, BalanceWalletCallBackData>(message, callBackAction, errorAction);
        }

        public static async Task GetNFTList(Action<GetNFTListCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            GetNftListMessage message = new GetNftListMessage();
            message.body.account = ServerConfigMgr.Address;
            await DoHttp<GetNftListCallBackMessage, GetNFTListCallBackData>(message, callBackAction, errorAction);
        }

        public static async Task PrivateKeyRecoverWallet(string privateKey, Action<PrivateKeyRecoverWalletCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            PrivateKeyRecoverWalletMessage message = new PrivateKeyRecoverWalletMessage();
            message.body.privateKey = privateKey;
            await DoHttp<PrivateKeyRecoverWalletCallBackMessage, PrivateKeyRecoverWalletCallBackData>(message, callBackAction, errorAction);
        }

        public static async Task MnemonicRecoverWallet(string mnemonic, Action<WalletCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            MnemonicRecoverWalletMessage message = new MnemonicRecoverWalletMessage();
            message.body.mnemonic = mnemonic;
            await DoHttp<MnemonicRecoverWalletCallBackMessage, WalletCallBackData>(message, callBackAction, errorAction);
        }

        public static async Task TransferOut(string toAddress, float value, int speed = 2, string symbol = "BNB", Action<TransferOutCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            TransferWalletMessage message = new TransferWalletMessage();
            //message.body.transferBO.from = ServerConfigMgr.Address;
            //message.body.transferBO.private_key = ServerConfigMgr.Private_Key;
            //message.body.transferBO.speed = speed;
            //message.body.transferBO.symbol = symbol;
            //message.body.transferBO.to = toAddress;
            //message.body.transferBO.value = value;
            message.body.from = ServerConfigMgr.Address;
            message.body.private_key = ServerConfigMgr.Private_Key;
            message.body.speed = speed;
            message.body.symbol = symbol;
            message.body.to = toAddress;
            message.body.value = value;
            await DoHttp<TransferOutCallBackMessage, TransferOutCallBackData>(message, callBackAction, errorAction);
        }
        #endregion

        #region Air
        public static async Task AirAdd(Air data)
        {
            AirAddMessage message = new AirAddMessage();
            message.body.air = data;
            await DoHttp<AirAddCallBackMessage>(message);
        }

        public static async Task AirGetOne(string id)
        {
            AirGetOneMessage message = new AirGetOneMessage();
            message.body.id = id;
            await DoHttp<AirGetOneCallBackMessage>(message);
        }

        public static async Task AirGetOneByTo(string to)
        {
            AirGetOneByToMessage message = new AirGetOneByToMessage();
            message.body.to = to;
            await DoHttp<AirGetOneByToCallBackMessage>(message);
        }

        public static async Task AirList()
        {
            AirListMessage message = new AirListMessage();
            await DoHttp<AirListCallBackMessage>(message);
        }

        public static async Task AirUpdate(Air data)
        {
            AirUpdateMessage message = new AirUpdateMessage();
            message.body.air = data;
            await DoHttp<AirUpdateCallBackMessage>(message);
        }

        public static async Task AirUpdateStatus(string id, string status)
        {
            AirUpdateStatusMessage message = new AirUpdateStatusMessage();
            message.body.id = id;
            message.body.status = status;
            await DoHttp<AirUpdateStatusCallBackMessage>(message);
        }
        #endregion

        #region Platform
        public static async Task ProductCreate(PlatformProductInfo data)
        {
            ProductCreateMessage message = new ProductCreateMessage();
            message.body = data;
            await DoHttp<ProductCreateCallBackMessage>(message);
        }
        public static async Task ProductList()
        {
            ProductListMessage message = new ProductListMessage();
            await DoHttp<ProductListCallBackMessage>(message);
        }
        public static async Task ProductListByCid(string cityId)
        {
            ProductListByCidMessage message = new ProductListByCidMessage();
            message.body.cityId = cityId;
            await DoHttp<ProductListByCidCallBackMessage>(message);
        }
        public static async Task ProductTypeList(string type)
        {
            ProductTypeListMessage message = new ProductTypeListMessage();
            message.body.type = type;
            await DoHttp<ProductTypeListCallBackMessage>(message);
        }

        public static async Task OrderAdd(PlatformOrderInfo data)
        {
            OrderAddMessage message = new OrderAddMessage();
            message.body = data;
            await DoHttp<OrderAddCallBackMessage>(message);
        }
        public static async Task OrderGetOrder(string orderId)
        {
            OrderGetOrderMessage message = new OrderGetOrderMessage();
            message.body.orderId = orderId;
            await DoHttp<OrderGetOrderCallBackMessage>(message);
        }
        public static async Task OrderList(int pageNum, string pageSize)
        {
            OrderListMessage message = new OrderListMessage();
            message.body.pageNum = pageNum;
            message.body.pageSize = pageSize;
            await DoHttp<OrderListCallBackMessage>(message);
        }

        #endregion

        #region Firework
        public static async Task FireworkCreate(FireworkInfo data)
        {
            FireworkCreateMessage message = new FireworkCreateMessage();
            message.body = data;
            await DoHttp<FireworkCreateCallBackMessage>(message);
        }

        public static async Task FireworkList(string uid)
        {
            FireworkListMessage message = new FireworkListMessage();
            message.body.uid = uid;
            await DoHttp<FireworkListCallBackMessage>(message);
        }

        public static async Task FireworkUpdate(string id)
        {
            FireworkUpdateMessage message = new FireworkUpdateMessage();
            message.body.id = id;
            await DoHttp<FireworkUpdateCallBackMessage>(message);
        }
        #endregion

        #region Version
        public static async Task GetVersion(Action<VersionCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            GetVersionMessage message = new GetVersionMessage();
            await DoHttp<GetVersionCallBackMessage, VersionCallBackData>(message, callBackAction, errorAction);
        }

        public static async Task UpdateVersion(VersionInfo versionInfo)
        {
            UpdateVersionMessage message = new UpdateVersionMessage();
            message.body = versionInfo;
            await DoHttp<UpdateVersionCallBackMessage>(message);
        }
        #endregion

        private static async Task DoHttp<T>(BaseHttpMessage httpMessage, Action<ICallData> callBack = null) where T : BaseHttpCallBackMessage
        {
            await DoPost(httpMessage, async delegate (bool isConnected, string content)
            {
                if (isConnected)
                {
                    if (!string.IsNullOrEmpty(content))
                    {
                        Debug.Log("content:" + content);
                        BaseHttpCallBackMessage httpHead = JsonUtility.FromJson<T>(content);
                        Debug.Log("httpHead TYPE:" + httpHead.MessageType);

                        if (httpHead.code == 1)
                        {
                            T callBackMessage = JsonUtility.FromJson<T>(content);
                            Debug.Log("callBackMessage : " + JsonUtility.ToJson(callBackMessage));
                            //callBack.Invoke(callBackMessage.callData);
                            await HTTPDistribute.Distribute(callBackMessage, callBack);
                        } else
                        {
                            T callBackMessage = JsonUtility.FromJson<T>(content);
                            Debug.Log("callErrorMessage : " + JsonUtility.ToJson(callBackMessage));
                            await HTTPDistribute.DistributeError(callBackMessage);
                        }
                    }
                }
            });
        }

        private static async Task DoHttp<T1, T2>(BaseHttpMessage httpMessage, Action<T2> callBack = null, Action<MessageType, int, string> error = null) where T1 : BaseHttpCallBackMessage where T2 : ICallData
        {
            await DoPost(httpMessage, async delegate (bool isConnected, string content)
            {
                if (isConnected)
                {
                    if (!string.IsNullOrEmpty(content))
                    {
                        Debug.Log("content:" + content);
                        BaseHttpCallBackMessage httpHead = JsonUtility.FromJson<T1>(content);
                        Debug.Log("httpHead TYPE:" + httpHead.MessageType);

                        //TODO 返回code码不同
                        if (httpHead.code == 200)
                        {
                            T1 callBackMessage = JsonUtility.FromJson<T1>(content);
                            Debug.Log("callBackMessage : " + JsonUtility.ToJson(callBackMessage));
                            //callBack.Invoke(callBackMessage.callData);
                            await HTTPDistribute.Distribute(callBackMessage, callBack);
                        }
                        else
                        {
                            T1 callBackMessage = JsonUtility.FromJson<T1>(content);
                            Debug.Log("callErrorMessage : " + JsonUtility.ToJson(callBackMessage));
                            await HTTPDistribute.DistributeError(callBackMessage, error);
                        }
                    }
                }
            });
        }

        /// <summary>
        /// DoPost 
        /// </summary>
        /// <param name="httpMessage"></param>
        /// <param name="callback"></param>
        private static async Task DoPost(BaseHttpMessage httpMessage, Action<bool, string> callback)
        {
            string webMethod = "POST";
            switch (httpMessage.methodType)
            {
                case HttpMethodType.None:
                    break;
                case HttpMethodType.Post:
                    webMethod = UnityWebRequest.kHttpVerbPOST;
                    break;
                case HttpMethodType.Get:
                    webMethod = UnityWebRequest.kHttpVerbGET;
                    break;
                case HttpMethodType.Put:
                    webMethod = UnityWebRequest.kHttpVerbPUT;
                    break;
                default:
                    break;
            }
            await HttpRequest(httpMessage, httpMessage.path, webMethod, httpMessage.headers, httpMessage.ToBodyString(), callback);
        }

        private static async Task HttpRequest(BaseHttpMessage httpMessage, string methodName, string webMethod, Dictionary<string, string> requestHeader, string parameters, Action<bool, string> callback)
        {
            string url = "";
            switch (httpMessage.messageModuleType)
            {
                case MessageModuleType.None:
                    break;
                case MessageModuleType.Register:
                    url = ServerConfigMgr.LoginUrl + methodName;
                    break;
                case MessageModuleType.Login:
                    url = ServerConfigMgr.LoginUrl + methodName;
                    break;
                case MessageModuleType.My:
                    url = ServerConfigMgr.LoginUrl + methodName;
                    break;
                default:
                    url = ServerConfigMgr.LoginUrl + methodName;
                    break;
            }
            //switch (httpMessage.messageType)
            //{
            //    case MessageType.TransferWalletType:
            //        url = "https://www.yourmetaspace.cc/transfer";
            //        break;
            //}

            Action<string> successCallback = delegate (string json) { callback(true, json); };
            Action<string> failCallback = delegate (string json) { callback(false, json); };

            await HttpRequestMgr.Request(url, webMethod, requestHeader, parameters, successCallback, failCallback);
        }
    }
}
