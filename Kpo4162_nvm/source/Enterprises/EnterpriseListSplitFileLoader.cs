using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100
    }

    public class EnterpriseListSplitFileLoader : IEnterpriseListLoader
    {
        string filePath;

        private LoadStatus loadStatus = LoadStatus.None;

        List<IEnterprise> enterpriseList = new List<IEnterprise>();

        public LoadStatus LoadStatus
        {
            get { return loadStatus; }
        }

        public List<IEnterprise> GetEnterprises()
        {
            return enterpriseList;
        }

        public EnterpriseListSplitFileLoader(string path)
        {
            filePath = path;
        }

        public void Execute()
        {
            try
            {
                if (filePath == "")
                {
                    loadStatus = LoadStatus.FileNameIsEmpty;
                    throw new Exception("Путь к файлу не указан");
                }   
                var file = File.Open(filePath, FileMode.Open, FileAccess.Read);
                string text;
                using (var sr = new StreamReader(file))
                {
                    while((text = sr.ReadLine()) != "")
                    {
                        var enterpriceParts = text.Split('|');
                        enterpriseList.Add(new Enterprise() { Name = enterpriceParts[0], PropertyType = enterpriceParts[1], LandArea = int.Parse(enterpriceParts[2]), EmployeeQty = int.Parse(enterpriceParts[3]) });
                    }
            }
                loadStatus = LoadStatus.Success;
            }
            catch(FileNotFoundException e)
            {
                enterpriseList = null;
                loadStatus = LoadStatus.FileNotExists;
                LogUtility.ErrorLog(e);
            }
            catch(Exception e)
            {
                loadStatus = LoadStatus.GeneralError;
                LogUtility.ErrorLog(e);
            }
        }
    }
}
