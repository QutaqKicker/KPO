using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib
{
    public class EnterpriseListTestLoader : IEnterpriseListLoader
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

        public EnterpriseListTestLoader(string path)
        {
            filePath = path;
        }

        public void Execute()
        {
            try
            {
                enterpriseList.Add(new Enterprise() { Name = "Заря", PropertyType = "State", LandArea = 300, EmployeeQty = 120 });
                enterpriseList.Add(new Enterprise() { Name = "Росинка", PropertyType = "Сooperative", LandArea = 174, EmployeeQty = 27 });
                enterpriseList.Add(new Enterprise() { Name = "Петренко", PropertyType = "Private", LandArea = 56, EmployeeQty = 6 });
                loadStatus = LoadStatus.Success;
            }
            catch (Exception e)
            {
                loadStatus = LoadStatus.GeneralError;
                LogUtility.ErrorLog(e);
            }
        }
    }
}
