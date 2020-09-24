using System.Web;
using System.Web.Mvc;

namespace Assignment1_n01248350_AsiaLevesqueGault
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
