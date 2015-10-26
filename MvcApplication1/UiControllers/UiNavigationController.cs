using DonnWeb.Models.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DonnBusiness.BusinessLogic.Interface;
using DonnWeb.UIMappers;

namespace DonnWeb.UiControllers
{
    public class UiNavigationController
    {
        public INavigationLogic _navigationBusiness;
        public INavigationMapper _navMapper;

        public UiNavigationController(INavigationLogic navigationLogic) 
        {
            _navigationBusiness = navigationLogic;
        }

        public NavigationItemsModel GetNavigationModel()
        {
            NavigationItemsModel model = new NavigationItemsModel(){
                ItemsInNavigation   = new List<INavigationItem>()
            };
            
            var mapperFactory = new NavigationMapperFactory();

            var items = _navigationBusiness.getNavigationItems();

            if (items != null)
            {
                var builtItems = new List<INavigationItem>();
                foreach (var item in items)
                {
                    _navMapper = mapperFactory.GetMapperForType(item);
                    builtItems.Add(_navMapper.MapDomainModelToUi(item));
                }
                model.ItemsInNavigation = builtItems;
            }

            return model;   
        }

    }
}