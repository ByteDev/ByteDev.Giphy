using System;

namespace ByteDev.Giphy.Contract.Request
{
    /// <summary>
    /// Represents a request to get GIF metadata by it's unique ID.
    /// </summary>
    public class ByIdRequest : ApiRequest
    {
        /// <summary>
        /// GIF ID.
        /// </summary>
        public string GifId { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.ByIdRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <param name="gifId">GIF ID.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="gifId" /> is null or empty.</exception>
        public ByIdRequest(string apiKey, string gifId) : base(apiKey)
        {
            if(string.IsNullOrEmpty(gifId))
                throw new ArgumentException("GifId was null or empty.");

            GifId = gifId;
        }
    }
}