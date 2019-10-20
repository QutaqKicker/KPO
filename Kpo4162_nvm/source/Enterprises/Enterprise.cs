using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib
{
    //public enum PropertyType { State, Private, Сooperative }
    public class Enterprise
    {
        public string Name { get; set; }
        public string PropertyType { get; set; }
        public int LandArea { get; set; }
        public int EmployeeQty { get; set; }
        public Enterprise()
        {
            Name = "";
            LandArea = 0;
            EmployeeQty = 0;
        }
    }
}
