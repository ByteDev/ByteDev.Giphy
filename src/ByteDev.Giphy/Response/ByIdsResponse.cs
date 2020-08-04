using System.Collections.Generic;
using ByteDev.Giphy.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response
{
    /// <summary>
    /// Represents get by IDs response.
    /// </summary>
    public class ByIdsResponse : ApiPaginatedResponse
    {
        /// <summary>
        /// GIFs information.
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<GifResponse> Gifs { get; set; }
    }
}