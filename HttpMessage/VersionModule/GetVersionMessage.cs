using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class GetVersionMessage : BaseHttpMessage
    {
        public GetVersionMessage()
        {
            messageModuleType = MessageModuleType.Version;
            methodType = HttpMethodType.Get;
            m_Path = "/v1/public/version";
        }
    }
}
