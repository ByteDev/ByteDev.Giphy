using System;

namespace ByteDev.Giphy.Contract.Request
{
    /// <summary>
    /// Represents a GIF search request.
    /// </summary>
    public class SearchRequest : ApiRequest
    {
        /// <summary>
        /// Search query term or phrase.
        /// GIPHY search will automatically look for exact matches to queries + AND match + OR match.
        /// Explicit AND + OR boolean clauses in search queries are not supported.
        /// </summary>
        public string Query { get; set; }

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
        /// Specify default language for regional content.
        /// </summary>
        public Language Language { get; set; }    

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Contract.Request.SearchRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public SearchRequest(string apiKey) : base(apiKey)
        {
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddLimitParam(Limit)
                .AddOffsetParam(Offset)
                .AddRatingParam(Rating)
                .AddLanguageParam(Language)
                .AddQueryParam(Query);
        }
    }
}