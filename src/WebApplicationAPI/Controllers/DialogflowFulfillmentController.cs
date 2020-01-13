using System;
using System.Collections.Generic;
using System.Globalization;
using ActionsOnGoogle.Core.v2.Helpers;
using ActionsOnGoogle.Core.v2.Request;
using ActionsOnGoogle.Core.v2.Response;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebApplicationAPI.ConfiguredIntents;
using FulfillmentMessage = ActionsOnGoogle.Core.v2.Response.FulfillmentMessage;


namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class DialogflowFulfillmentController : ControllerBase
    {
        private readonly IConfiguration _config;

        public DialogflowFulfillmentController(IConfiguration config)
        {
            _config = config;
        }
        
        
        [HttpPost]
        public ContentResult Post([FromBody] FulfillmentRequest data)
        {
            var fulfillmentMessages = new List<FulfillmentMessage>();

            switch (data.QueryResult.Intent.DisplayName)
            {
                case "Default Fallback Intent":
                    fulfillmentMessages.Add(Responsebuilder.BuildTextResponse(new[] {"I am not sure how to help please try again."}));
                    break;
                case "Default Welcome Intent":
                    fulfillmentMessages.Add(
                        Responsebuilder.BuildTextResponse(new[] {"Welcome try and ask me the time."}));
                    break;
                case "Time":

                    var timeIntentResponse = new TimeIntent(_config).GetResponse(data);
                    fulfillmentMessages.Add(timeIntentResponse);
                    
                    break;
                default:
                    fulfillmentMessages.Add(Responsebuilder.BuildCardResponse("Help",
                        $"The {data.QueryResult.Intent.DisplayName} intent has not been configured contact support.",
                        "https://static.planetminecraft.com/files/resource_media/screenshot/1213/Windows-help1_1825170.jpg"));
                    break;
            }

            var response = new FulfilmentResponse()
            {
                FulfillmentMessages = fulfillmentMessages.ToArray()
            };

            return Content(JsonConvert.SerializeObject(response), "application/json");
        }



    }
}