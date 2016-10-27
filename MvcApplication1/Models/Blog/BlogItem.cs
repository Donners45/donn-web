using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.Models.Blog
{
   
    public class BlogItem
    {

        public string BlogUri { get; set; }
        public int BlogId { get; set; }
        public string RawHtmlContent { get; set; }
        public string Title { get; set; }
        public string TitleClose { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateListed { get; set; }
        public string SnippetSummary { get; set; }

    }
}