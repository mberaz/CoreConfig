using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuff
{
    public class StuffNet
    {
        string configKey = string.Empty;
        public StuffNet()
        {
            configKey = ConfigurationManager.AppSettings["configKey"];
        }


        public string GetKey(string key)
        {
            return configKey + "_" + ConfigurationManager.AppSettings[key];
        }
    }
}
