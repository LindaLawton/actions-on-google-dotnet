using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Request
{
    public class Intent
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }
    }
}