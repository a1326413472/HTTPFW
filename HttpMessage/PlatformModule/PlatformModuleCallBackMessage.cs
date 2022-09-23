using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{

    public class PlatformModuleCallBackMessage
    {
    }

    #region Product
    public class ProductCreateCallBackMessage : BaseHttpCallBackMessage
    {
        public ProductCallBackData data;
    }

    [System.Serializable]
    public class ProductCallBackData : PlatformProductInfo, ICallData
    {
    }
    public class ProductListCallBackMessage : BaseHttpCallBackMessage
    {
        public ProductCallBackData data;

        public ProductListCallBackMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            m_MessageType = MessageType.ProductListType;
        }
    }

    public class ProductListByCidCallBackMessage : BaseHttpCallBackMessage
    {
        public ProductCallBackData data;

        public ProductListByCidCallBackMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            m_MessageType = MessageType.ProductListByCidType;
        }
    }

    public class ProductTypeListCallBackMessage : BaseHttpCallBackMessage
    {
        public ProductCallBackData data;

        public ProductTypeListCallBackMessage()
        {
            messageModuleType = MessageModuleType.Platform;
            m_MessageType = MessageType.ProductTypeListType;
        }
    }
    #endregion


    #region Order
    [System.Serializable]
    public class OrderCallBackData : PlatformOrderInfo, ICallData
    {
    }

    public class OrderAddCallBackMessage : BaseHttpCallBackMessage
    {
        public OrderCallBackData data;
    }

    public class OrderGetOrderCallBackMessage : BaseHttpCallBackMessage
    {
        public OrderCallBackData data;
    }

    public class OrderListCallBackMessage : BaseHttpCallBackMessage
    {
        public OrderCallBackData data;
    }
    #endregion

}
