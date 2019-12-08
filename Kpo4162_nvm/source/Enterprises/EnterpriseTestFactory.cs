using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib.source.Enterprises
{
    class EnterpriseTestFactory : IEnterpriseFactory
    {
        public IEnterpriseListLoader CreateEnterpriseLoader(string path)
        {
            return new EnterpriseListTestLoader(path);
        }
    }
}
