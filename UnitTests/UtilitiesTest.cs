using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpotifyWebApi;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UtilitiesTest
    {
        [TestMethod]
        public void Query()
        {
            Assert.AreEqual(Utilities.GetQuery(new Dictionary<string, string>{
                {"artist", "Pitbull"},
                {"track", "Global Warming"}
            }), "artist:Pitbull%20track:Global+Warming");
        }

    }
}
