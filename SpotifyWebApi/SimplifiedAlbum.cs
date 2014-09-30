using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpotifyWebApi
{
    public class SimplifiedAlbum : IAlbum
    {
        public AlbumType AlbumType { get; set; }
        public IEnumerable<string> AvailableMarkets { get; set; }
        public ExternalUrls ExternalUrls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string Type { get { return "album"; } }
    }
}
