using DonnDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonnDomain.Objects;

namespace DonnAdapter.Adaptor
{
    // Should Adaptor be responsible for filtering resources on property? I'd have to move caching into adaptor level - Or let BL be responsible for this an have skinny adaptors?
    public class BlogAdaptor : IBlogAdaptor
    {

        private static IEnumerable<BlogItemDomain> StaticResource()
        {
            return new List<BlogItemDomain>(){
               new BlogItemDomain() { BlogId =1,  DateListed= new DateTime(2015,01,01), Title="Blog 1", RawHtmlContent="<h2>Blog 1 Content</h2>", SnippetSummary="Blog 1 Snippet", BlogUri = "Blog1Uri" },
               new BlogItemDomain() { BlogId =2,  DateListed= new DateTime(2015,01,02), Title="Blog 2", RawHtmlContent="<h2>Blog 2 Content</h2>", SnippetSummary="Blog 2 Snippet", BlogUri = "Blog2Uri"}
           };
        }

        public IEnumerable<BlogItemDomain> GetBlogItems()
        {
            return StaticResource();
        }

        //public BlogItemDomain GetBlogById(int Id)
        //{
        //    return StaticResource().SingleOrDefault(x => x.BlogId == Id);
        //}

        //public IEnumerable<BlogItemDomain> GetBlogItemsByDateListed(DateTime dateListed)
        //{
        //    return StaticResource().Where(x => x.DateListed.Date == dateListed.Date).OrderByDescending(x=>x.DateListed);
        //}
    }
}
