using DonnAdapter.Adaptor;
using DonnBusiness.BusinessLogic.Cache;
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
            
            // Adaptors 
            ContainerContext.Register<INavigationAdaptor, StaticNavigationAdaptor>(Lifestyle.Singleton);
            ContainerContext.Register<IScoreAdaptor, ScoreAdaptor>(Lifestyle.Singleton);
            ContainerContext.Register<IBlogAdaptor, BlogAdaptor>(Lifestyle.Singleton);

            // Mappers
            ContainerContext.Register<ITotalScoreMapper, TotalScoreMapper>(Lifestyle.Singleton);
            ContainerContext.Register<IBlogItemMapper, BlogItemMapper>(Lifestyle.Singleton);

            // Logic
            ContainerContext.Register<INavigationLogic, NavigationLogic>(Lifestyle.Singleton);
            ContainerContext.Register<IScoreLogic, ScoreLogic>(Lifestyle.Singleton);
            ContainerContext.Register<IBlogLogic, BlogLogic>(Lifestyle.Singleton);            
            
           
            // Cache switch
            ContainerContext.Register<ICacheService, InMemoryCache>(Lifestyle.Singleton);
        }
         
    }
}