using System;

namespace ByteDev.Giphy.Contract.Request.Stickers
{
    /// <summary>
    /// Represents a request to get a random sticker.
    /// </summary>
    public class StickerRandomRequest : ApiRequest
    {
        /// <summary>
        /// Filters results by specified tag.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Filters results by specified rating (everything at the rating and below it).
        /// </summary>
        public Rating Rating { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.Stickers.StickerRandomRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public StickerRandomRequest(string apiKey) : base(apiKey)
        {
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddTagParam(Tag)
                .AddRatingParam(Rating);
        }
    }
}