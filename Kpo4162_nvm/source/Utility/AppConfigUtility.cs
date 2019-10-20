using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kpo4162_nvm.Lib.Utility
{
    public static class AppConfigUtility
    {
        public static string AppSettings(string name)
        {
            if (name != "")
                return ConfigurationManager.AppSettings.Get(name);
            else
                return "";
        }
    }
}
