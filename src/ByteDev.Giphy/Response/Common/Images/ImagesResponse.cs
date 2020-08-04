using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Common.Images
{
    public class ImagesResponse
    {
        /// <summary>
        /// Versions of this GIF with a fixed height of 200 pixels. Good for mobile use.
        /// </summary>
        [JsonProperty("fixed_height")]
        public ImageResponse FixedHeight { get; set; }

        /// <summary>
        /// Static image of this GIF with a fixed height of 200 pixels.
        /// </summary>
        [JsonProperty("fixed_height_still")]
        public ImageResponse FixedHeightStill { get; set; }

        /// <summary>
        /// Versions of this GIF with a fixed height of 200 pixels and the number of frames reduced to 6.
        /// </summary>
        [JsonProperty("fixed_height_downsampled")]
        public ImageResponse FixedHeightDownSampled { get; set; }

        /// <summary>
        /// Versions of this GIF with a fixed width of 200 pixels. Good for mobile use.
        /// </summary>
        [JsonProperty("fixed_width")]
        public ImageResponse FixedWidth { get; set; }

        /// <summary>
        /// Static image of this GIF with a fixed width of 200 pixels.
        /// </summary>
        [JsonProperty("fixed_width_still")]
        public ImageResponse FixedWidthStill { get; set; }

        /// <summary>
        /// Versions of this GIF with a fixed width of 200 pixels and the number of frames reduced to 6.
        /// </summary>
        [JsonProperty("fixed_width_downsampled")]
        public ImageResponse FixedWidthDownSampled { get; set; }

        /// <summary>
        /// Versions of this GIF with a fixed height of 100 pixels. Good for mobile keyboards.
        /// </summary>
        [JsonProperty("fixed_height_small")]
        public ImageResponse FixedHeightSmall { get; set; }

        /// <summary>
        /// Static image of this GIF with a fixed height of 100 pixels.
        /// </summary>
        [JsonProperty("fixed_height_small_still")]
        public ImageResponse FixedHeightSmallStill { get; set; }

        /// <summary>
        /// Versions of this GIF with a fixed width of 100 pixels. Good for mobile keyboards.
        /// </summary>
        [JsonProperty("fixed_width_small")]
        public ImageResponse FixedWidthSmall { get; set; }

        /// <summary>
        /// Static image of this GIF with a fixed width of 100 pixels.
        /// </summary>
        [JsonProperty("fixed_width_small_still")]
        public ImageResponse FixedWidthSmallStill { get; set; }

        /// <summary>
        /// Version of this GIF downsized to be under 2mb.
        /// </summary>
        [JsonProperty("downsized")]
        public ImageResponse Downsized { get; set; }

        /// <summary>
        /// Static preview image of the downsized version of this GIF.
        /// </summary>
        [JsonProperty("downsized_still")]
        public ImageResponse DownsizedStill { get; set; }

        /// <summary>
        /// Version of this GIF downsized to be under 8mb.
        /// </summary>
        [JsonProperty("downsized_large")]
        public ImageResponse DownsizedLarge { get; set; }

        /// <summary>
        /// Version of this GIF downsized to be under 5mb.
        /// </summary>
        [JsonProperty("downsized_medium")]
        public ImageResponse DownsizedMedium { get; set; }

        /// <summary>
        /// Version of this GIF downsized to be under 200kb.
        /// </summary>
        [JsonProperty("downsized_small")]
        public ImageResponse DownsizedSmall { get; set; }

        /// <summary>
        /// The original version of this GIF. Good for desktop use.
        /// </summary>
        [JsonProperty("original")]
        public ImageResponse Original { get; set; }

        /// <summary>
        /// Static preview image of the original GIF.
        /// </summary>
        [JsonProperty("original_still")]
        public ImageResponse OriginalStill { get; set; }

        /// <summary>
        /// Version of this GIF set to loop for 15 seconds.
        /// </summary>
        [JsonProperty("looping")]
        public ImageResponse Looping { get; set; }

        /// <summary>
        /// Version of this GIF in .MP4 format limited to 50kb that displays the first 1-2 seconds of the GIF.
        /// </summary>
        [JsonProperty("preview")]
        public ImageResponse PreviewMp4 { get; set; }

        /// <summary>
        /// Version of this GIF limited to 50kb that displays the first 1-2 seconds of the GIF.
        /// </summary>
        [JsonProperty("preview_gif")]
        public ImageResponse PreviewGif { get; set; }
    }
}