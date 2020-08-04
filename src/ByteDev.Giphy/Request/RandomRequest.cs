using System;
using ByteDev.Giphy.Domain;

namespace ByteDev.Giphy.Request
{
    /// <summary>
    /// Represents a request for a random GIF.
    /// </summary>
    public class RandomRequest : ApiRequest
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
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Request.RandomRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public RandomRequest(string apiKey) : base(apiKey)
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