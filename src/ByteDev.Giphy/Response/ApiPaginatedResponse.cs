using ByteDev.Giphy.Response.Common;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Response
{
    public abstract class ApiPaginatedResponse : ApiResponse
    {
        /// <summary>
        /// Contains information relating to the number of total results available as well as the number of results fetched and their relative positions.
        /// </summary>
        [JsonProperty("pagination")]
        public PaginationResponse Pagination { get; set; }
    }
}