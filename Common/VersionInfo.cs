using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VersionInfo
{
    public VersionInfo()
    {
        createTime = 0;
        id = "";
        isUpdate = "";
        num = 0;
        status = 0;
        txt = "";
        updateTime = 0;
        url = "";
        version = "";
    }

    public int createTime;
    public string id;
    public string isUpdate;
    public int num;
    public int status;
    public string txt;
    public int updateTime;
    public string url;
    public string version;
}
