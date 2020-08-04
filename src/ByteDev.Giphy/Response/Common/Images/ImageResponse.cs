using System;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Common.Images
{
    /// <summary>
    /// Contains a series of objects that contain URLs and other information for GIFs in many different formats and sizes
    /// </summary>
    public class ImageResponse
    {
        /// <summary>
        /// The publicly-accessible direct URL for this GIF.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// The width of this GIF in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// The height of this GIF in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// The size of this GIF in bytes.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// The URL for this GIF in .MP4 format.
        /// </summary>
        [JsonProperty("mp4")]
        public Uri Mp4Url { get; set; }

        /// <summary>
        /// The size in bytes of the .MP4 file corresponding to this GIF.
        /// </summary>
        [JsonProperty("mp4_size")]
        public int Mp4Size { get; set; }

        /// <summary>
        /// The URL for this GIF in .webp format.
        /// </summary>
        [JsonProperty("webp")]
        public Uri WebpUrl { get; set; }

        /// <summary>
        /// The size in bytes of the .webp file corresponding to this GIF.
        /// </summary>
        [JsonProperty("webp_size")]
        public int WebpSize { get; set; }

        /// <summary>
        /// The number of frames in this GIF.
        /// </summary>
        [JsonProperty("frames")]
        public int Frames { get; set; }

        public override string ToString()
        {
            return Url != null ? Url.ToString() : base.ToString();
        }
    }
}