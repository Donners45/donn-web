using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DonnWeb.Models.Navigation;
using DonnWeb.UiControllers;
using DonnBusiness.BusinessLogic.Interface;

using DonnAdapter.Adaptor;
using DonnDomain.Interfaces;
using DonnWeb.IoC;
namespace DonnWeb.Controllers
{
    public class NavigationController : Controller
    {
        UiNavigationController _controller;

        public NavigationController()
        {
            _controller = IoCContainer.ContainerContext.GetInstance<UiNavigationController>();
        }

        // GET: /Navigation/
        public ActionResult Index()
        { 
            NavigationItemsModel test = _controller.GetNavigationModel();
            return PartialView("NavigationContentWrapper", test);
        }
    }
}
