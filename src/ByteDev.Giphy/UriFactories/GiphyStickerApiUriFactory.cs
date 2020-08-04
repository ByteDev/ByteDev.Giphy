using System;
using ByteDev.Giphy.Request.Stickers;
using ByteDev.ResourceIdentifier;

namespace ByteDev.Giphy.UriFactories
{
    internal class GiphyStickerApiUriFactory
    {
        private readonly GiphyApiClientSettings _settings;

        public GiphyStickerApiUriFactory(GiphyApiClientSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public Uri Create(StickerSearchRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/stickers/search"));
        }

        public Uri Create(StickerTrendingRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/stickers/trending"));
        }

        public Uri Create(StickerTranslateRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/stickers/translate"));
        }

        public Uri Create(StickerRandomRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/stickers/random"));
        }

        public Uri Create(StickerPackListingRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/stickers/packs"));
        }

        public Uri Create(StickerPackByIdRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/stickers/packs/" + request.PackId));
        }

        public Uri Create(StickerPackStickersRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/stickers/packs/" + request.PackId + "/stickers"));
        }

        public Uri Create(StickerPackChildrenPacksRequest request)
        {
            return request.AddUriParams(new Uri(_settings.BaseUrl).SetPath(@"v1/stickers/packs/" + request.PackId + "/children"));
        }
    }
}