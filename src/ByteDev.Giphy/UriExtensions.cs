using System;
using System.Collections.Generic;
using ByteDev.Collections;
using ByteDev.Giphy.Contract;
using ByteDev.ResourceIdentifier;

namespace ByteDev.Giphy
{
    internal static class UriExtensions
    {
        public static Uri AddApiKeyParam(this Uri source, string apiKey)
        {
            return source.AddOrUpdateQueryParam("api_key", apiKey);
        }

        public static Uri AddQueryParam(this Uri source, string query)
        {
            return source.AddOrUpdateQueryParam("q", query ?? string.Empty);
        }

        public static Uri AddFormatParam(this Uri source, string format)
        {
            if(!string.IsNullOrEmpty(format))
                return source.AddOrUpdateQueryParam("fmt", format);

            return source;
        }

        public static Uri AddLimitParam(this Uri source, int limit)
        {
            if (limit != 0)
                return source.AddOrUpdateQueryParam("limit", limit.ToString());

            return source;
        }

        public static Uri AddOffsetParam(this Uri source, int offset)
        {
            if (offset != 0)
                return source.AddOrUpdateQueryParam("offset", offset.ToString());

            return source;
        }

        public static Uri AddRatingParam(this Uri source, Rating rating)
        {
            if (rating != null)
                return source.AddOrUpdateQueryParam("rating", rating.Code);

            return source;
        }

        public static Uri AddLanguageParam(this Uri source, Language language)
        {
            if (language != null)
                return source.AddOrUpdateQueryParam("lang", language.Code);

            return source;
        }

        public static Uri AddTagParam(this Uri source, string tag)
        {
            if (!string.IsNullOrEmpty(tag))
                return source.AddOrUpdateQueryParam("tag", tag);

            return source;
        }

        public static Uri AddGifIdsParam(this Uri source, IEnumerable<string> gifIds)
        {
            return source.AddOrUpdateQueryParam("ids", gifIds.ToCsv());
        }

        public static Uri AddStickerPackIdParam(this Uri source, int packId)
        {
            return source.AddOrUpdateQueryParam("pack_id", packId.ToString());
        }
    }
}