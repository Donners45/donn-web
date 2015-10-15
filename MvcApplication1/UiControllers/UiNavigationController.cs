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

        public UiNavigationController(INavigationLogic navigationLogic, INavigationMapper mapper) 
        {
            _navigationBusiness = navigationLogic;
            _navMapper = mapper;
        }

        public NavigationItemsModel GetNavigationModel()
        {
            NavigationItemsModel model = new NavigationItemsModel(){
                ItemsInNavigation   = new List<INavigationItem>()
            };

            var items = _navigationBusiness.getNavigationItems();

            if (items != null)
            {
                var builtItems = new List<INavigationItem>();
                foreach (var item in items)
                {
                    builtItems.Add(_navMapper.MapDomainModelToUi(item));
                }
                model.ItemsInNavigation = builtItems;
            }

            return model;   
        }

    }
}