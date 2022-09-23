using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Unity.Http
{
    public class UpdateVersionMessage : BaseHttpMessage
    {
        public VersionInfo body;

        public UpdateVersionMessage()
        {
            messageModuleType = MessageModuleType.Version;
            methodType = HttpMethodType.Put;
            m_Path = "/v1/version/version";
            headers.Add("Content-Type", "application/json");
        }
    }
}
