using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ByteDev.Collections;
using ByteDev.Giphy.Contract.Request;
using ByteDev.Giphy.IntTests.TestModels;
using NUnit.Framework;

namespace ByteDev.Giphy.IntTests
{
    [TestFixture]
    public class GiphyApiClientTests
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        
        private IGiphyApiClient _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new GiphyApiClient(HttpClient, new GiphyApiClientSettings { UseHttps = true });
        }

        [TestFixture]
        public class SearchAsync : GiphyApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_ThenReturnResults()
            {
                var request = new SearchRequest(ApiKeys.Valid) { Query = "cheeseburgers", Limit = 1 };

                var response = await _sut.SearchAsync(request);

                Assert.That(response.Gifs.Count(), Is.EqualTo(1));
            }

            [Test]
            public async Task WhenNoQuery_ThenReturnNoResults()
            {
                var request = new SearchRequest(ApiKeys.Valid) { Query = null, Limit = 1 };

                var response = await _sut.SearchAsync(request);

                Assert.That(response.Gifs.Count, Is.EqualTo(0));
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new SearchRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.SearchAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetRandomAsync : GiphyApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_WithNoTag_ThenReturnResults()
            {
                var request = new RandomRequest(ApiKeys.Valid);

                var response = await _sut.GetRandomAsync(request);

                Assert.That(response.Gif, Is.Not.Null);
            }

            [Test]
            public async Task WhenQueryIsSuccessful_WithTag_ThenReturnResults()
            {
                var request = new RandomRequest(ApiKeys.Valid) { Tag = "burrito" };

                var response = await _sut.GetRandomAsync(request);

                Assert.That(response.Gif, Is.Not.Null);
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new RandomRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetRandomAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetByIdAsync : GiphyApiClientTests
        {
            [Test]
            public async Task WhenGifExists_ThenReturnResult()
            {
                var request = new ByIdRequest(ApiKeys.Valid, GifIds.GifIdExists3);

                var response = await _sut.GetByIdAsync(request);

                Assert.That(response.Gif.Id, Is.EqualTo(GifIds.GifIdExists3));
            }

            [Test]
            public void WhenGifDoesNotExist_ThenThrowExceptionNotFound()
            {
                var request = new ByIdRequest(ApiKeys.Valid, GifIds.GifIdNotExists);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetByIdAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.NotFound));
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new ByIdRequest(ApiKeys.Invalid, GifIds.GifIdExists3);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetByIdAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class GetByIdsAsync : GiphyApiClientTests
        {
            [Test]
            public void WhenNoGifExists_ThenThrowExceptionNotFound()
            {
                var request = new ByIdsRequest(ApiKeys.Valid, new [] {GifIds.GifIdNotExists });

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetByIdsAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.NotFound));
            }

            [Test]
            public async Task WhenOneGifQuery_AndExists_ThenReturnResult()
            {
                var request = new ByIdsRequest(ApiKeys.Valid, new[] {GifIds.GifIdExists1 });

                var response = await _sut.GetByIdsAsync(request);

                Assert.That(response.Gifs.Single().Id, Is.EqualTo(GifIds.GifIdExists1));
            }

            [Test]
            public async Task WhenTwoGifQuery_AndBothExists_ThenReturnTwoResults()
            {
                var request = new ByIdsRequest(ApiKeys.Valid, new[] {GifIds.GifIdExists1, GifIds.GifIdExists2 });

                var response = await _sut.GetByIdsAsync(request);

                Assert.That(response.Gifs.Count(), Is.EqualTo(2));
                Assert.That(response.Gifs.First().Id, Is.EqualTo(GifIds.GifIdExists1));
                Assert.That(response.Gifs.Second().Id, Is.EqualTo(GifIds.GifIdExists2));
            }

            [Test]
            public async Task WhenTwoGifQuery_AndOneExists_ThenReturnOneResult()
            {
                var request = new ByIdsRequest(ApiKeys.Valid, new[] {GifIds.GifIdNotExists, GifIds.GifIdExists1 });

                var response = await _sut.GetByIdsAsync(request);

                Assert.That(response.Gifs.Single().Id, Is.EqualTo(GifIds.GifIdExists1));
            }
        }

        [TestFixture]
        public class GetTrendingAsync : GiphyApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_ThenReturnResults()
            {
                var request = new TrendingRequest(ApiKeys.Valid);

                var response = await _sut.GetTrendingAsync(request);

                Assert.That(response.Gifs.Count(), Is.GreaterThan(0));
            }

            [Test]
            public async Task WhenQueryLimitIsSet_ThenReturnResults()
            {
                var request = new TrendingRequest(ApiKeys.Valid) { Limit = 10 };

                var response = await _sut.GetTrendingAsync(request);

                Assert.That(response.Gifs.Count(), Is.EqualTo(request.Limit));
            }

            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new TrendingRequest(ApiKeys.Invalid);

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.GetTrendingAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }

        [TestFixture]
        public class TranslateAsync : GiphyApiClientTests
        {
            [Test]
            public async Task WhenQueryIsSuccessful_ThenReturnResults()
            {
                var request = new TranslateRequest(ApiKeys.Valid) { SearchTerm = "dave chappelle", Weirdness = 10 };

                var response = await _sut.TranslateAsync(request);

                Assert.That(response.Gif, Is.Not.Null);
            }
            
            [Test]
            public void WhenInvalidApKey_ThenThrowExceptionForbidden()
            {
                var request = new TranslateRequest(ApiKeys.Invalid) { SearchTerm = "dave chappelle", Weirdness = 10 };

                var ex = Assert.ThrowsAsync<GiphyApiClientException>(() => _sut.TranslateAsync(request));

                Assert.That(ex.HttpStatusCode, Is.EqualTo(ApiStatusCodes.Forbidden));
            }
        }
    }
}