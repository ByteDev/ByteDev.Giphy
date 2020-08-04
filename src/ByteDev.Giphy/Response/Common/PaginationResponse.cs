using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Common
{
    /// <summary>
    /// Contains information relating to the number of total results available as well
    /// as the number of results fetched and their relative positions.
    /// </summary>
    public class PaginationResponse
    {
        /// <summary>
        /// Total number of items available.
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Total number of items returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Position in pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }
    }
}