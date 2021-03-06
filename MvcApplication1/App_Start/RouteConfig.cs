﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DonnWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "NavigationItem", 
                url: "NavigationItem/{Id}", 
                defaults: new { controller = "Navigation", action = "LoadNavigationItem", Id = UrlParameter.Optional }
                );

            routes.MapRoute(name: "BlogItem", url: "Blog/Get/{uri}", defaults: new { controller = "Blog", action="ByUri", uri = UrlParameter.Optional});
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "LoadHomePage", id = UrlParameter.Optional }
            );    
        }
    }
}