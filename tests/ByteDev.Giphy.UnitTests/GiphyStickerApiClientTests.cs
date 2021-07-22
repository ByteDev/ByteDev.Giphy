using System;
using System.Net.Http;
using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests
{
    [TestFixture]
    public class GiphyStickerApiClientTests
    {
        [TestFixture]
        public class Constructor : GiphyStickerApiClientTests
        {
            [Test]
            public void WhenHttpClientIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentNullException>(() => _ = new GiphyStickerApiClient(null));
            }

            [Test]
            public void WhenSettingsIsNull_ThenThrowException()
            {
                Assert.Throws<ArgumentNullException>(() => _ = new GiphyStickerApiClient(new HttpClient(), null));
            }
        }

        [TestFixture]
        public class SearchStickersAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyStickerApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.SearchStickersAsync(null));
            }
        }

        [TestFixture]
        public class GetTrendingStickersAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyStickerApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetTrendingStickersAsync(null));
            }
        }

        [TestFixture]
        public class TranslateStickersAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyStickerApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.TranslateStickersAsync(null));
            }
        }

        [TestFixture]
        public class GetRandomStickerAsync : GiphyStickerApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyStickerApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetRandomStickerAsync(null));
            }
        }

        [TestFixture]
        public class GetStickerPackListAsync : GiphyStickerApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyStickerApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetStickerPackListAsync(null));
            }
        }

        [TestFixture]
        public class GetStickerPackByIdAsync : GiphyStickerApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyStickerApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetStickerPackByIdAsync(null));
            }
        }

        [TestFixture]
        public class GetStickerPackStickersAsync : GiphyStickerApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyStickerApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetStickerPackStickersAsync(null));
            }
        }

        [TestFixture]
        public class GetStickPackChildrenPacksAsync : GiphyStickerApiClientTests
        {
            [Test]
            public void WhenRequestIsNull_ThenThrowException()
            {
                var sut = new GiphyStickerApiClient(new HttpClient());

                Assert.ThrowsAsync<ArgumentNullException>(() => sut.GetStickPackChildrenPacksAsync(null));
            }
        }
    }
}