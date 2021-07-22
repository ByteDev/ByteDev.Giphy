using System.Collections.Generic;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response.Stickers
{
    public class StickerPackWithAncestorsResponse : StickerPackResponse
    {
        [JsonProperty("ancestors")]
        public IEnumerable<StickerPackByIdAncestorResponse> Ancestors { get; set; }
    }
}