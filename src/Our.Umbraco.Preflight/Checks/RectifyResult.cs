using Newtonsoft.Json;

namespace Our.Umbraco.Preflight.Checks {
    
    public class RectifyResult {

        [JsonProperty("status")]
        public RectifyResultStatus Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    
    }

}