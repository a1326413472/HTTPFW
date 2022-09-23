using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

namespace XRTools
{
    public class EncryUtils
    {
        private const string encryptKey = "GsbHsKyuHJSDPsdf";

        //AES加密
        public static string AesEncrypt(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            var _keyByte = Encoding.UTF8.GetBytes(encryptKey);
            var _valueByte = Encoding.UTF8.GetBytes(value);
            using (var aes = new RijndaelManaged())
            {
                aes.IV = _keyByte;
                aes.Key = _keyByte;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                var cryptoTransform = aes.CreateEncryptor();
                var resultArray = cryptoTransform.TransformFinalBlock(_valueByte.ToArray(), 0, _valueByte.Length);
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
        }

        //AES解密
        public static string AesDecrypt(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            var _keyByte = Encoding.UTF8.GetBytes(encryptKey);
            var _valueByte = Convert.FromBase64String(value);
            using (var aes = new RijndaelManaged())
            {
                aes.IV = _keyByte;
                aes.Key = _keyByte;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                var cryptoTransform = aes.CreateDecryptor();
                var resultArray = cryptoTransform.TransformFinalBlock(_valueByte.ToArray(), 0, _valueByte.Length);
                return Encoding.UTF8.GetString(resultArray);
            }
        }
    }
}

