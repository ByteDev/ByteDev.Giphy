using System;

namespace ByteDev.Giphy.Contract.Request
{
    /// <summary>
    /// Represents a request to get the top trending GIFs on the internet.
    /// </summary>
    public class TrendingRequest : ApiRequest
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
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.TrendingRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public TrendingRequest(string apiKey) : base(apiKey)
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