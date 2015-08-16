using System.Collections.Generic;
using Skybrud.Umbraco.Dashboard.Model;
using Skybrud.Umbraco.Dashboard.Model.Properties;
using Skybrud.Umbraco.Dashboard.Plugins;

namespace Our.Umbraco.Preflight.Dashboard {
    
    public class PreflightDashboardPlugin : DashboardPluginBase {

        public override void GetDashboard(string section, List<DashboardTab> tabs) {

            // Skip if not in the "developer" section
            if (section != "developer") return;

            // Add our own tab and panel
            tabs.Insert(0, new DashboardTab {
                Alias = "preflight",
                Label = "Preflight",
                Properties = new List<DashboardProperty> {
                    new DashboardProperty("Preflight", "/App_Plugins/Preflight/Views/Dashboard.html")
                }
            });

        }

    }

}