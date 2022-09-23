using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class MarketHandler : Singleton<MarketHandler>
    {
        public static async Task CreateWalletHandler(CreateWalletCallBackMessage callBackMessage, Action<WalletCallBackData> callBack = null)
        {
            WalletCallBackData data = callBackMessage.data;
            await MarketProxy.CreateWalletSuccess(data);
            callBack?.Invoke(data);
        }

        public static async Task BalanceWalletHandler(BalanceWalletCallBackMessage callBackMessage, Action<BalanceWalletCallBackData> callBack = null)
        {
            BalanceWalletCallBackData data = callBackMessage.data;
            await MarketProxy.BalanceWalletSuccess(data);
            callBack?.Invoke(data);
        }

        public static async Task GetBalanceListHandler(GetBalanceListCallBackMessage callBackMessage, Action<BalanceWalletCallBackData> callBack = null)
        {
            BalanceWalletCallBackData data = callBackMessage.data;
            callBack?.Invoke(data);
        }

        public static async Task GetNftListHandler(GetNftListCallBackMessage callBackMessage, Action<GetNFTListCallBackData> callBack = null)
        {
            GetNFTListCallBackData data = callBackMessage.data;
            callBack?.Invoke(data);
        }

        public static async Task PrivateKeyRecoverWalletHandler(PrivateKeyRecoverWalletCallBackMessage callBackMessage, Action<PrivateKeyRecoverWalletCallBackData> callBack = null)
        {
            PrivateKeyRecoverWalletCallBackData data = callBackMessage.data;
            await MarketProxy.PrivateKeyRecoverWalletSuccess(data);
            callBack?.Invoke(data);
        }

        public static async Task MnemonicRecoverWalletHandler(MnemonicRecoverWalletCallBackMessage callBackMessage, Action<WalletCallBackData> callBack = null)
        {
            WalletCallBackData data = callBackMessage.data;
            await MarketProxy.RecoverWalletSuccess(data);
            callBack?.Invoke(data);
        }

        public static async Task TransferWalletHandler(TransferOutCallBackMessage callBackMessage, Action<TransferOutCallBackData> callBack = null)
        {
            TransferOutCallBackData data = callBackMessage.data;
            await MarketProxy.TransferOutSuccess(data);
            callBack?.Invoke(data);
        }

        /// <summary>
        /// 错误信息汇总
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="code"></param>
        /// <param name="codeMessage"></param>
        /// <param name="baseHttpCallBackMessage"></param>
        public static async Task MarketErrorHandler(MessageType messageType, int code, string codeMessage, BaseHttpCallBackMessage baseHttpCallBackMessage = null)
        {
            switch (messageType)
            {
                case MessageType.CreateWalletType:
                case MessageType.PrivateKeyRecoverWalletType:
                case MessageType.TransferOutType:
                    MarketProxy.WalletErrorAction?.Invoke(messageType, code, codeMessage);
                    break;
                default:
                    break;
            }
        }
    }
}
