using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Request
{
   
    public class Text
    {
        public List<string> text { get; set; }
    }

    public class FulfillmentMessage
    {
        public Text text { get; set; }
    }

    public class Parameters
    {
        [JsonProperty("category.original")]
        public string categoryoriginal { get; set; }
        [JsonProperty("category")]
        public string category { get; set; }
    }

    public class OutputContext
    {
        public string name { get; set; }
        public Parameters parameters { get; set; }
        public long? lifespanCount { get; set; }
    }

    public class Intent
    {
        public string name { get; set; }
        public string displayName { get; set; }
    }

    public class QueryResult
    {
        public string queryText { get; set; }
        public string action { get; set; }
        public Parameters parameters { get; set; }
        public bool allRequiredParamsPresent { get; set; }
        public List<FulfillmentMessage> fulfillmentMessages { get; set; }
        public List<OutputContext> outputContexts { get; set; }
        public Intent intent { get; set; }
        public long intentDetectionConfidence { get; set; }
        public string languageCode { get; set; }
    }

    public class Capability
    {
        public string name { get; set; }
    }

    public class Surface
    {
        public List<Capability> capabilities { get; set; }
    }

    public class RawInput
    {
        public string query { get; set; }
        public string inputType { get; set; }
    }

    public class Argument
    {
        public string rawText { get; set; }
        public string textValue { get; set; }
        public string name { get; set; }
    }

    public class Input
    {
        public List<RawInput> rawInputs { get; set; }
        public List<Argument> arguments { get; set; }
        public string intent { get; set; }
    }

    public class User
    {
        public DateTime lastSeen { get; set; }
        public string locale { get; set; }
        public string userId { get; set; }
    }

    public class Conversation
    {
        public string conversationId { get; set; }
        public string type { get; set; }
        public string conversationToken { get; set; }
    }

    public class Capability2
    {
        public string name { get; set; }
    }

    public class AvailableSurface
    {
        public List<Capability2> capabilities { get; set; }
    }

    public class Payload
    {
        public bool isInSandbox { get; set; }
        public Surface surface { get; set; }
        public string requestType { get; set; }
        public List<Input> inputs { get; set; }
        public User user { get; set; }
        public Conversation conversation { get; set; }
        public List<AvailableSurface> availableSurfaces { get; set; }
    }

    public class OriginalDetectIntentRequest
    {
        public string source { get; set; }
        public string version { get; set; }
        public Payload payload { get; set; }
    }

    public class FulfillmentRequst
    {
        public string responseId { get; set; }
        public QueryResult queryResult { get; set; }
        public OriginalDetectIntentRequest originalDetectIntentRequest { get; set; }
        public string session { get; set; }
    }
}