using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class PlatformHandler : Singleton<PlatformHandler>
    {
        #region Product
        public static async Task ProductCreateHandler(ProductCreateCallBackMessage callBackMessage)
        {
            ProductCallBackData data = callBackMessage.data;
            await PlatformProxy.ProductCreateSuccess(data);
            if (PlatformProxy.ProductCreateAction != null)
            {
                PlatformProxy.ProductCreateAction();
            }
        }

        public static async Task ProductListHandler(ProductListCallBackMessage callBackMessage)
        {
            ProductCallBackData data = callBackMessage.data;
            await PlatformProxy.ProductListSuccess(data);
            if (PlatformProxy.ProductListAction != null)
            {
                PlatformProxy.ProductListAction();
            }
        }

        public static async Task ProductListByCidHandler(ProductListByCidCallBackMessage callBackMessage)
        {
            ProductCallBackData data = callBackMessage.data;
            await PlatformProxy.ProductListByCidSuccess(data);
            if (PlatformProxy.ProductListByCidAction != null)
            {
                PlatformProxy.ProductListByCidAction();
            }
        }

        public static async Task ProductTypeListHandler(ProductTypeListCallBackMessage callBackMessage)
        {
            ProductCallBackData data = callBackMessage.data;
            await PlatformProxy.ProductTypeListSuccess(data);
            if (PlatformProxy.ProductTypeListAction != null)
            {
                PlatformProxy.ProductTypeListAction();
            }
        }
        #endregion


        #region Order
        public static async Task OrderAddHandler(OrderAddCallBackMessage callBackMessage)
        {
            OrderCallBackData data = callBackMessage.data;
            await PlatformProxy.OrderAddSuccess(data);
            if (PlatformProxy.OrderAddAction != null)
            {
                PlatformProxy.OrderAddAction();
            }
        }

        public static async Task OrderGetOrderHandler(OrderGetOrderCallBackMessage callBackMessage)
        {
            OrderCallBackData data = callBackMessage.data;
            await PlatformProxy.OrderGetOrderSuccess(data);
            if (PlatformProxy.OrderGetOrderAction != null)
            {
                PlatformProxy.OrderGetOrderAction();
            }
        }

        public static async Task OrderListHandler(OrderListCallBackMessage callBackMessage)
        {
            OrderCallBackData data = callBackMessage.data;
            await PlatformProxy.OrderListSuccess(data);
            if (PlatformProxy.OrderListAction != null)
            {
                PlatformProxy.OrderListAction();
            }
        }
        #endregion
    }

}
