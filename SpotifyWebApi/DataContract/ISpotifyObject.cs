using Newtonsoft.Json;
using System;
namespace SpotifyWebApi
{
    interface ISpotifyObject
    {
        [JsonProperty]
        string Type {get;}
    }
}
