using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonnDomain.Interfaces;
using DonnDomain.Objects;
using DonnDomain.Objects.Interface;
namespace DonnAdapter.Adaptor
{
    public class StaticNavigationAdaptor : INavigationAdaptor
    {

        private static IEnumerable<INavigationItemDomain> StaticResource;

        public StaticNavigationAdaptor()
        {

            StaticResource = new List<INavigationItemDomain>()
            {
                new StandardNavigationItemDomain() {Id = 1},
                new StandardNavigationItemDomain() {Id = 2}
            };
        }

        public IEnumerable<INavigationItemDomain> GetNavigationItemsFromRepository()
        {
            IEnumerable<INavigationItemDomain> items = new List<INavigationItemDomain>() 
            {
                new StandardNavigationItemDomain() { DisplayText = "Main Link 1", Id = 1, Action="/"  },
                new StandardNavigationItemDomain() { DisplayText = "Main Link 2", Id = 2, Action="/about"  },
                new StandardNavigationItemDomain() { DisplayText = "Main Link 3", Id = 3, Action="/more/stuff"  },
                new DropdownNavigationItemDomain() { 
                    DisplayText="Dropdown Link 4", ItemCollection = new List<DropdownItemDomain>() 
                { 
                     new DropdownItemDomain() {DisplayText = "Sub Item 1", Action="/sub-action"},
                     new DropdownItemDomain() {DisplayText = "Sub Item 2", Action="/sub-action-1"}
                }
               },
                new DropdownNavigationItemDomain() { 
                    DisplayText="Dropdown Link 5", ItemCollection = new List<DropdownItemDomain>() 
                { 
                     new DropdownItemDomain() {DisplayText = "Sub Item 3", Action="/sub-action"},
                     new DropdownItemDomain() {DisplayText = "Sub Item 4", Action="/sub-action-1"},
                      new DropdownItemDomain() {DisplayText = "Sub Item 5", Action="/sub-action-1"}
                }
               }
            };
            return items;
        }

        public INavigationItemDomain GetItemFromRepository(int NavigationItemId)
        {
           return StaticResource.SingleOrDefault(x => x.Id == NavigationItemId);

            //foreach (INavigationItemDomain y in StaticResource)
            //{
            //    if (y.Id == NavigationItemId)
            //    {
            //        return y;
            //    }
            //}
            //return null;
        }
    }
}
