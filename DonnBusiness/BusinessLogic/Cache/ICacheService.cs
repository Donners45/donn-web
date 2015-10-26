using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnBusiness.BusinessLogic.Cache
{
    interface ICacheService<T>
    {
        T Get(string cacheKey);
    }
}
