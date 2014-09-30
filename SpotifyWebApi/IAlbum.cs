using System;
namespace SpotifyWebApi
{
    public enum AlbumType { Album, Single, Compilation }
    interface IAlbum : ISpotifyObject
    {
        AlbumType AlbumType { get; set; }
        System.Collections.Generic.IEnumerable<string> AvailableMarkets { get; set; }
        ExternalUrls ExternalUrls { get; set; }
        string Href { get; set; }
        string Id { get; set; }
        System.Collections.Generic.IEnumerable<Image> Images { get; set; }
        string Name { get; set; }
        string Uri { get; set; }
    }
}
