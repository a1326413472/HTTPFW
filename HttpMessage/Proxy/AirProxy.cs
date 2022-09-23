using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class AirProxy : Singleton<AirProxy>
    {
        public static Action AirAddAction;
        public static Action AirGetOneAction;
        public static Action AirGetOneByToAction;
        public static Action AirListAction;
        public static Action AirUpdateAction;
        public static Action AirUpdateStatusAction;
        
        public static async Task RequestAirAdd(Air data)
        {
            await NetworkHeaders.AirAdd(data);
        }

        public static async Task RequestAirGetOne(string id)
        {
            await NetworkHeaders.AirGetOne(id);
        }

        public static async Task RequestAirGetOneByTo(string to)
        {
            await NetworkHeaders.AirGetOneByTo(to);
        }

        public static async Task RequestAirList()
        {
            await NetworkHeaders.AirList();
        }

        public static async Task RequestAirUpdate(Air data)
        {
            await NetworkHeaders.AirUpdate(data);
        }

        public static async Task RequestAirUpdateStatus(string id, string status)
        {
            await NetworkHeaders.AirUpdateStatus(id, status);
        }


        /// <summary>
        /// 新增机票成功
        /// </summary>
        public static async Task AirAddSuccess(AirAddCallBackData callBackData)
        {
            if (!DynamicAirModel.Instance.idAirsDic.ContainsKey(callBackData.id))
            {
                DynamicAirModel.Instance.idAirsDic.Add(callBackData.id, new AirInfo());
            }            
            Debug.Log("新增机票成功 ：" + JsonMapper.ToJson(callBackData));
        }

        /// <summary>
        /// 查询机票成功
        /// </summary>
        public static async Task AirGetSuccess(AirCallBackData callBackData)
        {

            Debug.Log("查询机票成功 ：" + JsonMapper.ToJson(callBackData));
        }

        /// <summary>
        /// 修改机票成功
        /// </summary>
        public static async Task AirUpdateSuccess(AirCallBackData callBackData)
        {

            Debug.Log("修改机票成功 ：" + JsonMapper.ToJson(callBackData));
        }
    }
}
