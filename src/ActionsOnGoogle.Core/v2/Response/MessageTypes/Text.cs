using ActionsOnGoogle.Core.v2.Response.MessageTypes;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Response
{
    public class Text : IMessageType
    {
        [JsonProperty("text")]
        public string[] TextText { get; set; }
    }
}