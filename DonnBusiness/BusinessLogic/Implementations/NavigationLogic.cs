using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonnDomain.Interfaces;
using DonnDomain.Objects.Interface;

namespace DonnBusiness.BusinessLogic.Implementations
{
    public class NavigationLogic : Interface.INavigationLogic
    {

        private INavigationAdaptor _adaptor;


        public NavigationLogic(INavigationAdaptor navAdaptor)
        {
            _adaptor = navAdaptor;
        }


        public IEnumerable<INavigationItemDomain> getNavigationItems()
        {

            var items = _adaptor.GetNavigationItemsFromRepository();
            return items;

        }

    }
}
