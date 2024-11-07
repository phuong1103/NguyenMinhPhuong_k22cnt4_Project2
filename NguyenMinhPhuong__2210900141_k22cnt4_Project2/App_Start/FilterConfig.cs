using System.Web;
using System.Web.Mvc;

namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
