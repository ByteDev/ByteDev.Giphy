using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ByteDev.Giphy.Request;

namespace ByteDev.Giphy.TestApp
{
    internal class Program
    {
        static readonly string GiphyApiKey = Environment.GetEnvironmentVariable("GiphyApiKey");

        private static async Task Main(string[] args)
        {
            var client = new GiphyApiClient(new HttpClient());

            var request = new SearchRequest(GiphyApiKey) { Query = "cheeseburgers", Limit = 1 };

            var response = await client.SearchAsync(request);

            Console.Write(response.Gifs.First().Images.Original.Url);
            Console.ReadKey();
        }
    }
}
