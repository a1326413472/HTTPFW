using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FireworkInfo
{
    public FireworkInfo()
    {
        createTime = 0;
        id = "";
        status = 0;
        type = 0;
        uid = "";
        updateTime = 0;
    }

    public int createTime;
    public string id;
    public int status;
    public int type;
    public string uid;
    public int updateTime;
}
