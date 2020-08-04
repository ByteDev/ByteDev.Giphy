using ByteDev.Giphy.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response
{
    public abstract class ApiResponse
    {
        /// <summary>
        /// Information regarding the request, whether it was successful, and the response given by the API.
        /// </summary>
        [JsonProperty("meta")]
        public MetaResponse Meta { get; set; }
    }
}