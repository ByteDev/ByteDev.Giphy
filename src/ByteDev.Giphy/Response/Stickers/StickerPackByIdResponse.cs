using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Stickers
{
    public class StickerPackByIdResponse : ApiResponse
    {
        [JsonProperty("data")]
        public StickerPackWithAncestorsResponse StickerPack { get; set; }
    }
}