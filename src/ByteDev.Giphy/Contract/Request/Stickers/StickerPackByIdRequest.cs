using System;

namespace ByteDev.Giphy.Contract.Request.Stickers
{
    /// <summary>
    /// Represents a request to get sticker pack by it's unique ID.
    /// </summary>
    public class StickerPackByIdRequest : ApiRequest
    {
        /// <summary>
        /// ID of the sticker pack to retrieve.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.Stickers.StickerPackByIdRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public StickerPackByIdRequest(string apiKey) : base(apiKey)
        {
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddStickerPackIdParam(PackId);
        }
    }
}