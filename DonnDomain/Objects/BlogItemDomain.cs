using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnDomain.Objects
{
    public class BlogItemDomain
    {
        public int BlogId { get; set; }
        public string RawHtmlContent { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateListed { get; set; }


        // Future work.
        //Tags for searching internally?
        //Social url for sharing?

        // Summary / listing object - contains a parentId, title and cut down text. (this could be built dynamically from this)
    }
}
