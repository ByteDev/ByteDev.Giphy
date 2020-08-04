using System;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response.Common
{
    /// <summary>
    /// Contains information about the user associated with a GIF and
    /// URLs to assets such as that user's avatar image, profile, and more.
    /// </summary>
    public class UserResponse
    {
        /// <summary>
        /// The URL for this user's avatar image.
        /// </summary>
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        /// <summary>
        /// The URL for the banner image that appears atop this user's profile page.
        /// </summary>
        [JsonProperty("banner_url")]
        public Uri BannerUri { get; set; }

        /// <summary>
        /// The URL for this user's profile.
        /// </summary>
        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }

        /// <summary>
        /// The username associated with this user.
        /// </summary>
        [JsonProperty("username")]
        public Uri UserName { get; set; }

        /// <summary>
        /// The display name associated with this user (contains formatting the base username might not).
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The Twitter username associated with this user, if applicable.
        /// </summary>
        [JsonProperty("twitter")]
        public string TwitterUserName { get; set; }
    }
}