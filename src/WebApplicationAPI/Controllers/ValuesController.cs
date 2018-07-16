using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionsOnGoogle.Core;

using ActionsOnGoogle.Core.v2.Request;
using ActionsOnGoogle.Core.v2.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using FulfillmentMessage = ActionsOnGoogle.Core.v2.Response.FulfillmentMessage;
using OutputContext = ActionsOnGoogle.Core.v2.Response.OutputContext;

namespace WebApplicationAPI.Controllers
{
    public class CharsetAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var hold = filterContext.HttpContext.Response.Headers["Content-Type"].ToArray();

            filterContext.HttpContext.Response.Headers["Content-Type"] += "charset=utf-8";
        }
    }


    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            //var response = new IntentResponse()
            //{
            //    speech = "Hello from C#",
            //    displayText = "Display text",
            //    messages = new Messages()
            //    {
            //        type = 1,
            //        title = "Message title",
            //        subtitle = "message subtitle",
            //        imageUrl = "https://assistant.google.com/static/images/molecule/Molecule-Formation-stop.png"
            //    },
            //    contextOut = new List<ContextOut>()
            //    {
            //        new ContextOut()
            //        {
            //            name = "context name",
            //            lifespan = 5,
            //            parameters = new Parameters() { param = "parm value"}
            //        }
            //    },
            //    source = "test.com",
            //    followupEvent = new FollowupEvent() { name = "event name", parameters = new Parameters2() { param = "x" } }
            //};

            //var l = JsonConvert.SerializeObject(response);
            //return l;
            return id.ToString();
        }

        public class crap
        {
            public string speech { get; set; }
        }


        // POST api/values
        [HttpPost]

        public ContentResult Post([FromBody] FulfillmentRequst data)
        {

            var response = new FulfillmentResponse
            {
                FulfillmentText = "Hello from C# v2",

                FulfillmentMessages = new List<FulfillmentMessage>()
                {
                    new FulfillmentMessage()
                    {
                        card = new Card()
                        {
                            title = "card title",
                            subtitle = "sub title",
                            imageUri =
                                "https://assistant.google.com/static/images/molecule/Molecule-Formation-stop.png",
                            buttons = new List<Button>()
                            {
                                new Button()
                                {
                                    text = "button text",
                                    postback = "https://assistant.google.com/"
                                }
                            }
                        }
                    }
                },
                Source = "example.com",
                OutputContexts = new List<OutputContext>()
                {
                    new OutputContext
                    {
                        name = data.session,
                        lifespanCount = 5,
                        parameters = new ActionsOnGoogle.Core.v2.Response.Parameters() {param = "parm value"}
                    }
                },
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
                                    simpleResponse = new ActionsOnGoogle.Core.v2.Response.SimpleResponse() {textToSpeech = "Thi sis a simple response "}
                                }
                            }
                        }

                    }}
                };

            return Content(JsonConvert.SerializeObject(response), "application/json");
        }



        public IActionResult Postx([FromBody] FulfillmentRequst data)
        {
            var response3 = new IntentResponse()
            {
                speech = "Say Hello from C#",
                displayText = "Display Hello from C#",
                messages = new Messages()
                {
                    type = 1,
                    title = "Message title",
                    subtitle = "message subtitle",
                    imageUrl = "https://assistant.google.com/static/images/molecule/Molecule-Formation-stop.png"
                },
                contextOut = new List<ContextOut>()
                {
                    new ContextOut()
                    {
                        name = "context name",
                        lifespan = 5,
                        parameters = new ActionsOnGoogle.Core.Parameters() { param = "parm value"}
                    }
                },
                source = "test.com",
                followupEvent = new FollowupEvent() { name = "event name", parameters = new ActionsOnGoogle.Core.Parameters() { param = "x" } }
            };

            // https://dialogflow.com/docs/reference/api-v2/rest/Shared.Types/WebhookResponse#SCHEMA_REPRESENTATION
            var response = new FulfillmentResponse
            {
                FulfillmentText = "Hello from C# v2",
                FulfillmentMessages = new List<FulfillmentMessage>()
                {
                    new FulfillmentMessage()
                    {
                        card = new Card()
                        {
                            title = "card title",
                            subtitle = "sub title",
                            imageUri =
                                "https://assistant.google.com/static/images/molecule/Molecule-Formation-stop.png",
                            buttons = new List<Button>()
                            {
                                new Button()
                                {
                                    text = "button text",
                                    postback = "https://assistant.google.com/"
                                }
                            }
                        }
                    }
                },
                Source = "example.com",
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
                                    simpleResponse = new ActionsOnGoogle.Core.v2.Response.SimpleResponse() {textToSpeech = "Thi sis a simple response "}
                                }
                            }
                        }

                    },
                    facebook = new ActionsOnGoogle.Core.v2.Response.Facebook() { text = "Hello facebook" },
                    slack = new ActionsOnGoogle.Core.v2.Response.Slack() { text = "Hello facebook" },

                },
                OutputContexts = new List<OutputContext>()
                {
                    new OutputContext
                    {
                        name = data.session,
                        lifespanCount = 5,
                        parameters = new ActionsOnGoogle.Core.v2.Response.Parameters() {param = "parm value"}
                    }
                },
                FollowupEventInput = new FollowupEventInput()
                {
                    name = "event name",
                    languageCode = "en-Us",
                    parameters = new Parameters2() { param = "parm value" }
                }
            };

            var response2 = new SimpleResponseResponse()
            {
                payload = new SimpleResponseResponse.Payload()
                {
                    google = new SimpleResponseResponse.Payload.Google()
                    {
                        expectUserResponse = true,
                        richResponse = new SimpleResponseResponse.Payload.Google.RichResponse()
                        {
                            items = new List<SimpleResponseResponse.Payload.Google.RichResponse.Item>()
                            {
                                new SimpleResponseResponse.Payload.Google.RichResponse.Item()
                                {
                                    simpleResponse = new SimpleResponseResponse.Payload.Google.RichResponse.Item.SimpleResponse()
                                    { textToSpeech = "WORK DAMIT"}
                                }
                            }
                        }
                    }
                }

            };

            var responseHeaders = HttpContext.Response.Headers;
            return Ok(response2);
            //var l = JsonConvert.SerializeObject(response3);

            // return l;



            //return l;
            //return "{ fulfillmentText: 'This is a text response' }";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
