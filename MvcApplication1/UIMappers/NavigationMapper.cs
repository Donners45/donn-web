using DonnDomain.Objects;
using DonnDomain.Objects.Interface;
using DonnWeb.Models.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.UIMappers
{
    public class NavigationMapper : INavigationMapper
    {


        public INavigationItem MapDomainModelToUi(INavigationItemDomain domainObject)
        {

            if (domainObject is StandardNavigationItemDomain)
            {
                var downCast = (StandardNavigationItemDomain)domainObject;
                return new StandardNavigationItemModel(){
                    Action = downCast.Action,
                    ClassOverride = downCast.ClassOverride,
                    DisplayText = downCast.DisplayText,
                    Id = downCast.Id
                };

            } else if (domainObject is DropdownNavigationItemDomain)
            {
                var downCast = (DropdownNavigationItemDomain)domainObject;
                var p = new DropdownNavigationItem()
                {
                    DisplayText = downCast.DisplayText,
                    Id = downCast.Id,
                    ItemCollection = new List<DropdownItem>()
                };

                foreach (var y in downCast.ItemCollection)
                {
                    p.ItemCollection.Add(new DropdownItem()
                    {
                        Action = y.Action,
                        DisplayText = y.DisplayText
                    });
                }
                return p;

            }

            

            return null;
        }

    }
}