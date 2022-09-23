using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;

public class DynamicAirModel : Singleton<DynamicAirModel>
{
    public Dictionary<string, AirInfo> idAirsDic = new Dictionary<string, AirInfo>();
    public Dictionary<string, AirInfo> toAirsDic = new Dictionary<string, AirInfo>();
    public Dictionary<string, AirInfo> allAirsDic = new Dictionary<string, AirInfo>();

}
