using System;
using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests
{
    [TestFixture]
    public class GiphyApiClientTests
    {
        [TestFixture]
        public class Constructor : GiphyApiClientTests
        {
            [Test]
            public void WhenHttpClientIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentNullException>(() => new GiphyApiClient(null));
            }
        }
    }
}