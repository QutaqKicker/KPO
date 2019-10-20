using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib
{
    public class EnterprisesListCommand
    {
        public EnterprisesListCommand()
        {
            _enterprises = new List<Enterprise>();
        }
        List<Enterprise> _enterprises;

        int _loadingStatus;

        public List<Enterprise> Enterprises
        {
            get { return _enterprises; }
        }

        public void Execute()
        {
            try
            {
                _enterprises.Add(new Enterprise() { Name = "Заря", PropertyType = "State", LandArea = 300, EmployeeQty = 120 });
                _enterprises.Add(new Enterprise() { Name = "Росинка", PropertyType = "Сooperative", LandArea = 174, EmployeeQty = 27 });
                _enterprises.Add(new Enterprise() { Name = "Петренко", PropertyType = "Private", LandArea = 56, EmployeeQty = 6 });
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog("Ошибка №2 " + ex.Message);
            }
        }


    }
}
