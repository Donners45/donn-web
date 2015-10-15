using DonnDomain.Objects.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnBusiness.BusinessLogic.Interface
{
    public interface INavigationLogic
    {

       IEnumerable<INavigationItemDomain> getNavigationItems();

    }
}
