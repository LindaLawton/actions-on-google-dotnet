using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Request
{
    public class FulfillmentMessage
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text Text { get; set; }
    }
}