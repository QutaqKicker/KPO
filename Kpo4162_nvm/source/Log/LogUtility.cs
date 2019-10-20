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
            if (message == "")
                throw new Exception("Ошибка при логировании ошибки. Текст ошибки пуст");
            else
                File.AppendAllText("error.log", message + DateTime.Now.ToString());
        }
        public static void ErrorLog(Exception ex)
        {
            try
            {
                File.AppendAllText("error.log", ex.Message + DateTime.Now.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при логировании ошибки. Текст ошибки: " + e.Message);
            }
        }
    }
}
