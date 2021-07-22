using Newtonsoft.Json;

namespace ByteDev.Giphy.Contract.Response
{
    /// <summary>
    /// Represents an error response.
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Error message returned in the response.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        internal static ErrorResponse NewEmpty()
        {
            return new ErrorResponse { Message = "(None)" };
        }
    }
}