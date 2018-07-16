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
        public string name { get; set; }
        public string languageCode { get; set; }
        public Parameters2 parameters { get; set; }
    }

    public class FulfillmentResponse
    {
        //https://dialogflow.com/docs/reference/api-v2/rest/Shared.Types/WebhookResponse#SCHEMA_REPRESENTATION


        /// <summary>
        /// Optional. The text to be shown on the screen. This value is passed directly to QueryResult.fulfillment_text.
        /// </summary>
        [JsonProperty("fulfillmentText")]
        public string FulfillmentText { get; set; }

        /// <summary>
        /// Optional. The collection of rich messages to present to the user. This value is passed directly to QueryResult.fulfillment_messages.
        /// </summary>
        [JsonProperty("fulfillmentMessages")]
        public List<FulfillmentMessage> FulfillmentMessages { get; set; }

        /// <summary>
        /// Optional. This value is passed directly to QueryResult.webhook_source.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }


        /// <summary>
        /// This field can be used for Actions on Google responses.
        /// </summary>
        [JsonProperty("payload")]
        public Payload Payload { get; set; }

        /// <summary>
        /// Optional. The collection of output contexts. This value is passed directly to QueryResult.output_contexts.
        /// </summary>
        [JsonProperty("outputContexts")]
        public List<OutputContext> OutputContexts { get; set; }

        /// <summary>
        /// Optional. Makes the platform immediately invoke another sessions.detectIntent call internally with the specified event as input.
        /// </summary>
        [JsonProperty("followupEventInput")]
        public FollowupEventInput FollowupEventInput { get; set; }
    }
}