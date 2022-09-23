using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;
using System.Threading.Tasks;
using System;
using LitJson;

namespace Alpha.Unity.Http
{
    public class MyProxy
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        public static async Task RequestGetUserInfo(Action<UserCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            await NetworkHeaders.GetUserInfo(callBackAction, errorAction);
        }
        /// <summary>
        /// 设置 角色资料（选角）
        /// </summary>
        public static async Task RequestSetRole(string color, string nickName, string sex, Action<UserCallBackData> callBackAction = null, Action<MessageType, int, string> errorAction = null)
        {
            await NetworkHeaders.SetRole(color, nickName, sex, callBackAction, errorAction);
        }

        public static async Task GetUserInfoSuccess(UserInfo callBackData)
        {
            DynamicUserModel.Instance.userInfo = callBackData;
            Debug.Log("获取用户信息成功 ：" + JsonMapper.ToJson(callBackData));
        }

        public static async Task SetRoleSuccess(UserInfo callBackData)
        {
            DynamicUserModel.Instance.userInfo = callBackData;
            Debug.Log("设置角色资料成功 ：" + JsonMapper.ToJson(callBackData));
        }
    }
}
