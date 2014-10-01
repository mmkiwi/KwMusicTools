using Newtonsoft.Json;
using System;
namespace SpotifyWebApi
{
    public interface ISpotifyObject
    {
        [JsonProperty]
        string Type {get;}
    }
}
