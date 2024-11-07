using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Thêm đường dẫn cho AdminController
            routes.MapRoute(
                name: "NMPAdmin",
                url: "NMPAdmin/{action}/{id}",
                defaults: new { controller = "NMPAdmin", action = "nmpIndex", id = UrlParameter.Optional }
            );

            // Đường dẫn mặc định
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "NmpIndex", id = UrlParameter.Optional }
            );
             routes.MapRoute(
            name: "Contact",
            url: "contact",
            defaults: new { controller = "NmpContact", action = "NmpIndex" }
        );  
        }
    }
}