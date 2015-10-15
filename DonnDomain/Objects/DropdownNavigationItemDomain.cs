using DonnDomain.Objects.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnDomain.Objects
{
   public class DropdownNavigationItemDomain : INavigationItemDomain
    {
        public int Id
        {get;set;}

        public string DisplayText { get; set; }
        public List<DropdownItemDomain> ItemCollection { get; set; }

    }

    public class DropdownItemDomain
    {
        public string DisplayText { get; set; }
        public string Action { get; set; }
    }

}
