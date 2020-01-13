using ActionsOnGoogle.Core.v2.Request;
using FulfillmentMessage = ActionsOnGoogle.Core.v2.Response.FulfillmentMessage;

namespace WebApplicationAPI.ConfiguredIntents
{
    public interface IIntent
    {
        FulfillmentMessage GetResponse(FulfillmentRequest data);
    }
}