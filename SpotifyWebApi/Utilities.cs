using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return String.Join("%20",queries.ToArray());
        }
    }
}
