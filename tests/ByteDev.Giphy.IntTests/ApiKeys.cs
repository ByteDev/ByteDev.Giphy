using System;

namespace ByteDev.Giphy.IntTests
{
    internal static class ApiKeys
    {
        public static string Valid
        {
            get
            {
                var key = Environment.GetEnvironmentVariable("GiphyApiKey", EnvironmentVariableTarget.User);

                if(string.IsNullOrEmpty(key))
                    throw new InvalidOperationException("Giphy API key was not found. Add Giphy API key to environment variables.");

                return key;
            }
        }

        public static string Invalid = "notValidKey111";
    }
}