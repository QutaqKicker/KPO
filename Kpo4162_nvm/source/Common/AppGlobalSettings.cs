using Kpo4162_nvm.Lib.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib
{
    public static class AppGlobalSettings
    {
        private static string _logPath;

        private static string _dataFileName;

        public static string LogPath
        {
            get { return _logPath; }
        }

        public static string DataFileName
        {
            get { return _dataFileName; }
        }

        public static void Initialize()
        {
            _logPath = AppConfigUtility.AppSettings("logPath");
            _dataFileName = AppConfigUtility.AppSettings("dataFileName");
        }
    }
}
