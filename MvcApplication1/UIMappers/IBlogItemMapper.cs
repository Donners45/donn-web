using DonnDomain.Objects;
using DonnWeb.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnWeb.UIMappers
{
    public interface IBlogItemMapper
    {
        BlogItem Map(BlogItemDomain domain);

    }
}
