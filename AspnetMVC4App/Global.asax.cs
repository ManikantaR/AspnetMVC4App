using AspnetMVC4App.Migrations;
using OdeToCodeApp.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace AspnetMVC4App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var migration = new DbMigrator(new Configuration());
            migration.Update();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
