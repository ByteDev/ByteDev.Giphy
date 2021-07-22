using System.Collections.Generic;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response.Stickers
{
    public class StickerPackChildrenPacksResponse : ApiResponse
    {
        [JsonProperty("data")]
        public IEnumerable<StickerPackResponse> StickerPacks { get; set; }
    }
}