using System.Web;
using System.Web.Mvc;

namespace Miniproyecto___Bertoni_Solutions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
