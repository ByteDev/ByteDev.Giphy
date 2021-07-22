using System.IO;

namespace ByteDev.Giphy.IntTests
{
    internal static class ApiKeys
    {
        private const string GiphyApiKeyFilePath = @"Z:\Dev\ByteDev.Giphy.apikey";

        private static string _apiKey;

        public static string Valid => _apiKey ?? (_apiKey = File.ReadAllText(GiphyApiKeyFilePath).Trim());

        public static string Invalid = "notValidKey111";
    }
}