using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnDomain.Objects
{
    public class BlogItemDomain
    {
        public string BlogUri { get; set; }
        public int BlogId { get; set; }
        public string RawHtmlContent { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateListed { get; set; }

        public string SnippetSummary { get; set; }

        // Future work.
        //Tags for searching internally?d
        // Summary / listing object - contains a parentId, title and cut down text. (this could be built dynamically from this) -- Go with mapping a listing object from the domain in BL to UI layers
    }
}
