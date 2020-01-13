using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ActionsOnGoogle.Core.v2.Helpers
{
    public static class ParametersHelper
    {
        public static string GetParameter(string name, JObject data)
        {
            return data.ContainsKey(name) ? data[name].ToString() : string.Empty;
        }
    }
}