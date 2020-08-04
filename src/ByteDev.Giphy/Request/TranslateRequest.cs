using System;
using ByteDev.ResourceIdentifier;

namespace ByteDev.Giphy.Request
{
    /// <summary>
    /// Represents a request to search with translation.
    /// </summary>
    public class TranslateRequest : ApiRequest
    {
        private int _weirdness;

        /// <summary>
        /// Search term.
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// Value from 0-10 which makes results more or less weird/random/wtf.
        /// </summary>
        public int Weirdness
        {
            get => _weirdness;
            set
            {
                if(value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Weirdness value must be between 0 and 10.");
                }

                _weirdness = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.Giphy.Request.TranslateRequest" /> class.
        /// </summary>
        /// <param name="apiKey">Giphy API key.</param>
        /// <exception cref="T:System.ArgumentException"><paramref name="apiKey" /> is null or empty.</exception>
        public TranslateRequest(string apiKey) : base(apiKey)
        {
        }

        internal override Uri AddUriParams(Uri uri)
        {
            return base.AddUriParams(uri)
                .AddOrUpdateQueryParam("s", SearchTerm)
                .AddOrUpdateQueryParam("weirdness", Weirdness.ToString());
        }
    }
};