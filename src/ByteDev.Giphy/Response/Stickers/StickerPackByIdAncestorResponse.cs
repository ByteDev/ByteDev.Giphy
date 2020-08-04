using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Stickers
{
    public class StickerPackByIdAncestorResponse
    {
        /// <summary>
        /// Sticker Pack's unique numeric ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// URL-friendly name for this Sticker Pack.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Human-readable name for this Sticker Pack. (May contain formatting the other names don't).
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// A more concise version of this Sticker Pack's display name.
        /// </summary>
        [JsonProperty("short_display_name")]
        public string ShortDisplayName { get; set; }

        /// <summary>
        /// Describes whether or not this Sticker Pack contains child Sticker Packs.
        /// </summary>
        [JsonProperty("has_children")]
        public bool HasChildren { get; set; }

        /// <summary>
        /// Will return a banner image for this Sticker Pack (either JPG, PNG, or GIF) with 1040x160 dimensions.
        /// </summary>
        [JsonProperty("banner_image")]
        public string BannerImage { get; set; }

        [JsonProperty("featured_gif_id")]
        public string FeaturedGifId { get; set; }
    }
}