using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.Models.Navigation
{
    public class NavigationItemsModel
    {
        public IEnumerable<INavigationItem> ItemsInNavigation { get; set; }
    }
}