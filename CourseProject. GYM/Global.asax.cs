using CourseProject.GYM.App_Start;

using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CourseProject.GYM
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DependencyInjectionConfig.RegisterDependencies();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
