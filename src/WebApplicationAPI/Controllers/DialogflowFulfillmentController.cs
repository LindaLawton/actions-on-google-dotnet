using ActionsOnGoogle.Core.v2.Helpers;
using ActionsOnGoogle.Core.v2.Request;
using ActionsOnGoogle.Core.v2.Response;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplicationAPI.Helpers;

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

            var simple = Responsebuilder.BuildTextResponse(new[] {"Hello", "hello .."});
            var card = Responsebuilder.BuildCardResponse( "Title", "subtitle" );
            
            var response = new FulfilmentResponse()
            {
                FulfillmentMessages = new[]
                {
                    Responsebuilder.BuildCardResponse( "Title", "subtitle" ),
                    Responsebuilder.BuildCardResponse( "Title2 ", "subtitle 2", "https://assistant.google.com/static/images/molecule/Molecule-Formation-stop.png" )
                }
            };

            return Content(JsonConvert.SerializeObject(response), "application/json");
        }
    }
}