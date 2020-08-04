using System.Collections.Generic;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Stickers
{
    public class StickerPackListResponse : ApiPaginatedResponse
    {
        /// <summary>
        /// Child pack objects.
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<StickerPackResponse> ChildPacks { get; set; }
    }
}