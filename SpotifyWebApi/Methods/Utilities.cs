using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace SpotifyWebApi
{
    public static class Utilities
    {
        public static string GetQuery(Dictionary<string, string> options)
        {
            var queries = new List<string>(options.Count);
            foreach (var item in options)
            {
                if (!String.IsNullOrWhiteSpace(item.Value))
                    queries.Add(String.Format("{0}:{1}", item.Key, HttpUtility.UrlEncode(item.Value)));
            }
            return String.Join("%20", queries.ToArray());
        }

        public static bool IsNullableType(this Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }

    public class StringEnumLowerConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {

            Type t = objectType.IsNullableType() ? Nullable.GetUnderlyingType(objectType) : objectType;
            return t.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
