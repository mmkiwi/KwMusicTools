using System;
using System.ComponentModel;
namespace SpotifyWebApi
{
    public enum AlbumType
    {
        [Description("album")] 
        Album,
        Single,
        Compilation
    }

    public enum DatePrecision { 
        [Description("year")]
        Year,
        Month,
        Day
    }
}
