using System;

namespace ByteDev.Giphy.Contract.Request.Stickers
{
    /// <summary>
    /// Represents a request to get stickers in a sticker pack.
    /// </summary>
    public class StickerPackStickersRequest : ApiRequest
    {
        /// <summary>
        /// ID of the sticker pack to which the retrieved stickers should belong.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// The maximum number of records to return. Default is 25.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Results offset. Defaults to 0.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.Stickers.StickerPackStickersRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public StickerPackStickersRequest(string apiKey) : base(apiKey)
        {
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddStickerPackIdParam(PackId)
                .AddLimitParam(Limit)
                .AddOffsetParam(Offset);
        }
    }
}