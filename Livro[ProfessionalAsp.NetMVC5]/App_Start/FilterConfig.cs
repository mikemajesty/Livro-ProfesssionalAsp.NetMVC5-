using System.Web;
using System.Web.Mvc;

namespace Livro_ProfessionalAsp.NetMVC5_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
