using DonnDomain.Objects;
using DonnDomain.Objects.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.UIMappers
{
    public class NavigationMapperFactory
    {

        public INavigationMapper GetMapperForType(INavigationItemDomain objectToMap)
        {
            if (objectToMap == null) throw new ArgumentNullException();
            
            if (objectToMap is StandardNavigationItemDomain)
            {
                return new StandardNavigationMapper();
            }
            
            if (objectToMap is DropdownNavigationItemDomain)
            {
                return new DropdownNavigationMapper();
            }

            throw new NotImplementedException();
        }

    }
}