using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XRTools;

namespace Alpha.Unity.Http
{
    public class PlatformProxy : Singleton<PlatformProxy>
    {

        public static Action ProductCreateAction;
        public static Action ProductListAction;
        public static Action ProductListByCidAction;
        public static Action ProductTypeListAction;

        public static Action OrderAddAction;
        public static Action OrderGetOrderAction;
        public static Action OrderListAction;


        public static async Task RequestProductCreate(PlatformProductInfo data)
        {
            await NetworkHeaders.ProductCreate(data);
        }

        public static async Task RequestProductList()
        {
            await NetworkHeaders.ProductList();
        }

        public static async Task RequestProductListByCid(string cityId)
        {
            await NetworkHeaders.ProductListByCid(cityId);
        }

        public static async Task RequestProductTypeList(string type)
        {
            await NetworkHeaders.ProductTypeList(type);
        }


        public static async Task RequestOrderAdd(PlatformOrderInfo data)
        {
            await NetworkHeaders.OrderAdd(data);
        }

        public static async Task RequestOrderGetOrder(string orderId)
        {
            await NetworkHeaders.OrderGetOrder(orderId);
        }

        public static async Task RequestOrderList(int pageNum, string pageSize)
        {
            await NetworkHeaders.OrderList(pageNum, pageSize);
        }


        public static async Task ProductCreateSuccess(ProductCallBackData data)
        {
            
        }

        public static async Task ProductListSuccess(ProductCallBackData data)
        {
            
        }

        public static async Task ProductListByCidSuccess(ProductCallBackData data)
        {
            
        }

        public static async Task ProductTypeListSuccess(ProductCallBackData data)
        {
            
        }

        public static async Task OrderAddSuccess(OrderCallBackData data)
        {

        }

        public static async Task OrderGetOrderSuccess(OrderCallBackData data)
        {

        }

        public static async Task OrderListSuccess(OrderCallBackData data)
        {

        }
    }
}

