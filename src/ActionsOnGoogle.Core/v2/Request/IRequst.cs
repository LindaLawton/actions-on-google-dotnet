
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Request
{
    public interface IRequest
    {
        [JsonProperty("responseId")]
        string ResponseId { get; set; }

        [JsonProperty("queryResult")] 
        QueryResult QueryResult { get; set; }

        [JsonProperty("originalDetectIntentRequest")]
        OriginalDetectIntentRequest OriginalDetectIntentRequest { get; set; }

        [JsonProperty("session")] 
        string Session { get; set; }
    }
    
    public partial class OriginalDetectIntentRequest
    {
        [JsonProperty("payload")]
        public object Payload { get; set; }
    }
    
    
    
    //{
    /*"responseId": "591a711d-59c9-4b78-81ca-039180b84f61-b4ef8d5f",
    "queryResult": {
        "queryText": "what time is it",
        "parameters": {
            "geo-city": ""
        },
        "allRequiredParamsPresent": true,
        "fulfillmentText": "ok",
        "fulfillmentMessages": [
        {
            "text": {
                "text": [
                "ok"
                    ]
            }
        }
        ],
        "outputContexts": [
        {
            "name": "projects/test-ygatno/agent/sessions/629b8a09-0800-d106-48cf-afe61fd6462d/contexts/__system_counters__",
            "parameters": {
                "no-input": 0,
                "no-match": 0,
                "geo-city": "",
                "geo-city.original": ""
            }
        }
        ],
        "intent": {
            "name": "projects/test-ygatno/agent/intents/9960a352-1b0f-43cd-819c-2ae0996a8b64",
            "displayName": "Time"
        },
        "intentDetectionConfidence": 0.6727639,
        "languageCode": "en"
    },
    "originalDetectIntentRequest": {
        "payload": {}
    },
    "session": "projects/test-ygatno/agent/sessions/629b8a09-0800-d106-48cf-afe61fd6462d"
    }*/
    
    
    
}