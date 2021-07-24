using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using ByteDev.Giphy.Contract.Request;

namespace ByteDev.Giphy.TestApp
{
    internal class Program
    {
        private const string GiphyApiKeyFilePath = @"Z:\Dev\ByteDev.Giphy.apikey";

        private static string GiphyApiKey => File.ReadAllText(GiphyApiKeyFilePath).Trim();

        private static async Task Main(string[] args)
        {
            var client = new GiphyApiClient(new HttpClient());

            var response = await client.SearchAsync(new SearchRequest(GiphyApiKey)
            {
                Query = "cheeseburgers", 
                Limit = 10
            });

            foreach (var gif in response.Gifs)
            {
                Console.WriteLine(gif.Images.Original.Url);    
            }
            
            Console.ReadKey();
        }
    }
}
