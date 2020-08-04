namespace ByteDev.Giphy
{
    /// <summary>
    /// Represents settings for a Giphy API client.
    /// </summary>
    public class GiphyApiClientSettings
    {
        private const string Host = "api.giphy.com";

        internal static readonly string JsonDateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        internal string BaseUrl => UseHttps ? "https://" + Host : "http://" + Host;

        /// <summary>
        /// Should use HTTPS when calling the GIPHY API.  Otherwise HTTP will be used.
        /// </summary>
        public bool UseHttps { get; set; }
    }
}