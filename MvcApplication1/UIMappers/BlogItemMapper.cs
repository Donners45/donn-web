using DonnDomain.Objects;
using DonnWeb.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.UIMappers
{
    public class BlogItemMapper : IBlogItemMapper
    {
        public BlogItem Map(BlogItemDomain domain)
        {
            if (domain == null) return null;

            return new BlogItem
            {
                BlogId = domain.BlogId,
                DateCreated = domain.DateCreated,
                DateListed = domain.DateListed,
                RawHtmlContent = domain.RawHtmlContent,
                Title = domain.Title,
                BlogUri = domain.BlogUri,
                SnippetSummary = domain.SnippetSummary
            };
        }
    }
}