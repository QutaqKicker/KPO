using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib
{
    public static class LogUtility
    {
        public static void ErrorLog(string message)
        {
            File.AppendAllText("error.log", message + DateTime.Now.ToString());
        }
        public static void ErrorLog(Exception ex)
        {
            File.AppendAllText("error.log", ex.Message + DateTime.Now.ToString());
        }
    }
}
