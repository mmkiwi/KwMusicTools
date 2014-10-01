using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SpotifyWebApi
{
    [JsonObject]
    public partial class Album : SimplifiedAlbum
    {
        [JsonProperty]
        public IEnumerable<Artist> Artists { get; set; }

        [JsonProperty]
        public ExternalIds ExternalIds { get; set; }

        [JsonProperty]
        public IEnumerable<string> Genres { get; set; }

        [JsonProperty]
        public int Popularity { get; set; }

        [JsonProperty]
        public DateTime ReleaseDate { get; set; }

        [JsonConverter(typeof(StringEnumLowerConverter))]
        public DatePrecision ReleaseDatePrecision { get; set; }

        [JsonProperty]
        public PagingCollection<Track> Tracks { get; set; }
    }
}
