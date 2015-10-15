using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using DonnDomain.Interfaces;
using DonnAdapter.Adaptor;
using DonnBusiness.BusinessLogic.Interface;
using DonnBusiness.BusinessLogic.Implementations;
using DonnWeb.UIMappers;

namespace DonnWeb
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            IoC.IoCContainer.InitializeContainer();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(IoC.IoCContainer.ContainerContext));

           
        }
    }
}