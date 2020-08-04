using System;

namespace ByteDev.Giphy.Request.Stickers
{
    /// <summary>
    /// Represents a request to get all children sticker packs for
    /// a parent sticker pack.
    /// </summary>
    public class StickerPackChildrenPacksRequest : ApiRequest
    {
        /// <summary>
        /// ID of the parent sticker pack to which the children sticker packs should belong.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Request.Stickers.StickerPackChildrenPacksRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public StickerPackChildrenPacksRequest(string apiKey) : base(apiKey)
        {
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddStickerPackIdParam(PackId);
        }
    }
}