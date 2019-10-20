using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib
{
    public abstract class IEnterprise
    {
        public abstract string Name { get; set; }
        public abstract string PropertyType { get; set; }
        public abstract int LandArea { get; set; }
        public abstract int EmployeeQty { get; set; }
    }
}
