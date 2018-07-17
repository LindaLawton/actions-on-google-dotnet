using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ActionsOnGoogle.Core.v2.Response
{
  public class SimpleResponseResponse
    {
        [JsonProperty("data")]
        public Payload payload { get; set; }

        public class Payload
        {
            [JsonProperty("google")]
            public Google google { get; set; }

            public class Google
            {
                public bool expectUserResponse { get; set; }
                public RichResponse richResponse { get; set; }
                public class RichResponse
                {
                    public List<Item> items { get; set; }
                    public class Item
                    {
                        public SimpleResponse simpleResponse { get; set; }
                        public class SimpleResponse
                        {
                            public string textToSpeech { get; set; }
                        }
                    }
                }
            }

        }
    }
}
