using DonnDomain.Objects;
using DonnDomain.Objects.Interface;
using DonnWeb.Models.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.UIMappers
{
    public class StandardNavigationMapper : INavigationMapper
    {

        public INavigationItem MapDomainModelToUi(INavigationItemDomain domainObject)
        {
            var downCast = (StandardNavigationItemDomain)domainObject;
            return new StandardNavigationItemModel()
            {
                Action = downCast.Action,
                ClassOverride = downCast.ClassOverride,
                DisplayText = downCast.DisplayText,
                Id = downCast.Id
            };
        }    
    }
}

