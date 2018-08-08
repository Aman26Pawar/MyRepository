using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPDemo1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Movies", "Movies/{name}", 
                defaults: new { 
                        Controller = "Movies",
                        action = "SearchMovie",
                        name =  UrlParameter.Optional}
                );

            routes.MapRoute(
                "Process",
                "Process/{action}/{id}",
                defaults: new { Controller = "Process", action="List"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
