using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ByteDev.Giphy.Request.Stickers;
using NUnit.Framework;

namespace ByteDev.Giphy.IntTests
{
    [TestFixture]
    public class GiphyStickersApiClientTests
    {
        private const int ExistingStickerPackId = 4788704;
        private const int ExistingStickerPackIdHasChildren = 3154;

        private static readonly HttpClient HttpClient = new HttpClient();

        private IGiphyStickerApiClient _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new GiphyStickerApiClient(HttpClient, new GiphyApiClientSettings { UseHttps = true });
        }

        [TestFixture]
        public class SearchStickersAsync : GiphyStickersApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_ThenReturnResults()
            {
                var request = new StickerSearchRequest(ApiKeys.Valid) { Query = "cheeseburgers", Limit = 1 };

                var response = await _sut.SearchStickersAsync(request);

                Assert.That(response.Gifs.Count(), Is.EqualTo(1));
            }

            [Test]
            public async Task WhenNoQuery_ThenReturnNoResults()
            {
                var request = new StickerSearchRequest(ApiKeys.Valid) { Query = null, Limit = 1 };

                var response = await _sut.SearchStickersAsync(request);

                Assert.That(response.Gifs.Count, Is.EqualTo(0));
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new StickerSearchRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.SearchStickersAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetTrendingStickersAsync : GiphyStickersApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_ThenReturnResults()
            {
                var request = new StickerTrendingRequest(ApiKeys.Valid) { Limit = 1 };

                var response = await _sut.GetTrendingStickersAsync(request);

                Assert.That(response.Gifs.Count(), Is.EqualTo(1));
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new StickerTrendingRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetTrendingStickersAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class TranslateStickersAsync : GiphyStickersApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_ThenReturnResults()
            {
                var request = new StickerTranslateRequest(ApiKeys.Valid) { SearchTerm = "burger" };

                var response = await _sut.TranslateStickersAsync(request);

                Assert.That(response.Gif, Is.Not.Null);
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new StickerTranslateRequest(ApiKeys.Invalid) { SearchTerm = "burger" };

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.TranslateStickersAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetRandomStickerAsync : GiphyStickersApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_WithNoTag_ThenReturnResults()
            {
                var request = new StickerRandomRequest(ApiKeys.Valid);

                var response = await _sut.GetRandomStickerAsync(request);

                Assert.That(response.Gif, Is.Not.Null);
            }

            [Test]
            public async Task WhenQueryIsSuccessful_WithTag_ThenReturnResults()
            {
                var request = new StickerRandomRequest(ApiKeys.Valid) { Tag = "burrito" };

                var response = await _sut.GetRandomStickerAsync(request);

                Assert.That(response.Gif, Is.Not.Null);
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new StickerRandomRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetRandomStickerAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetStickerPackListAsync : GiphyStickersApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_ThenReturnResults()
            {
                var request = new StickerPackListingRequest(ApiKeys.Valid);

                var response = await _sut.GetStickerPackListAsync(request);

                Assert.That(response.ChildPacks.Count(), Is.GreaterThan(0));
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new StickerPackListingRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetStickerPackListAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetStickerPackByIdAsync : GiphyStickersApiClientTests
        {
            [Test]
            public async Task WhenStickerPackExists_ThenReturnStickerPack()
            {
                var request = new StickerPackByIdRequest(ApiKeys.Valid) { PackId = ExistingStickerPackId };

                var response = await _sut.GetStickerPackByIdAsync(request);

                Assert.That(response.StickerPack.Id, Is.EqualTo(ExistingStickerPackId));
            }
            
            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new StickerPackByIdRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetStickerPackByIdAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetStickerPackStickersAsync : GiphyStickersApiClientTests
        {
            [Test]
            public async Task WhenStickerPackExists_ThenReturnStickers()
            {
                var request = new StickerPackStickersRequest(ApiKeys.Valid) { PackId = ExistingStickerPackId, Limit = 1 };

                var response = await _sut.GetStickerPackStickersAsync(request);

                Assert.That(response.Stickers.Count(), Is.EqualTo(1));
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new StickerPackStickersRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetStickerPackStickersAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetStickPackChildrenPacksAsync : GiphyStickersApiClientTests
        {
            [Test]
            public async Task WhenStickerPackExists_ThenReturnStickers()
            {
                var request = new StickerPackChildrenPacksRequest(ApiKeys.Valid) { PackId = ExistingStickerPackIdHasChildren };

                var response = await _sut.GetStickPackChildrenPacksAsync(request);

                Assert.That(response.StickerPacks.Count(), Is.GreaterThan(0));
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new StickerPackChildrenPacksRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetStickPackChildrenPacksAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }
    }
}