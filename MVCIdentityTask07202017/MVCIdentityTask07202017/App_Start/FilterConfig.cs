using System.Web;
using System.Web.Mvc;

namespace MVCIdentityTask07202017
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
