using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Request
{
    public class OutputContext
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Parameters Parameters { get; set; }
        [JsonProperty("lifespanCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? LifespanCount { get; set; }
    }
}