using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response
{
    /// <summary>
    /// Represents get by ID response.
    /// </summary>
    public class ByIdResponse : ApiResponse
    {
        /// <summary>
        /// GIF information.
        /// </summary>
        [JsonProperty("data")]
        public GifResponse Gif { get; set; }
    }
}