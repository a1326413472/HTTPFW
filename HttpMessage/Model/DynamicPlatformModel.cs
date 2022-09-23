using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;

public class DynamicPlatformModel : Singleton<DynamicPlatformModel>
{
    public PlatformProductInfo platformProductInfo;
    public PlatformOrderInfo platformOrderInfo;

    public Dictionary<string, PlatformProductInfo> allPlatformProductInfo = new Dictionary<string, PlatformProductInfo>();
    public Dictionary<string, Dictionary<string, PlatformProductInfo>> citysPlatformProductInfo = new Dictionary<string, Dictionary<string, PlatformProductInfo>>();
    public Dictionary<string, Dictionary<string, PlatformProductInfo>> typesPlatformProductInfo = new Dictionary<string, Dictionary<string, PlatformProductInfo>>();

}
