using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MathPersonMVCProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name:"Default",
                url:"{controller}/{action}/{id}", 
                defaults: new {controller="Home", action="Index", id=UrlParameter.Optional }
                );
            routes.MapRoute("Default1", "{controller}/{action}/{a}/{b}", new { }, new {a = @"^[0-9]*$", b = @"^[0-9]*$" });
            routes.MapRoute("Default2", "{controller}/{action}/{n}", new { },  new { n = @"^[0-9]*$" });
            routes.MapRoute("Default3", "{controller}/{action}/{year}/{month}/{date}", new { }, new { year = @"^[0-9]*$", month = @"^[0-9]*$", date = @"^[0-9]*$" });
            routes.MapRoute("Default4", "{controller}/{action}/{firstname}/{lastname}", new { });
           

        }
    }
}
