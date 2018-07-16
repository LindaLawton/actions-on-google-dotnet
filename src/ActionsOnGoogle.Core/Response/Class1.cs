using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core
{
    public class Messages
    {
        public int type { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string imageUrl { get; set; }
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

    public class Data
    {
        public Google google { get; set; }
        public Facebook facebook { get; set; }
        public Slack slack { get; set; }
    }

    public class Parameters
    {
        public string param { get; set; }
    }

    public class ContextOut
    {
        public string name { get; set; }
        public int lifespan { get; set; }
        public Parameters parameters { get; set; }
    }

    public class FollowupEvent
    {
        public string name { get; set; }
        public Parameters parameters { get; set; }
    }

    public class IntentResponse
    {
        [JsonProperty("category.original")]
        public string conversationToken { get; set; }
        public string speech { get; set; }
        public string displayText { get; set; }
        public Messages messages { get; set; }
        public Data data { get; set; }
        public List<ContextOut> contextOut { get; set; }
        public string source { get; set; }
        public FollowupEvent followupEvent { get; set; }
    }
}
