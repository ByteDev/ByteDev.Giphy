using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response.Common
{
    /// <summary>
    /// Contains basic information regarding the request, whether it was successful, and the response given by the API.
    /// </summary>
    public class MetaResponse
    {
        /// <summary>
        /// HTTP response code.
        /// </summary>
        [JsonProperty("status")]
        public int HttpStatus { get; set; }

        /// <summary>
        /// HTTP response message.
        /// </summary>
        [JsonProperty("msg")]
        public string HttpMessage { get; set; }

        /// <summary>
        /// A unique ID paired with this response from the API.
        /// </summary>
        [JsonProperty("response_id")]
        public string ResponseId { get; set; }
    }
}