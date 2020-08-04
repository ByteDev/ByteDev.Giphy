using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ByteDev.Giphy
{
    /// <summary>
    /// Represents a base Giphy API client.
    /// </summary>
    public abstract class ApiClient
    {
        private readonly HttpClient _httpClient;

        protected ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        protected async Task<T> GetAsync<T>(Uri uri, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync(uri, cancellationToken);

            return await ApiResponseHandler.Handle<T>(response);
        }
    }
}