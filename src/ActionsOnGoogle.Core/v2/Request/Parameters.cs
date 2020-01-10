using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Request
{
    public class Parameters
    {
        [JsonProperty("category.original")]
        public string Categoryoriginal { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
    }
}