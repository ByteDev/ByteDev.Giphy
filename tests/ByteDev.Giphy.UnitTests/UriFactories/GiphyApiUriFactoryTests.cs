using System;
using ByteDev.Giphy.Domain;
using ByteDev.Giphy.Request;
using ByteDev.Giphy.UriFactories;
using NUnit.Framework;

namespace ByteDev.Giphy.UnitTests.UriFactories
{
    [TestFixture]
    public class GiphyApiUriFactoryTests
    {
        private const string ApiKey = "ABC123";

        private const string GifId1 = "qwerty12345";
        private const string GifId2 = "qwerty54321";

        private static GiphyApiUriFactory GetSut()
        {
            return new GiphyApiUriFactory(new GiphyApiClientSettings { UseHttps = true });
        }

        [Test]
        public void WhenSettingsIsNull_ThenThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => new GiphyApiUriFactory(null));
        }

        [Test]
        public void WhenCreatedWithSearchRequest_ThenReturnUri()
        {
            var result = GetSut().Create(new SearchRequest(ApiKey) { Language = new Language(), Limit = 10, Offset = 2, Rating = new Rating(RatingType.General), Query = "prince" });

            Assert.That(result.AbsoluteUri, Is.EqualTo(@"https://api.giphy.com/v1/gifs/search?api_key=ABC123&fmt=json&limit=10&offset=2&rating=g&lang=en&q=prince"));
        }

        [Test]
        public void WhenCreatedWithRandomRequest_ThenReturnUri()
        {
            var result = GetSut().Create(new RandomRequest(ApiKey) {Rating = new Rating(RatingType.General), Tag = "apple"});

            Assert.That(result.AbsoluteUri, Is.EqualTo("https://api.giphy.com/v1/gifs/random?api_key=ABC123&fmt=json&tag=apple&rating=g"));
        }

        [Test]
        public void WhenCreatedWithByIdRequest_ThenReturnUri()
        {
            var result = GetSut().Create(new ByIdRequest(ApiKey, GifId1));

            Assert.That(result.AbsoluteUri, Is.EqualTo("https://api.giphy.com/v1/gifs/qwerty12345?api_key=ABC123&fmt=json"));
        }

        [Test]
        public void WhenCreatedWithByIdsRequest_ThenReturnUri()
        {
            var result = GetSut().Create(new ByIdsRequest(ApiKey, new []{ GifId1, GifId2 }));

            Assert.That(result.AbsoluteUri, Is.EqualTo("https://api.giphy.com/v1/gifs?api_key=ABC123&fmt=json&ids=qwerty12345%2cqwerty54321")); // %2c == ,
        }

        [Test]
        public void WhenCreatedWithTrendingRequest_ThenReturnUri()
        {
            var result = GetSut().Create(new TrendingRequest(ApiKey) { Limit = 10, Offset = 2, Rating = new Rating(RatingType.General) });

            Assert.That(result.AbsoluteUri, Is.EqualTo("https://api.giphy.com/v1/gifs/trending?api_key=ABC123&fmt=json&limit=10&offset=2&rating=g"));
        }

        [Test]
        public void WhenCreatedWithTranslateRequest_ThenReturnUri()
        {
            var result = GetSut().Create(new TranslateRequest(ApiKey) { SearchTerm = "dave chappelle", Weirdness = 10 });

            Assert.That(result.AbsoluteUri, Is.EqualTo("https://api.giphy.com/v1/gifs/translate?api_key=ABC123&fmt=json&s=dave+chappelle&weirdness=10"));
        }
    }
}