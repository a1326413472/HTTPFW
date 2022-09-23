using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{

    public class GetUserInfoMessage : MyHttpMessage
    {
        public GetUserInfoMessage():base()
        {
            methodType = HttpMethodType.Post;
            m_Path = "/v1/client/userInfo";
        }
    }
}
