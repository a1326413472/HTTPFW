using UnityEngine;


namespace XRTools
{
    public abstract class LitJsonMgr
    {

        private static LitJsonMgr instance;

        public static LitJsonMgr Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }
                else
                {
                    instance = new LitJsonManager();
                }
                return instance;
            }
        }

        /// <summary>
        /// Json保存目录
        /// </summary>
        public string DirectoryPath { get { return Application.persistentDataPath + "/Meta/"; } }

        /// <summary>
        /// 初始化Json
        /// </summary>
        public abstract void Init<T>(string key, T t) where T : new();

        /// <summary>
        /// 读取Json
        /// </summary>
        public abstract T ReadJson<T>(string key, ref T t) where T : new();

        /// <summary>
        /// 读取加密Json
        /// </summary>
        public abstract T ReadEncryJson<T>(string key, ref T t) where T : new();

        /// <summary>
        /// 写入Json
        /// </summary>
        public virtual void WriteJson<T>(string key, T t) where T : new()
        {
            Save();
        }

        /// <summary>
        /// 写入加密Json
        /// </summary>
        public virtual void WriteEncryJson<T>(string key, T t) where T : new()
        {
            Save();
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public virtual void Save() { }
    }
}
