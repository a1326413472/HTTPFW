using Alpha.Unity.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class FireworkProxy : Singleton<FireworkProxy>
    {
        public static Action FireworkCreateAction;
        public static Action FireworkListAction;
        public static Action FireworkUpdateAction;


        public static async Task RequestFireworkCreate(FireworkInfo data)
        {
            await NetworkHeaders.FireworkCreate(data);
        }

        public static async Task RequestFireworkList(string uid)
        {
            await NetworkHeaders.FireworkList(uid);
        }

        public static async Task RequestFireworkUpdate(string id)
        {
            await NetworkHeaders.FireworkUpdate(id);
        }

        public static async Task FireworkListSuccess(FireworkCallBackData data)
        {
            DynamicFireworkModel.Instance.fireworkInfo = data;
        }
    }
}

