using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnBusiness.BusinessLogic.Cache
{
    public interface ICacheService
    {
        T This<T>(string cacheKey, Func<T> getFromRepository);
        void Flush();
    }
}
