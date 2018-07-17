using ActionsOnGoogle.Core.v2.Response;
using System.Collections.Generic;

namespace WebApplicationAPI.Helpers
{
    public class Responsebuilder
    {
        public static FulfillmentResponse GetSimpleResponse(string text)
        {
            return new FulfillmentResponse
            {
                Payload = new ActionsOnGoogle.Core.v2.Response.Payload()
                {
                    google = new ActionsOnGoogle.Core.v2.Response.Google()
                    {
                        expectUserResponse = true,
                        richResponse = new ActionsOnGoogle.Core.v2.Response.RichResponse()
                        {
                            items = new List<ActionsOnGoogle.Core.v2.Response.Item>()
                            {
                                new ActionsOnGoogle.Core.v2.Response.Item()
                                {
                                    simpleResponse =
                                        new ActionsOnGoogle.Core.v2.Response.SimpleResponse()
                                        {
                                            textToSpeech = text
                                        }
                                }
                            }
                        }
                    },
                }
            };

        }


        public static FulfillmentResponse GetHelperResponse(string helloResponse)
        {
            var simple = Responsebuilder.GetSimpleResponse(helloResponse);
            simple.Payload.google.systemIntent = new SystemIntent()
            {
                intent = "actions.intent.OPTION",
                data = new Data()
                {
                    type = "type.googleapis.com/google.actions.v2.OptionValueSpec",
                    listSelect = new Data.ListSelect()
                    {
                        title = "hello options ",
                        items = new List<Data.ListSelect.Item>()
                        {
                            new Data.ListSelect.Item()
                            {
                                optionInfo = new OptionInfo() {key = "history"}, 
                                description = "first description",
                                title = "History",
                                image = new Image()
                                {
                                    url = "https://developers.google.com/actions/images/badges/XPM_BADGING_GoogleAssistant_VER.png",
                                    accessibilityText = "first alt"
                                }
                            },
                            new Data.ListSelect.Item()
                            {
                                optionInfo = new OptionInfo() {key = "headquarters"},
                                description = "scond description",
                                title = "Headquarters",
                                image = new Image()
                                {
                                    url = "https://lh3.googleusercontent.com/Nu3a6F80WfixUqf_ec_vgXy_c0-0r4VLJRXjVFF_X_CIilEu8B9fT35qyTEj_PEsKw",
                                    accessibilityText = "first alt"
                                }
                            }
                        }
                    }

                }
            };

            return simple;
        }
    }
}
