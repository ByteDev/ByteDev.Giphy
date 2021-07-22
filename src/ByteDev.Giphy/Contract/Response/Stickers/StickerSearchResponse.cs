using System.Collections.Generic;
using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response.Stickers
{
    public class StickerSearchResponse : ApiPaginatedResponse
    {
        /// <summary>
        /// GIFs information.
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<GifResponse> Gifs { get; set; }
    }
}