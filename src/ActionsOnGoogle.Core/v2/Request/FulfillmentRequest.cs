namespace ActionsOnGoogle.Core.v2.Request
{
    public class FulfillmentRequest : IRequest
    {
        public string ResponseId { get; set; }
        
        public QueryResult QueryResult { get; set; }

        public OriginalDetectIntentRequest OriginalDetectIntentRequest { get; set; }
        
        public string Session { get; set; }
    }
}