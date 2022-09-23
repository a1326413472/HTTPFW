using System.IO;
using UnityEngine;
using System.Text;
using LitJson;

namespace XRTools
{
    public class LitJsonManager : LitJsonMgr
    {

        public override void Init<T>(string key, T t)
        {
            PlayerPrefs.DeleteKey(key);

            t = new T();

            PlayerPrefs.SetString(key,JsonMapper.ToJson(t));

            WriteJson<T>(key, t);
        }

        public override T ReadJson<T>(string key, ref T t)
        {
            if (!File.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }

            string filePath = DirectoryPath + key + ".txt";

            if (PlayerPrefs.GetString(key) == "")
            {
                Init(key, t);
            }

            if (!File.Exists(filePath))
            {
                Init(key, t);
            }

            StreamReader sr = new StreamReader(filePath);
            JsonReader jr = new JsonReader(sr);
            t = JsonMapper.ToObject<T>(jr);
            sr.Close();

            return t;
        }

        public override T ReadEncryJson<T>(string key, ref T t)
        {
            if (!File.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }

            string filePath = DirectoryPath + EncryUtils.AesEncrypt(key) + ".txt";

            if (PlayerPrefs.GetString(key) == "")
            {
                Init(key, t);
            }

            if (!File.Exists(filePath))
            {
                Init(key, t);
            }

            StreamReader sr = new StreamReader(filePath);
            string json = EncryUtils.AesDecrypt(sr.ReadToEnd());
            t = JsonMapper.ToObject<T>(json);
            sr.Close();

            return t;
        }

        public override void WriteJson<T>(string key, T t)
        {
            base.WriteJson<T>(key, t);

            string json = "";
            json = JsonMapper.ToJson(t);
            string filePath = DirectoryPath + key + ".txt";
            if (!File.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }
            if (!File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);

                StreamWriter sw = new StreamWriter(fileStream, Encoding.UTF8);

                sw.Write(json);

                sw.Close();

                fileStream.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(filePath);

                sw.Write(json);

                sw.Close();
            }
        }

        public override void WriteEncryJson<T>(string key, T t)
        {
            base.WriteJson<T>(key, t);

            string encryJson = "";
            encryJson = EncryUtils.AesEncrypt(JsonMapper.ToJson(t));
            string filePath = DirectoryPath + EncryUtils.AesEncrypt(key) + ".txt";
            if (!File.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }
            if (!File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);

                StreamWriter sw = new StreamWriter(fileStream, Encoding.UTF8);

                sw.Write(encryJson);

                sw.Close();

                fileStream.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(filePath);

                sw.Write(encryJson);

                sw.Close();
            }
        }

        public override void Save()
        {
            base.Save();
        }


    }
}
