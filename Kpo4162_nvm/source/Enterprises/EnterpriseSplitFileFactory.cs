using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib.source.Enterprises
{
    class EnterpriseSplitFileFactory : IEnterpriseFactory
    {
        public IEnterpriseListLoader CreateEnterpriseLoader(string path)
        {
            return new EnterpriseListSplitFileLoader(path);
        }
    }
}
