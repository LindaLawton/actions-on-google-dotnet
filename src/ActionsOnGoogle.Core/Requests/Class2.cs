using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.Requests
{

    //public class Capability
    //{
    //    public string name { get; set; }
    //}

    //public class Surface
    //{
    //    public List<Capability> capabilities { get; set; }
    //}

    //public class RawInput
    //{
    //    public string query { get; set; }
    //    public string inputType { get; set; }
    //}

    //public class Argument
    //{
    //    public string rawText { get; set; }
    //    public string textValue { get; set; }
    //    public string name { get; set; }
    //}

    //public class Input
    //{
    //    public List<RawInput> rawInputs { get; set; }
    //    public List<Argument> arguments { get; set; }
    //    public string intent { get; set; }
    //}

    //public class User
    //{
    //    public DateTime lastSeen { get; set; }
    //    public string locale { get; set; }
    //    public string userId { get; set; }
    //}

    //public class Conversation
    //{
    //    public string conversationId { get; set; }
    //    public string type { get; set; }
    //    public string conversationToken { get; set; }
    //}

    //public class Capability2
    //{
    //    public string name { get; set; }
    //}

    //public class AvailableSurface
    //{
    //    public List<Capability2> capabilities { get; set; }
    //}

    //public class Data
    //{
    //    public bool isInSandbox { get; set; }
    //    public Surface surface { get; set; }
    //    public string requestType { get; set; }
    //    public List<Input> inputs { get; set; }
    //    public User user { get; set; }
    //    public Conversation conversation { get; set; }
    //    public List<AvailableSurface> availableSurfaces { get; set; }
    //}

    //public class OriginalRequest
    //{
    //    public string source { get; set; }
    //    public string version { get; set; }
    //    public Data data { get; set; }
    //}
    ////    public class Parameters
    ////{
    ////    [JsonProperty("category.original")]
    ////    public string CategoryOriginal { get; set; }
    ////    public string category { get; set; }
    ////}

    //public class Context
    //{
    //    public string name { get; set; }
    //    public Parameters parameters { get; set; }
    //    public int lifespan { get; set; }
    //}

    //public class Prompt
    //{
    //    public string lang { get; set; }
    //    public string value { get; set; }
    //}

    //public class MatchedParameter
    //{
    //    public bool required { get; set; }
    //    public string dataType { get; set; }
    //    public string name { get; set; }
    //    public string value { get; set; }
    //    public List<Prompt> prompts { get; set; }
    //}

    //public class Metadata
    //{
    //    public List<MatchedParameter> matchedParameters { get; set; }
    //    public string intentName { get; set; }
    //    public bool isResponseToSlotfilling { get; set; }
    //    public string intentId { get; set; }
    //    public string webhookUsed { get; set; }
    //    public string webhookForSlotFillingUsed { get; set; }
    //    public int nluResponseTime { get; set; }
    //}

    //public class Message
    //{
    //    public int type { get; set; }
    //    public string speech { get; set; }
    //}

    //public class Fulfillment
    //{
    //    public string speech { get; set; }
    //    public List<Message> messages { get; set; }
    //}

    //public class Result
    //{
    //    public string source { get; set; }
    //    public string resolvedQuery { get; set; }
    //    public string speech { get; set; }
    //    public string action { get; set; }
    //    public bool actionIncomplete { get; set; }
    //    public Parameters parameters { get; set; }
    //    public List<Context> contexts { get; set; }
    //    public Metadata metadata { get; set; }
    //    public Fulfillment fulfillment { get; set; }
    //    public long score { get; set; }
    //}

    //public class Status
    //{
    //    public int code { get; set; }
    //    public string errorType { get; set; }
    //}

    //public class RootObject
    //{
    //    public OriginalRequest originalRequest { get; set; }
    //    public string id { get; set; }
    //    public DateTime timestamp { get; set; }
    //    public string lang { get; set; }
    //    public Result result { get; set; }
    //    public Status status { get; set; }
    //    public string sessionId { get; set; }
    //}
}