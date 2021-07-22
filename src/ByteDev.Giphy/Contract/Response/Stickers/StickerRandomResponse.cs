using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response.Stickers
{
    public class StickerRandomResponse : ApiResponse
    {
        /// <summary>
        /// GIF information.
        /// </summary>
        [JsonProperty("data")]
        public GifResponse Gif { get; set; }
    }
}