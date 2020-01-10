using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Response
{
    public class FulfillmentMessage
    {
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Card Card { get; set; }
        
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text Text { get; set; }
    }
}