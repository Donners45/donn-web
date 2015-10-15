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

        IEnumerable<INavigationItemDomain> GetNavigationItemsFromRepository();
        Objects.Interface.INavigationItemDomain GetItemFromRepository(int NavigationItemId);
    }
}
