namespace ByteDev.Giphy.Request.Stickers
{
    /// <summary>
    /// Represents a request to get sticker pack listings.
    /// </summary>
    public class StickerPackListingRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Request.Stickers.StickerPackListingRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public StickerPackListingRequest(string apiKey) : base(apiKey)
        {
        }
    }
}