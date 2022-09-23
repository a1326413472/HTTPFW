using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XRTools;

public class EncryTest : MonoBehaviour
{
    public string value;
    public string eValue;
    public string dValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            eValue = EncryUtils.AesEncrypt(value);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            dValue = EncryUtils.AesDecrypt(eValue);
        }
    }
}
