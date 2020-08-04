using System.Collections.Generic;
using ByteDev.Giphy.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Stickers
{
    public class StickerTrendingResponse : ApiPaginatedResponse
    {
        /// <summary>
        /// GIFs information.
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<GifResponse> Gifs { get; set; }
    }
}