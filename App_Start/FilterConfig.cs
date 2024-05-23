using System.Web;
using System.Web.Mvc;

namespace MiniProject_StudentPlacement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
