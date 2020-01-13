using System;
using System.Globalization;
using ActionsOnGoogle.Core.v2.Helpers;
using ActionsOnGoogle.Core.v2.Request;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using FulfillmentMessage = ActionsOnGoogle.Core.v2.Response.FulfillmentMessage;

namespace WebApplicationAPI.ConfiguredIntents
{
    public class TimeIntent : IIntent
    {
        private string _apiKey;
        public TimeIntent(IConfiguration config)
        {
            _apiKey =  config.GetValue<string>("GoogleApis:ApiKey", string.Empty); 
        }
        
        public FulfillmentMessage GetResponse(FulfillmentRequest data)
        {
            var city = ParametersHelper.GetParameter("geo-city", data.QueryResult.Parameters);
            if (string.IsNullOrWhiteSpace(city))
                return Responsebuilder.BuildTextResponse(new[] {$"Its currently {DateTime.Now:HH:mm}"});
            
            
            var timezoneForCity = ConvertCityToTimeZoneName(city);
            var timeInThatTimezone =
                TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, timezoneForCity.TimeZoneName);
            return Responsebuilder.BuildTextResponse(new[] {$"Its currently {timeInThatTimezone:HH:mm} in {city}"});

        }

        private TimeZoneResponse ConvertCityToTimeZoneName(string location)
        {
            var response = new TimeZoneResponse();
            var request = $"https://maps.google.com/maps/api/geocode/json?address={location.Replace(" ", "+")}&sensor=false&key={_apiKey}";
            var result = new System.Net.WebClient().DownloadString(request);
            var latLongResult = JsonConvert.DeserializeObject<GoogleResponse>(result);
            if (latLongResult.Status != "OK") return response;

            var timeZoneResponseTimeZoneRequest = $"https://maps.googleapis.com/maps/api/timezone/json?location={latLongResult.Results[0].Geometry.Location.Lat},{latLongResult.Results[0].Geometry.Location.Lng}&timestamp=1362209227&sensor=false&key={_apiKey}";
            var timeZoneResponseString = new System.Net.WebClient().DownloadString(timeZoneResponseTimeZoneRequest);
            var timeZoneResult = JsonConvert.DeserializeObject<TimeZoneResponse>(timeZoneResponseString);
            return timeZoneResult.Status == "OK" ? timeZoneResult : response;
        }
    }


    public class TimeZoneResponse
    {
        [JsonProperty("dstOffset")] public long DstOffset { get; set; }

        [JsonProperty("rawOffset")] public long RawOffset { get; set; }

        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("timeZoneId")] public string TimeZoneId { get; set; }

        [JsonProperty("timeZoneName")] public string TimeZoneName { get; set; }
    }

    public partial class GoogleResponse
    {
        [JsonProperty("results")] public Result[] Results { get; set; }

        [JsonProperty("status")] public string Status { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("address_components")] public AddressComponent[] AddressComponents { get; set; }

        [JsonProperty("formatted_address")] public string FormattedAddress { get; set; }

        [JsonProperty("geometry")] public Geometry Geometry { get; set; }

        [JsonProperty("place_id")] public string PlaceId { get; set; }

        [JsonProperty("types")] public string[] Types { get; set; }
    }

    public partial class AddressComponent
    {
        [JsonProperty("long_name")] public string LongName { get; set; }

        [JsonProperty("short_name")] public string ShortName { get; set; }

        [JsonProperty("types")] public string[] Types { get; set; }
    }

    public partial class Geometry
    {
        [JsonProperty("bounds")] public Bounds Bounds { get; set; }

        [JsonProperty("location")] public Location Location { get; set; }

        [JsonProperty("location_type")] public string LocationType { get; set; }

        [JsonProperty("viewport")] public Bounds Viewport { get; set; }
    }

    public partial class Bounds
    {
        [JsonProperty("northeast")] public Location Northeast { get; set; }

        [JsonProperty("southwest")] public Location Southwest { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("lat")] public string Lat { get; set; }

        [JsonProperty("lng")] public string Lng { get; set; }
    }

    public partial class GoogleResponse
    {
        public static GoogleResponse FromJson(string json) =>
            JsonConvert.DeserializeObject<GoogleResponse>(json, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            },
        };
    }
}