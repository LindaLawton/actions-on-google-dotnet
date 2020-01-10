using System.Collections.Generic;
using ActionsOnGoogle.Core.v2.Response;

namespace ActionsOnGoogle.Core.v2.Helpers
{

    public static class Responsebuilder
    {
        public static FulfillmentMessage BuildTextResponse(string[] strings)
        {
            return 
                new FulfillmentMessage()
                {
                    Text = new Text()
                    {
                        TextText = strings
                    }
                };
        }

        public static FulfillmentMessage BuildCardResponse(string title = null, string subtitle = null,
            string ImageUri = null, List<Card.Button> buttons = null)
        {
            return
                new FulfillmentMessage()
                {
                    Card = new Card()
                    {
                        Title = title,
                        Subtitle = subtitle,
                        ImageUri = ImageUri ,
                        Buttons = buttons
                    }
                };
        }
    }
}
