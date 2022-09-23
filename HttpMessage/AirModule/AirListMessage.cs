using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class AirListMessage : BaseHttpMessage
    {
        public AirGetOneBody body;

        public AirListMessage()
        {
            messageModuleType = MessageModuleType.Air;
            methodType = HttpMethodType.Post;
            m_Path = "/v1/air/list";
            headers.Add("Content-Type", "application/json");
        }
    }


}