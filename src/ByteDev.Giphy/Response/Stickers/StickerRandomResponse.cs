using ByteDev.Giphy.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Stickers
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