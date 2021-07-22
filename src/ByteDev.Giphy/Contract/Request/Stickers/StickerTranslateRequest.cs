using System;
using ByteDev.ResourceIdentifier;

namespace ByteDev.Giphy.Contract.Request.Stickers
{
    /// <summary>
    /// Represents a sticker translate request.
    /// </summary>
    public class StickerTranslateRequest : ApiRequest
    {
        /// <summary>
        /// Search term.
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.Stickers.StickerTranslateRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public StickerTranslateRequest(string apiKey) : base(apiKey)
        {
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddOrUpdateQueryParam("s", SearchTerm);
        }
    }
}