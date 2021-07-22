using System;
using System.Net.Http;
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
                Assert.Throws<ArgumentNullException>(() => _ = new GiphyApiClient(null));
            }

            [Test]
            public void WhenSettingsIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentNullException>(() => _ = new GiphyApiClient(new HttpClient(), null));
            }
        }

        [TestFixture]
        public class SearchAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.SearchAsync(null));
            }
        }

        [TestFixture]
        public class GetRandomAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetRandomAsync(null));
            }
        }

        [TestFixture]
        public class GetByIdAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetByIdAsync(null));
            }
        }

        [TestFixture]
        public class GetByIdsAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetByIdsAsync(null));
            }
        }

        [TestFixture]
        public class GetTrendingAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetTrendingAsync(null));
            }
        }

        [TestFixture]
        public class TranslateAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.TranslateAsync(null));
            }
        }
    }
}