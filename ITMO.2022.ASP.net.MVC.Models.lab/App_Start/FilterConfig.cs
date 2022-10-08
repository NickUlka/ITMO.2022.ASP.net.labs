using System.Web;
using System.Web.Mvc;

namespace ITMO._2022.ASP.net.MVC.Models.lab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
