using System;
using ByteDev.Giphy.Contract.Request;
using ByteDev.ResourceIdentifier;

namespace ByteDev.Giphy.UriFactories
{
    internal class GiphyApiUriFactory
    {
        private readonly GiphyApiClientSettings _settings;

        public GiphyApiUriFactory(GiphyApiClientSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public Uri Create(SearchRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/gifs/search"));
        }

        public Uri Create(RandomRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/gifs/random"));
        }

        public Uri Create(ByIdRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath($"v1/gifs/{request.GifId}"));
        }

        public Uri Create(ByIdsRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath("v1/gifs"));
        }

        public Uri Create(TrendingRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/gifs/trending"));
        }

        public Uri Create(TranslateRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/gifs/translate"));
        }
    }
}