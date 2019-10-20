using Kpo4162_nvm.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm
{
    public class AgroEnterprisesLoader
    {
        const int col1 = 10, col2 = 10, col3 = 3, col4 = 3;
        string filePath;

        List<AgroEnterprise> enterpriseList = new List<AgroEnterprise>();
            
        public List<AgroEnterprise> Enterprises
        {
            get { return enterpriseList; }
        }

        public AgroEnterprisesLoader(string path)
        {
            filePath = path;
        }

        public void Execute()
        {
            //try
            //{
                if (filePath == "")
                {
                    throw new Exception("Путь к файлу не указан");
                }
                var file = File.Open(filePath, FileMode.Open, FileAccess.Read);
                string text;
                using (var sr = new StreamReader(file))
                {
                    while (!((text = sr.ReadLine()) is null))
                    {
                        Console.WriteLine(text.Substring(1, col1)+ " " + text.Substring(col1 + 1, col2) + " " + text.Substring(col1 + col2 + 1, col3) + " " + text.Substring(col1 + col2 + col3 + 1));
                        enterpriseList.Add(new AgroEnterprise() { Name = text.Substring(0, col1), PropertyType = text.Substring(col1, col2), LandArea = int.Parse(text.Substring(col1 + col2, col3).Trim()), EmployeeQty = int.Parse(text.Substring(col1 + col2 + col3).Trim()) });
                    }
                }/*
            }
            catch (FileNotFoundException e)
            {
                enterpriseList = null;
                LogUtility.ErrorLog(e);
            }
            catch (Exception e)
            {
                LogUtility.ErrorLog(e);
            }*/
        }
    }
}
