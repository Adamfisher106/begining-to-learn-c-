using System.Web;
using System.Web.Mvc;

namespace tutorial_6_angular_and_csharpe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
