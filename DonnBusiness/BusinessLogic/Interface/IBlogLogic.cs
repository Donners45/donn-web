using DonnDomain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnBusiness.BusinessLogic.Interface
{
    public interface IBlogLogic
    {
        List<BlogItemDomain> GetAllBlogItems();
        BlogItemDomain GetBlogByUri(string uri);
    }
}
