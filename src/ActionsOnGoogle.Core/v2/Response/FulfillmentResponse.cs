using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Response
{
    public class Button
    {
        public string text { get; set; }
        public string postback { get; set; }
    }

    public class Card
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public string imageUri { get; set; }
        public List<Button> buttons { get; set; }
    }

    public class FulfillmentMessage
    {
        public Card card { get; set; }
    }

    public class SimpleResponse
    {
        public string textToSpeech { get; set; }
    }

    public class Item
    {
        public SimpleResponse simpleResponse { get; set; }
    }

    public class RichResponse
    {
        public List<Item> items { get; set; }
    }

    public class Google
    {
        public bool expectUserResponse { get; set; }
        public RichResponse richResponse { get; set; }
        public SystemIntent systemIntent { get; set; }
    }

    public class Facebook
    {
        public string text { get; set; }
    }

    public class Slack
    {
        public string text { get; set; }
    }

    public class Payload
    {
        public Google google { get; set; }
        public Facebook facebook { get; set; }
        public Slack slack { get; set; }
    }

    public class Parameters
    {
        public string param { get; set; }
    }

    public class OutputContext
    {
        public string name { get; set; }
        public long lifespanCount { get; set; }
        public Parameters parameters { get; set; }
    }

    public class Parameters2
    {
        public string param { get; set; }
    }

    
    public class FollowupEventInput
    {
        /// <summary>
        /// Required. The unique identifier of the context. 
        /// Format: projects/<Project ID>/agent/sessions/<Session ID>/contexts/<Context ID>
        /// </summary>
        [JsonProperty("name" , NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Optional. The number of conversational query requests after which the context expires. 
        /// If set to 0 (the default) the context expires immediately. Contexts expire automatically 
        /// after 10 minutes even if there are no matching queries.
        /// </summary>
        [JsonProperty("lifespanCount", NullValueHandling = NullValueHandling.Ignore)]
        public int LifespanCount { get; set; } = 0;

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Parameters Parameters { get; set; }
    }

    /// <summary>
    /// The response message for a webhook call.
    /// 
    /// https://dialogflow.com/docs/reference/api-v2/rest/Shared.Types/WebhookResponse#SCHEMA_REPRESENTATION
    /// </summary>
    public class FulfillmentResponse
    {
        
        /// <summary>
        /// Optional. The text to be shown on the screen. This value is passed directly to QueryResult.fulfillment_text.
        /// </summary>
        [JsonProperty("fulfillmentText", NullValueHandling = NullValueHandling.Ignore)]
        public string FulfillmentText { get; set; }

        /// <summary>
        /// Optional. The collection of rich messages to present to the user. This value is passed directly to QueryResult.fulfillment_messages.
        /// </summary>
        [JsonProperty("fulfillmentMessages", NullValueHandling = NullValueHandling.Ignore)]
        public List<FulfillmentMessage> FulfillmentMessages { get; set; }

        /// <summary>
        /// Optional. This value is passed directly to QueryResult.webhook_source.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }


        /// <summary>
        /// This field can be used for Actions on Google responses.
        /// </summary>
        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public Payload Payload { get; set; }

        /// <summary>
        /// Optional. The collection of output contexts. This value is passed directly to QueryResult.output_contexts.
        /// </summary>
        [JsonProperty("outputContexts", NullValueHandling = NullValueHandling.Ignore)]
        public List<OutputContext> OutputContexts { get; set; }

        /// <summary>
        /// Optional. Makes the platform immediately invoke another sessions.detectIntent 
        /// call internally with the specified event as input.
        /// </summary>
        [JsonProperty("followupEventInput", NullValueHandling = NullValueHandling.Ignore)]
        public FollowupEventInput FollowupEventInput { get; set; }
    }
}