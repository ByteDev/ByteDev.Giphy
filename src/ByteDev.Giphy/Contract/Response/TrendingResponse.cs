using System.Collections.Generic;
using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response
{
    /// <summary>
    /// Represents a response from a trending request.
    /// </summary>
    public class TrendingResponse : ApiPaginatedResponse
    {
        /// <summary>
        /// GIFs information.
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<GifResponse> Gifs { get; set; }
    }
}