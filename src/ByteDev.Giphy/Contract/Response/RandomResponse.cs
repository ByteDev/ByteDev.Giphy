using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response
{
    /// <summary>
    /// Represents a response for a random GIF.
    /// </summary>
    public class RandomResponse : ApiResponse
    {
        /// <summary>
        /// GIF information.
        /// </summary>
        [JsonProperty("data")]
        public GifResponse Gif { get; set; }
    }
}