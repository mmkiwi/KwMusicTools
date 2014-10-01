using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SpotifyWebApi
{
    public partial class Album
    {
        public static async Task<PagingCollection<Album>> Search(string albumName, string artistName = null, int year = 0, string genre = null, string upc = null, string isrc = null, int limit = 20, int offset = 0)
        {
            UriBuilder uri = new UriBuilder("https://api.spotify.com/v1/search");
            var query = HttpUtility.ParseQueryString(string.Empty);
            query.Add("q", Utilities.GetQuery(new Dictionary<string, string> { { "album", albumName } }));

            // Do search
        

            throw new NotImplementedException();
        }
    }
}
