using DonnAdapter.Adaptor;
using DonnBusiness.BusinessLogic.Implementations;
using DonnBusiness.BusinessLogic.Interface;
using DonnDomain.Interfaces;
using DonnWeb.UIMappers;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DonnWeb.IoC
{
    public static class IoCContainer
    {

        public static Container ContainerContext = new Container();

        public static void InitializeContainer()
        {            
            ContainerContext.Register<INavigationAdaptor, StaticNavigationAdaptor>(Lifestyle.Singleton);
            ContainerContext.Register<INavigationLogic, NavigationLogic>(Lifestyle.Singleton);
            ContainerContext.Register<IScoreLogic, ScoreLogic>(Lifestyle.Singleton);
        }
         
    }
}