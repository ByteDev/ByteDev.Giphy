using System.Collections.Generic;
using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response.Stickers
{
    public class StickerPackStickersResponse : ApiPaginatedResponse
    {
        [JsonProperty("data")]
        public IEnumerable<GifResponse> Stickers { get; set; }
    }
}