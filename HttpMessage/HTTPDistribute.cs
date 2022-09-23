using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;
using System.Threading.Tasks;
using System;

namespace Alpha.Unity.Http
{

    public class HTTPDistribute : Singleton<HTTPDistribute>
    {
        public static async Task Distribute<T1>(BaseHttpCallBackMessage httpMessage, Action<T1> callBack = null) where T1 : ICallData
        {
            switch (httpMessage.MessageType)
            {
                // Login
                case MessageType.None:
                    break;
                case MessageType.EmailLoginType:
                    await LoginHandler.EmailLoginHandler(httpMessage as EmailLoginCallBackMessage);
                    break;
                case MessageType.LoginEmailCodeType:
                    await LoginHandler.LoginEmailCodeHandler(httpMessage as LoginEmailCodeCallBackMessage);
                    break;
                case MessageType.ForgetPwdType:
                    await LoginHandler.ForgetPwdHandler(httpMessage as ForgetPwdCallBackMessage);
                    break;

                // Regist
                case MessageType.EmailRegisterType:
                    await RegisterHandler.EmailRegisterHandler(httpMessage as EmailRegisterCallBackMessage);
                    break;
                case MessageType.RegisterEmailCodeType:
                    await RegisterHandler.RegisterEmailCodeHandler(httpMessage as RegisterEmailCodeCallBackMessage);
                    break;


                // My
                case MessageType.GetUserInfoType:
                    await MyHandler.GetUserInfoHandler(httpMessage as GetUserInfoCallBackMessage, callBack as Action<UserCallBackData>);
                    break;
                case MessageType.SetRoleType:
                    await MyHandler.SetRoleHandler(httpMessage as SetRoleCallBackMessage, callBack as Action<UserCallBackData>);
                    break;

                // Market
                case MessageType.WalletBalanceType:
                    await MarketHandler.BalanceWalletHandler(httpMessage as BalanceWalletCallBackMessage, callBack as Action<BalanceWalletCallBackData>);
                    break;
                case MessageType.CreateWalletType:
                    await MarketHandler.CreateWalletHandler(httpMessage as CreateWalletCallBackMessage, callBack as Action<WalletCallBackData>);
                    break;
                case MessageType.WalletGetBalanceList:
                    await MarketHandler.GetBalanceListHandler(httpMessage as GetBalanceListCallBackMessage, callBack as Action<BalanceWalletCallBackData>);
                    break;
                case MessageType.WalletGetNftList:
                    await MarketHandler.GetNftListHandler(httpMessage as GetNftListCallBackMessage, callBack as Action<GetNFTListCallBackData>);
                    break;
                case MessageType.PrivateKeyRecoverWalletType:
                    await MarketHandler.PrivateKeyRecoverWalletHandler(httpMessage as PrivateKeyRecoverWalletCallBackMessage, callBack as Action<PrivateKeyRecoverWalletCallBackData>);
                    break;
                case MessageType.MnemonicRecoverWalletType:
                    await MarketHandler.MnemonicRecoverWalletHandler(httpMessage as MnemonicRecoverWalletCallBackMessage, callBack as Action<WalletCallBackData>);
                    break;
                case MessageType.TransferOutType:
                    await MarketHandler.TransferWalletHandler(httpMessage as TransferOutCallBackMessage, callBack as Action<TransferOutCallBackData>);
                    break;

                // Platform
                case MessageType.ProductCreateType:
                    await PlatformHandler.ProductCreateHandler(httpMessage as ProductCreateCallBackMessage);
                    break;
                case MessageType.ProductListType:
                    await PlatformHandler.ProductListHandler(httpMessage as ProductListCallBackMessage);
                    break;
                case MessageType.ProductListByCidType:
                    await PlatformHandler.ProductListByCidHandler(httpMessage as ProductListByCidCallBackMessage);
                    break;
                case MessageType.ProductTypeListType:
                    await PlatformHandler.ProductTypeListHandler(httpMessage as ProductTypeListCallBackMessage);
                    break;


                case MessageType.OrderAddType:
                    await PlatformHandler.OrderAddHandler(httpMessage as OrderAddCallBackMessage);
                    break;
                case MessageType.OrderGetOrderType:
                    await PlatformHandler.OrderGetOrderHandler(httpMessage as OrderGetOrderCallBackMessage);
                    break;
                case MessageType.OrderListType:
                    await PlatformHandler.OrderListHandler(httpMessage as OrderListCallBackMessage);
                    break;

                case MessageType.GetVersionType:
                    await VersionHandler.GetVersionHandler(httpMessage as GetVersionCallBackMessage, callBack as Action<VersionCallBackData>);
                    break;
                case MessageType.UpdateVersionType:
                    await VersionHandler.UpdateVersionHandler(httpMessage as UpdateVersionCallBackMessage);
                    break;
            }
        }

        public static async Task DistributeError(BaseHttpCallBackMessage httpMessage, Action<MessageType, int, string> error = null)
        {
            Debug.Log("httpMessage.messageModuleType = " + httpMessage.messageModuleType);
            switch (httpMessage.messageModuleType)
            {
                case MessageModuleType.None:
                    break;
                case MessageModuleType.Register:
                    await RegisterHandler.RegisterErrorHandler(httpMessage.MessageType, httpMessage.code, httpMessage.data);
                    break;
                case MessageModuleType.Login:
                    await LoginHandler.LoginErrorHandler(httpMessage.MessageType, httpMessage.code, httpMessage.data);
                    break;
                case MessageModuleType.Market:
                    await MarketHandler.MarketErrorHandler(httpMessage.MessageType, httpMessage.code, httpMessage.data);
                    break;
                case MessageModuleType.My:
                    break;
                default:
                    break;
            }
        }

    }
}
