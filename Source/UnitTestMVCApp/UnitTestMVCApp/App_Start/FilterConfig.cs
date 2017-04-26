using System.Web;
using System.Web.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace UnitTestMVCApp
{
    [ExcludeFromCodeCoverage]
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
