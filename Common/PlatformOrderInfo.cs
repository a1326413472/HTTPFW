using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlatformOrderInfo
{
    public PlatformOrderInfo()
    {
        addtime = 0;
        amount = "";
        createTime = 0;
        detail = "";
        id = 0;
        image = "";
        old = "";
        orderId = "";
        status = 0;
        type = 0;
        uid = "";
        uname = "";
        updateTime = 0;
    }

    public int addtime;
    public string amount;
    public int createTime;
    public string detail;
    public int id;
    public string image;
    public string old;
    public string orderId;
    public int status;
    public int type;
    public string uid;
    public string uname;
    public int updateTime;
}
