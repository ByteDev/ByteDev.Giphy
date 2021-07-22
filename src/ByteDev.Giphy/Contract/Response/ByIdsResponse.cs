using System.Collections.Generic;
using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response
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