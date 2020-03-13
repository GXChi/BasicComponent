using CommonCore.Log;
using System;
using System.Configuration;

namespace DataHelper
{
    public static class CommandInfoLoader
    {
        public static readonly bool CacheEnabled;
        public static readonly string MemCategory;
        public static readonly string mInfoPath;
        public static readonly string mInfoRoot;

        static CommandInfoLoader()
        {
            mInfoRoot = @"Bin\CommandInfo\";
            MemCategory = "CommandInfoLoader";
            CacheEnabled = true;
            mInfoPath = ConfigurationManager.AppSettings["CommandInfo"] ?? string.Empty;
            //Logger.Loging(LogLevel.Debug5, "CommandInfoLoader", string.Format("static CommandInfoLoader InfoRoot:{0}", mInfoRoot, mInfoPath));
            string str = ConfigurationManager.AppSettings["CacheEnabledCommandInfo"];
            //Logger.Loging(LogLevel.Debug5, "CommandInfoLoader", string.Format("static CommandInfoLoader cached:{0}", str));
            if (!string.IsNullOrEmpty(str) && (str.Trim().ToUpper() == "OFF"))
            {
                CacheEnabled = false;
            }
        }

        public static void ClearCache(object saveObject, Type type, string accesskey)
        {
            if (CacheEnabled)
            {
                //new CacheManager().Clear(MemCategory);
            }
        }

        public static string GetInfoPath(string accessKey)
        {
            if (!string.IsNullOrEmpty(mInfoPath))
            {
                return (mInfoPath + @"\" + accessKey.Replace('.', '\\') + ".xml");
            }
            return (AppDomain.CurrentDomain.BaseDirectory + mInfoPath + accessKey.Replace('.', '\\') + ".xml");
        }

        //public static CommandInfo LoadCommandInfo(string accessKey)
        //{
        //string infoPath = GetInfoPath(accessKey);
        //if (CacheEnabled)
        //{
        //CacheEnabled manager = new CacheEnabled();
        //object obj2 = manager.Get(MemCategory, infoPath);
        //if (obj2 is CommandInfo)
        //{
        //    Logger.Loging(LogLevel.Debug5, MemCategory, string.Format("LoadCommandInfo from cache [{0}]", accessKey));
        //    return (CommandInfo)obj2;
        //}
        //CommandInfo info2 = (CommandInfo)ObjectXSerializer.XmlReader(typeof(CommandInfo), infoPath);
        //manager.Add(MemCategory, infoPath, info2, DateTime.Now.AddDays(1.0));
        //Logger.Loging(LogLevel.Debug5, MemCategory, string.Format("LoadCommandInfo from disk [{0}]", accessKey));
        //return info2;
        //}
        //Logger.Loging(LogLevel.Debug5, MemCategory, string.Format("LoadCommandInfo from disk [{0}]", accessKey));
        //return (CommandInfo)ObjectXSerializer.XmlReader(typeof(CommandInfo), infoPath);

        //}


    }
}
