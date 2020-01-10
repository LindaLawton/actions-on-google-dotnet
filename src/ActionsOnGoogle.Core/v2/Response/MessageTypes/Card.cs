using System.Collections.Generic;
using ActionsOnGoogle.Core.v2.Response.MessageTypes;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Response
{
    public class Card : IMessageType
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }
        [JsonProperty("imageUri", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUri { get; set; }
        [JsonProperty("buttons", NullValueHandling = NullValueHandling.Ignore)]
        public List<Button> Buttons { get; set; }
        
        public class Button
        {
            [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
            public string Text { get; set; }
            [JsonProperty("postback", NullValueHandling = NullValueHandling.Ignore)]
            public string Postback { get; set; }
        }
    }
}