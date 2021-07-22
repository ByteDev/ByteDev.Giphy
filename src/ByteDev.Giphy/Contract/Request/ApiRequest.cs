using System;

namespace ByteDev.Giphy.Contract.Request
{
    /// <summary>
    /// Represents a base request to the Giphy API.
    /// </summary>
    public abstract class ApiRequest
    {
        private readonly string _apiKey;

        protected ApiRequest(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
                throw new ArgumentException("API Key was null or empty.", nameof(apiKey));

            _apiKey = apiKey;
        }

        internal virtual Uri AddUriParams(Uri uri)
        {
            return uri
                .AddApiKeyParam(_apiKey)
                .AddFormatParam("json");
        }
    }
}