using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Response
{

    public class OptionInfo
    {
        public string key { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public string accessibilityText { get; set; }
    }

    public class Data
    {
        [JsonProperty("@type")]
        public string type { get; set; }
        [JsonProperty("listSelect")]
        public ListSelect listSelect { get; set; }

        public class ListSelect
        {
            public string title { get; set; }
            public List<Item> items { get; set; }

            public class Item
            {
                public OptionInfo optionInfo { get; set; }
                public string description { get; set; }
                public Image image { get; set; }
                public string title { get; set; }
            }

        }
    }

    public class SystemIntent
    {
        public string intent { get; set; }
        public Data data { get; set; }
    }

    public class HelperResponse
    {
        public SystemIntent systemIntent { get; set; }
    }

    

    
}
