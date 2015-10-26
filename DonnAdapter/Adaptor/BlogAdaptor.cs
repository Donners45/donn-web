using DonnDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonnDomain.Objects;

namespace DonnAdapter.Adaptor
{
    class BlogAdaptor : IBlogAdaptor
    {

        private static IEnumerable<BlogItemDomain> StaticResource()
        {
            return new List<BlogItemDomain>(){
               new BlogItemDomain() { BlogId =1,  DateListed= new DateTime(2015,01,01), Title="Blog 1", RawHtmlContent="<h2>Blog 1 Content</h2>" },
               new BlogItemDomain() { BlogId =2,  DateListed= new DateTime(2015,01,02), Title="Blog 2", RawHtmlContent="<h2>Blog 2 Content</h2>" }
           };
        }

        public IEnumerable<DonnDomain.Objects.BlogItemDomain> GetBlogItems()
        {
            return StaticResource();
        }

        public DonnDomain.Objects.BlogItemDomain GetBlogById(int Id)
        {
            return StaticResource().SingleOrDefault(x => x.BlogId == Id);
        }

        public IEnumerable<DonnDomain.Objects.BlogItemDomain> GetBlogItemsByDateListed(DateTime dateListed)
        {
            return StaticResource().Where(x => x.DateListed.Date == dateListed.Date).OrderByDescending(x=>x.DateListed);
        }
    }
}
