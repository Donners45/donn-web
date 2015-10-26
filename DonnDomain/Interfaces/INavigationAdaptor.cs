using DonnDomain.Objects.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnDomain.Interfaces
{
    public interface INavigationAdaptor
    {

        IEnumerable<INavigationItemDomain> GetNavigationItems();
        Objects.Interface.INavigationItemDomain GetItemById(int NavigationItemId);
    }
}
