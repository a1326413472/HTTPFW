using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;
using LitJson;

namespace Alpha.Unity.Http
{
    public class MarketProxy : Singleton<MarketProxy>
    {
        /// <summary>
        /// 错误码
        /// </summary>       
        public static Action<MessageType, int, string> WalletErrorAction;

        /// <summary>
        /// 查询钱包额度
        /// </summary>
        /// <returns></returns>
        public static async Task RequestBalanceWallet(string account, string symbol, Action<BalanceWalletCallBackData> callBack = null)
        {
            await NetworkHeaders.BalanceWallet(account, symbol, callBack);
        }
        
        /// <summary>
        /// 创建钱包
        /// </summary>
        /// <returns></returns>
        public static async Task RequestCreateWallet(Action<WalletCallBackData> callBack = null)
        {
            await NetworkHeaders.CreateWallet(callBack);
        }

        /// <summary>
        /// 创建钱包
        /// </summary>
        /// <returns></returns>
        public static async Task RequestGetBalanceList(Action<BalanceWalletCallBackData> callBack = null)
        {
            await NetworkHeaders.GetBalanceList(callBack);
        }

        /// <summary>
        /// 创建钱包
        /// </summary>
        /// <returns></returns>
        public static async Task RequestGetNftList(Action<GetNFTListCallBackData> callBack = null)
        {
            await NetworkHeaders.GetNFTList(callBack);
        }

        /// <summary>
        /// 通过私钥恢复钱包
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static async Task RequestPrivateKeyRecoverWallet(string privateKey, Action<PrivateKeyRecoverWalletCallBackData> callBack = null)
        {
            ServerConfigMgr.Private_Key = privateKey;
            await NetworkHeaders.PrivateKeyRecoverWallet(privateKey, callBack);
        }

        /// <summary>
        /// 通过助记词恢复钱包
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static async Task RequestMnemonicRecoverWallet(string mnemonic, Action<WalletCallBackData> callBack = null)
        {
            await NetworkHeaders.MnemonicRecoverWallet(mnemonic, callBack);
        }

        /// <summary>
        /// BNB/BEP20 转账
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static async Task RequestTransferWallet(string toAddress, float value, int speed = 2, string symbol = "BNB", Action<TransferOutCallBackData> callBack = null)
        {
            await NetworkHeaders.TransferOut(toAddress, value, speed, symbol, callBack);
        }

        public static async Task BalanceWalletSuccess(BalanceWalletCallBackData callBackData)
        {
            //DynamicUserModel.Instance.walletBalanceInfo = new WalletBalanceInfo();
            //DynamicUserModel.Instance.walletBalanceInfo.account = callBackData.account;
            //DynamicUserModel.Instance.walletBalanceInfo.symbol = callBackData.symbol;
            //DynamicWalletModel.Instance.balance = callBackData.balance;
            //DynamicWalletModel.Instance.symbol = callBackData.symbol;
            DynamicWalletModel.Instance.SetBalance(BNBSymbol.BNB, double.Parse(callBackData.balance));
            //LitJsonMgr.Instance.WriteEncryJson("WalletBalanceData", callBackData);
            Debug.Log("查询钱包额度成功 ：" + JsonMapper.ToJson(callBackData));
        }

        public static async Task RecoverWalletSuccess(WalletCallBackData callBackData)
        {
            DynamicUserModel.Instance.walletInfo = new WalletInfo();
            DynamicUserModel.Instance.walletInfo.address = callBackData.address;
            DynamicUserModel.Instance.walletInfo.mnemonic = callBackData.mnemonic;
            DynamicUserModel.Instance.walletInfo.private_key = callBackData.private_key;
            ServerConfigMgr.Address = callBackData.address;
            ServerConfigMgr.Mnemonic = callBackData.mnemonic;
            ServerConfigMgr.Private_Key = callBackData.private_key;
            LitJsonMgr.Instance.WriteEncryJson("WalletData", callBackData);
            Debug.Log("恢复钱包数据成功 ：" + JsonMapper.ToJson(callBackData));
        }

        public static async Task CreateWalletSuccess(WalletCallBackData callBackData)
        {
            DynamicUserModel.Instance.walletInfo = new WalletInfo();
            DynamicUserModel.Instance.walletInfo.address = callBackData.address;
            DynamicUserModel.Instance.walletInfo.mnemonic = callBackData.mnemonic;
            DynamicUserModel.Instance.walletInfo.private_key = callBackData.private_key;
            ServerConfigMgr.Address = callBackData.address;
            ServerConfigMgr.Mnemonic = callBackData.mnemonic;
            ServerConfigMgr.Private_Key = callBackData.private_key;
            LitJsonMgr.Instance.WriteEncryJson("WalletData", callBackData);
            Debug.Log("写入钱包数据成功 ：" + JsonMapper.ToJson(callBackData));
        }

        public static async Task PrivateKeyRecoverWalletSuccess(PrivateKeyRecoverWalletCallBackData callBackData)
        {
            ServerConfigMgr.Address = callBackData.id;
            WalletCallBackData data = new WalletCallBackData();
            data.address = ServerConfigMgr.Address;
            data.mnemonic = ServerConfigMgr.Mnemonic;
            data.private_key = ServerConfigMgr.Private_Key;
            LitJsonMgr.Instance.WriteEncryJson("WalletData", data);
            Debug.Log("写入钱包数据成功 ：" + JsonMapper.ToJson(data));
        }


        public static async Task TransferOutSuccess(TransferOutCallBackData callBackData)
        {
            //LitJsonMgr.Instance.WriteEncryJson("WalletData", callBackData);
            TransferRecord transferRecord = new TransferRecord();
            transferRecord.address = DynamicWalletModel.Instance.presentTransferOut.address;
            transferRecord.dataTime = DynamicWalletModel.Instance.presentTransferOut.dataTime;
            transferRecord.balance = DynamicWalletModel.Instance.presentTransferOut.balance;
            DynamicWalletModel.Instance.transferRecordsList.Add(transferRecord); 
            LitJsonMgr.Instance.WriteEncryJson("TransferRecordsList", DynamicWalletModel.Instance.transferRecordsList);
            Debug.Log("添加轉賬記錄成功 ：" + JsonMapper.ToJson(DynamicWalletModel.Instance.transferRecordsList));
            Debug.Log("轉賬成功 ：" + JsonMapper.ToJson(callBackData));
        }
    }
}


