using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace tutorial_6_angular_and_csharpe
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
           routes.MapRoute(
                            name: "Default",
                            url: "{*anything}",
                            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                        );
        }
    }
}