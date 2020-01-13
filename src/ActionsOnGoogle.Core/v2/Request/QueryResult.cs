using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActionsOnGoogle.Core.v2.Request
{
    public class QueryResult
    {
        [JsonProperty("queryText", NullValueHandling = NullValueHandling.Ignore)] 
        public string QueryText { get; set; }
            
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)] 
        public string Action { get; set; }
            
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)] 
        public JObject Parameters { get; set; }
            
        [JsonProperty("allRequiredParamsPresent", NullValueHandling = NullValueHandling.Ignore)] 
        public bool AllRequiredParamsPresent { get; set; }
            
        [JsonProperty("fulfillmentMessages", NullValueHandling = NullValueHandling.Ignore)] 
        public List<FulfillmentMessage> FulfillmentMessages { get; set; }
            
        [JsonProperty("outputContexts", NullValueHandling = NullValueHandling.Ignore)] 
        public List<OutputContext> OutputContexts { get; set; }
            
        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)] 
        public Intent Intent { get; set; }
            
        [JsonProperty("intentDetectionConfidence", NullValueHandling = NullValueHandling.Ignore)] 
        public long IntentDetectionConfidence { get; set; }
            
        [JsonProperty("languageCode", NullValueHandling = NullValueHandling.Ignore)] 
        public string LanguageCode { get; set; }
    }
}