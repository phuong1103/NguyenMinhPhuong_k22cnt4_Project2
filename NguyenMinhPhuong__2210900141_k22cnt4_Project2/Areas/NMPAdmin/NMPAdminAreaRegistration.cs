using System.Web.Mvc;

namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2.Areas.NMPAdmin
{
    public class NMPAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NMPAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NMPAdmin_default",
                "NMPAdmin/{controller}/{action}/{id}",
                new { action = "nmpIndex", id = UrlParameter.Optional }
            );
        }
    }
}