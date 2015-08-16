using System;
using Newtonsoft.Json;

namespace Our.Umbraco.Preflight.Checks {
    
    public interface ICheck {
        
        [JsonProperty("id")]
        Guid Id { get; }

        [JsonProperty("name")]
        string Name { get; }

        [JsonProperty("description")]
        string Description { get; }

        [JsonProperty("group")]
        string Group { get; }

        [JsonProperty("canRectify")]
        bool CanRectify { get; }

        CheckResult Check();

        RectifyResult Rectify();
    
    }

}