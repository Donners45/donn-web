using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.Models.Navigation
{
    public class StandardNavigationItemModel : INavigationItem
    {
        public int? Id { get; set; }        
        public string Action { get; set; }
        public string ClassOverride { get; set; }
        public string DisplayText { get; set; }
    }
}