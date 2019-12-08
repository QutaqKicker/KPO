using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4162_nvm.Lib.source.Enterprises
{
    public interface IEnterpriseFactory
    {
        IEnterpriseListLoader CreateEnterpriseLoader(string path);
    }
}
