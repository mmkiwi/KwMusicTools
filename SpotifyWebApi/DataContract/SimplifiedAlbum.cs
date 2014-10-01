using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SpotifyWebApi
{
    [JsonObject]
    public partial class SimplifiedAlbum : ISpotifyObject
    {
        /// <summary>
        ///   A simplified album object. This is usually returned as part of a query for an associated artist or track.
        ///   <a href="https://developer.spotify.com/web-api/object-model/#album-object-simplified">Source</a>
        /// </summary>

        [JsonConverter(typeof(StringEnumLowerConverter))]
        public AlbumType AlbumType { get; set; }

        [JsonProperty]
        public IEnumerable<string> AvailableMarkets { get; set; }

        [JsonProperty]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonProperty]
        public string Href { get; set; }

        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public IEnumerable<Image> Images { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Uri { get; set; }

        [JsonProperty]
        public string Type { get { return "album"; } }
    }
}
