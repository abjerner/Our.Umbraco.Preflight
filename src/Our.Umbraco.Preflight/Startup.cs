using Our.Umbraco.Preflight.Dashboard;
using Skybrud.Umbraco.Dashboard;
using Umbraco.Core;

namespace Our.Umbraco.Preflight {
    
    public class Startup : ApplicationEventHandler {

        protected override void ApplicationStarting(UmbracoApplicationBase umbraco, ApplicationContext context) {

            DashboardContext.Current.Plugins.Add(new PreflightDashboardPlugin());

        }

    }

}