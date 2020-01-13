
using ActionsOnGoogle.Core.v2.Request;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Response
{
    public interface IResponse
    {
        [JsonProperty("responseId")]
        string ResponseId { get; set; }

        [JsonProperty("queryResult")] 
        QueryResult QueryResult { get; set; }

        [JsonProperty("webhookStatus")]
        WebhookStatus WebhookStatus { get; set; }

        [JsonProperty("session")] 
        string Session { get; set; } 
    }


    public  class FulfilmentResponse
    {
        [JsonProperty("fulfillmentMessages")]
        public FulfillmentMessage[] FulfillmentMessages { get; set; }
        
    }

    public class WebhookStatus
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)] 
        public int? Code { get; set; }
        
        [JsonProperty("message")] 
        public string Message { get; set; }
        
    }

    /*
    {
    "responseId": "591a711d-59c9-4b78-81ca-039180b84f61-b4ef8d5f",
    "queryResult": {
        "queryText": "what time is it",
        "parameters": {
            "geo-city": "New York"
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
        "intent": {
            "name": "projects/test-ygatno/agent/intents/9960a352-1b0f-43cd-819c-2ae0996a8b64",
            "displayName": "Time"
        },
        "intentDetectionConfidence": 0.6727639,
        "diagnosticInfo": {
            "webhook_latency_ms": 617
        },
        "languageCode": "en"
    },
    "webhookStatus": {
        "code": 5,
        "message": "Webhook call failed. Error: NOT_FOUND."
    }
     }
    */
   
    
    
}