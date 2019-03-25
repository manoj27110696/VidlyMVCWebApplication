using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidlyMVCWebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            //routes.MapRoute( 
            //      name:"MoviesByReleaseYr",
            //      url: "Movies/MoviesByReleaseYr/{Year}/{Month}",
            //      defaults: new { controller="Movies",action="MoviesByReleaseYr"},
            //      constraints:new {Year=@"2015|2016",Month=@"\d{2}"}
            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
