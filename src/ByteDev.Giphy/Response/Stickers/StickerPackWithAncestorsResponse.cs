using System.Collections.Generic;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Stickers
{
    public class StickerPackWithAncestorsResponse : StickerPackResponse
    {
        [JsonProperty("ancestors")]
        public IEnumerable<StickerPackByIdAncestorResponse> Ancestors { get; set; }
    }
}