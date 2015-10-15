using DonnDomain.Objects.Interface;
using DonnWeb.Models.Navigation;
using System;
using System.Collections.Generic;
namespace DonnWeb.UIMappers
{
   public interface INavigationMapper
    {
        INavigationItem MapDomainModelToUi(INavigationItemDomain domainObject);
    }
}
