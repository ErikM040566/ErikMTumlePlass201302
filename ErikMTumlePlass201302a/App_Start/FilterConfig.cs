using System.Web;
using System.Web.Mvc;

namespace ErikMTumlePlass201302a
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}