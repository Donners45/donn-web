using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Caching;

namespace DonnBusiness.BusinessLogic.Cache
{
    public abstract class InMemoryCacheBase<T> : ICacheService<T>
    {
        public T Get(string cacheKey)
        {
            T item = (T)MemoryCache.Default.Get(cacheKey);
            if (item == null || item.Equals(default(T))) 
            {
                item = GetFromRepository();
                MemoryCache.Default.Add(cacheKey, item, DateTime.Now.AddMinutes(10));
            }
            return item;
        }

        public abstract T GetFromRepository();
    }
}
