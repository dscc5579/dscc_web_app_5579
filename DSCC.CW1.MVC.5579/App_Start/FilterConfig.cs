using System.Web;
using System.Web.Mvc;

namespace DSCC.CW1.MVC._5579
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
