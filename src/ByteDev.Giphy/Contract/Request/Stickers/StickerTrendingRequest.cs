using System;

namespace ByteDev.Giphy.Contract.Request.Stickers
{
    /// <summary>
    /// Represents a request for trending stickers.
    /// </summary>
    public class StickerTrendingRequest : ApiRequest
    {
        /// <summary>
        /// The maximum number of records to return. Default is 25.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Results offset. Defaults to 0.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Filters results by specified rating (everything at the rating and below it).
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.Stickers.StickerTrendingRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public StickerTrendingRequest(string apiKey) : base(apiKey)
        {
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddLimitParam(Limit)
                .AddOffsetParam(Offset)
                .AddRatingParam(Rating);
        }
    }
}