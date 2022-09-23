using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlatformProductInfo
{
    public PlatformProductInfo()
    {
        cid = "";
        createTime = 0;
        id = "";
        name = "";
        price = "";
        status = 0;
        type = 0;
        updateTime = 0;
    }

    public string cid;
    public int createTime;
    public string id;
    public string name;
    public string price;
    public int status;
    public int type;
    public int updateTime;
}
