using System.Web;
using System.Web.Mvc;

namespace Atendimento.Hospitalar
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
