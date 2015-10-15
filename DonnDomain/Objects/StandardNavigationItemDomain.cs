using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnDomain.Objects
{
    public class StandardNavigationItemDomain : Interface.INavigationItemDomain
    {

        public int Id { get; set; }
        public string Action { get; set; }
        public string ClassOverride { get; set; }
        public string DisplayText { get; set; }
    }
}
