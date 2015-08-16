using Newtonsoft.Json;

namespace Our.Umbraco.Preflight.Checks {
    
    public class CheckResult {
        
        [JsonProperty("status")]
        public CheckResultStatus Status { get; set; }
        
        [JsonProperty("message")]
        public string Message { get; set; }
    
    }

}