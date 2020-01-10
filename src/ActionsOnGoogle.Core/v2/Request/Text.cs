using System.Collections.Generic;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Request
{
    public class Text
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> text { get; set; }
    }
}