using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response
{
    /// <summary>
    /// Represents a response from a translate request.
    /// </summary>
    public class TranslateResponse : ApiResponse
    {
        /// <summary>
        /// GIF information.
        /// </summary>
        [JsonProperty("data")]
        public GifResponse Gif { get; set; }
    }
}