using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Caching;

namespace DonnBusiness.BusinessLogic.Cache
{
    public class InMemoryCache : ICacheService
    {
        public T This<T>(string cacheKey, Func<T> getFromRepository)
        {
            T item = (T)MemoryCache.Default.Get(cacheKey);
            if (item == null || item.Equals(default(T))) 
            {
                item = getFromRepository();
                MemoryCache.Default.Add(cacheKey, item, DateTime.Now.AddMinutes(10));
            }
            return item;
        }

        public void Flush()
        {
            // MemoryCache Flush?
        }
    }
}
