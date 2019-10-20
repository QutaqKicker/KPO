using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib
{
    public class AgroEnterprisesListCommand
    {
        public AgroEnterprisesListCommand()
        {
            _enterprises = new List<AgroEnterprise>();
        }
        List<AgroEnterprise> _enterprises;

        int _loadingStatus;

        public List<AgroEnterprise> Enterprises
        {
            get { return _enterprises; }
        }

        public void Execute()
        {
            try
            {/*
                _enterprises.Add(new AgroEnterprise() { Name = "Заря", PropertyType = PropertyType.State, LandArea = 300, EmployeeQty = 120 });
                _enterprises.Add(new AgroEnterprise() { Name = "Росинка", PropertyType = PropertyType.Сooperative, LandArea = 174, EmployeeQty = 27 });
                _enterprises.Add(new AgroEnterprise() { Name = "Петренко", PropertyType = PropertyType.Private, LandArea = 56, EmployeeQty = 6 });
                */
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog("Ошибка №2 " + ex.Message);
            }
        }


    }
}
