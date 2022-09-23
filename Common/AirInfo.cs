using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AirInfo
{
    public AirInfo()
    {
        createTime = 0;
        from = "";
        id = "";
        num = 0;
        price = "";
        status = 0;
        to = "";
        updateTime = 0;
    }

    public int createTime;
    public string from;
    public string id;
    public int num;
    public string price;
    public int status;
    public string to;
    public int updateTime;
}
