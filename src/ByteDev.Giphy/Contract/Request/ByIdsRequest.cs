using System;
using System.Collections.Generic;

namespace ByteDev.Giphy.Contract.Request
{
    /// <summary>
    /// Represents a request to get a collection of GIFs metadata by their unique IDs.
    /// </summary>
    public class ByIdsRequest : ApiRequest
    {
        /// <summary>
        /// GIF IDs.
        /// </summary>
        public IEnumerable<string> GifIds { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.ByIdsRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <param name="gifIds">GIF IDs.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="gifIds" /> is null.</exception>
        public ByIdsRequest(string apiKey, IEnumerable<string> gifIds) : base(apiKey)
        {
            GifIds = gifIds ?? throw new ArgumentNullException(nameof(gifIds));
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddGifIdsParam(GifIds);
        }
    }
}