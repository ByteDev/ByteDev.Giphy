using System.Net.Http;
using System.Threading.Tasks;
using ByteDev.Giphy.Contract.Response;
using ByteDev.Giphy.Json;
using Newtonsoft.Json;

namespace ByteDev.Giphy
{
    internal static class ApiResponseHandler
    {
        public static async Task<T> Handle<T>(HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<ErrorResponse>(json, JsonSerializerSettingsFactory.Create()) ?? ErrorResponse.NewEmpty();

                throw new GiphyApiClientException($"Error with request. HTTP response code: '{response.StatusCode}'.  Message: '{error.Message}'.", (int)response.StatusCode);
            }

            return JsonConvert.DeserializeObject<T>(json, JsonSerializerSettingsFactory.Create());
        }
    }
}