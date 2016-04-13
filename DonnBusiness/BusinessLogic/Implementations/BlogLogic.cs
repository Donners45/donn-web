using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonnBusiness.BusinessLogic.Interface;
using DonnDomain.Interfaces;
using DonnDomain.Objects;
using DonnBusiness.BusinessLogic.Cache;

namespace DonnBusiness.BusinessLogic.Implementations
{
    public class BlogLogic : IBlogLogic
    {
        private readonly IBlogAdaptor _adaptor;
        private readonly ICacheService _cache;

        public BlogLogic(IBlogAdaptor adaptor, ICacheService cacheLayer)
        {
            _adaptor = adaptor;
            _cache = cacheLayer;
        }

        public BlogItemDomain GetBlogByUri(string uri)
        {
            return _cache.This("BlogItem.ByUri.FirstOrNothing." + uri, () => GetBlogByUriFromRepository(uri));
        }

        public List<BlogItemDomain> GetAllBlogItems()
        {
            return _cache.This("BlogItems.AllBlogsItems.NoOrder", GetAllFromRepository).ToList();    
        }

        private BlogItemDomain GetBlogByUriFromRepository(string uri)
        {
            var all = GetAllBlogItems();
            return all.Where(x => x.BlogUri == uri).FirstOrDefault();
        }

        private IEnumerable<BlogItemDomain> GetAllFromRepository()
        {
            return _adaptor.GetBlogItems();
        }

    }
}
