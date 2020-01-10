using System;
using System.Collections.Generic;
using ActionsOnGoogle.Core.v2.Helpers;
using ActionsOnGoogle.Core.v2.Request;
using ActionsOnGoogle.Core.v2.Response;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using FulfillmentMessage = ActionsOnGoogle.Core.v2.Response.FulfillmentMessage;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class DialogflowFulfillmentController : ControllerBase
    {
        [HttpPost]
        public ContentResult Post([FromBody] FulfillmentRequest data)
        {
            var fulfillmentMessages =  new List<FulfillmentMessage>();
            
            switch (data.QueryResult.Intent.DisplayName)
            {
                case "Default Fallback Intent":
                    fulfillmentMessages.Add(Responsebuilder.BuildTextResponse(new[] {"I am not sure how to help please try again."}));
                    break;
                case  "Default Welcome Intent":
                    fulfillmentMessages.Add(Responsebuilder.BuildTextResponse(new[] {"Welcome try and ask me the time."}));
                    break;
                case  "Time":
                    
                    
                    fulfillmentMessages.Add(Responsebuilder.BuildTextResponse(new[] {$"Its currently {DateTime.Now:HH:mm}"}));
                    break;
                default:
                    fulfillmentMessages.Add(Responsebuilder.BuildCardResponse("Help", $"The {data.QueryResult.Intent.DisplayName} intent has not been configured contact support." , "https://static.planetminecraft.com/files/resource_media/screenshot/1213/Windows-help1_1825170.jpg"));
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