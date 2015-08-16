using System;
using System.Linq;
using Our.Umbraco.Preflight.Checks;
using Our.Umbraco.Preflight.Groups;
using Skybrud.WebApi.Json;
using Umbraco.Web.WebApi;

namespace Our.Umbraco.Preflight.Controllers.Api {
    
    [JsonOnlyConfiguration]
    public class PreflightController : UmbracoAuthorizedApiController {

        public object GetChecks() {
            return PreflightContext.Current.Groups.List;
        }

        public object GetCheckResult(string groupAlias, string id) {

            // TODO: Validate the ID before parsing (or handle exception)
            Guid guid = Guid.Parse(id);

            // Get the group
            PreflightGroup group = PreflightContext.Current.Groups.GetGroup(groupAlias);

            // Get the check
            ICheck check = group.Checks.FirstOrDefault(x => x.Id == guid);

            CheckResult result = check.Check();

            return result;
        
        }

    }

}