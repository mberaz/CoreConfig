using System;
using System.Configuration;

namespace StuffCore
{
    public class StuffCore
    {
        string configKey = string.Empty;
        public StuffCore()
        {
            configKey = ConfigurationManager.AppSettings["configKey"];
        }


        public string GetKey(string key)
        {
            return ConfigurationManager.AppSettings[key] + "_" + configKey;
        }
    }
}
