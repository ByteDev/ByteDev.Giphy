using System.Collections.Generic;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Stickers
{
    public class StickerPackChildrenPacksResponse : ApiResponse
    {
        [JsonProperty("data")]
        public IEnumerable<StickerPackResponse> StickerPacks { get; set; }
    }
}