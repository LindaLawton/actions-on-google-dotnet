using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.Requests
{

    //public class Intent
    //{
    //    [JsonProperty("id")]
    //    public string Id { get; set; }
    //    [JsonProperty("timestamp")]
    //    public DateTime Timestamp { get; set; }
    //    [JsonProperty("lang")]
    //    public string Lang { get; set; }
    //    [JsonProperty("result")]
    //    public IntentResult Result { get; set; }
    //    [JsonProperty("status")]
    //    public IntentStatus Status { get; set; }
    //    [JsonProperty("sessionId")]
    //    public string SessionId { get; set; }
    //}

    //public class IntentResult
    //{
    //    /// <summary>
    //    /// Agent
    //    /// </summary>
    //    [JsonProperty("source")]
    //    public string Source { get; set; }

    //    /// <summary>
    //    /// Users orignal query to the agent
    //    /// </summary>
    //    [JsonProperty("resolvedQuery")]
    //    public string ResolvedQuery { get; set; }

    //    /// <summary>
    //    /// "Text defined in Dialogflow's console for the intent that was matched
    //    /// </summary>
    //    [JsonProperty("speech")]
    //    public string Speech { get; set; }

    //    /// <summary>
    //    /// Matched Dialogflow intent action name
    //    /// </summary>
    //    [JsonProperty("action")]
    //    public string Action { get; set; }
    //    [JsonProperty("actionIncomplete")]
    //    public bool ActionIncomplete { get; set; }
    //    [JsonProperty("parameters")]
    //    public IntentResultParameters Parameters { get; set; }
    //    [JsonProperty("contexts")]
    //    public List<Context> Contexts { get; set; }
    //    [JsonProperty("metadata")]
    //    public Metadata Metadata { get; set; }
    //    [JsonProperty("fulfillment")]
    //    public Fulfillment Fulfillment { get; set; }
    //    [JsonProperty("score")]
    //    public long Score { get; set; }
    //}

    //public class IntentStatus
    //{
    //    [JsonProperty("code")]
    //    public int Code { get; set; }
    //    [JsonProperty("errorType")]
    //    public string ErrorType { get; set; }
    //}




    //public class IntentResultParameters
    //{
    //    [JsonProperty("category.original")]
    //    public string CategoryOriginal { get; set; }
    //    [JsonProperty("category")]
    //    public string Category { get; set; }
    //}

    //public class Context
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("parameters")]
    //    public IntentResultParameters Parameters { get; set; }
    //    [JsonProperty("lifespan")]
    //    public int Lifespan { get; set; }
    //}

    //public class Metadata
    //{
    //    [JsonProperty("intentId")]
    //    public string IntentId { get; set; }
    //    [JsonProperty("webhookUsed")]
    //    public string WebhookUsed { get; set; }
    //    [JsonProperty("webhookForSlotFillingUsed")]
    //    public string WebhookForSlotFillingUsed { get; set; }

    //    /// <summary>
    //    /// Name of Matched Dialogflow Intent
    //    /// </summary>
    //    [JsonProperty("intentName")]
    //    public string IntentName { get; set; }
    //}

    //public class Message
    //{
    //    [JsonProperty("type")]
    //    public int Type { get; set; }

    //    /// <summary>
    //    /// Text defined in Dialogflow's console for the intent that was matched
    //    /// </summary>
    //    [JsonProperty("speech")]
    //    public string Speech { get; set; }
    //}

    //public class Fulfillment
    //{
    //    /// <summary>
    //    /// Text defined in Dialogflow's console for the intent that was matched
    //    /// </summary>
    //    [JsonProperty("speech")]
    //    public string Speech { get; set; }

    //    [JsonProperty("messages")]
    //    public List<Message> Messages { get; set; }
    //}






}
