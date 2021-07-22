using ByteDev.Giphy.Contract.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response.Stickers
{
    public class StickerPackResponse
    {
        /// <summary>
        /// Sticker Pack's unique numeric ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Numeric identifier for the parent Sticker Pack.
        /// </summary>
        [JsonProperty("parent")]
        public int ParentId { get; set; }

        /// <summary>
        /// Will return "community" or "editorial". This describes whether this Sticker Pack is curated by GIPHY or by the community.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

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
        /// Long form description of this Sticker Pack.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Will return a banner image for this Sticker Pack (either JPG, PNG, or GIF) with 1040x160 dimensions.
        /// </summary>
        [JsonProperty("banner_image")]
        public string BannerImage { get; set; }

        /// <summary>
        /// Describes whether or not this Sticker Pack contains child Sticker Packs.
        /// </summary>
        [JsonProperty("has_children")]
        public bool HasChildren { get; set; }

        /// <summary>
        /// The GIPHY user associated with this Sticker Pack.
        /// </summary>
        [JsonProperty("user")]
        public UserResponse User { get; set; }

        /// <summary>
        /// The GIF that will appear in a thumbnail, header image or other visual representation when referencing this Sticker Pack.
        /// </summary>
        [JsonProperty("featured_gif")]
        public GifResponse Gif { get; set; }
    }
}