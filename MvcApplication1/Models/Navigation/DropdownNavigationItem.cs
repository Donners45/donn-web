using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.Models.Navigation
{
    public class DropdownNavigationItem : INavigationItem
    {
        public int? Id
        {
            get;
            set;
        }

        public string DisplayText { get; set; }
        public List<DropdownItem> ItemCollection {get;set;} 

    }

    public class DropdownItem
    {
        public string DisplayText{get;set;}
        public string Action{get;set;}
    }

}