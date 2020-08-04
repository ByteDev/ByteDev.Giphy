using System.Collections.Generic;
using ByteDev.Giphy.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Stickers
{
    public class StickerPackStickersResponse : ApiPaginatedResponse
    {
        [JsonProperty("data")]
        public IEnumerable<GifResponse> Stickers { get; set; }
    }
}