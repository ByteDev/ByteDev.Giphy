using Newtonsoft.Json;

namespace ByteDev.Giphy.Json
{
    internal class JsonSerializerSettingsFactory
    {
        public static JsonSerializerSettings Create()
        {
            return new JsonSerializerSettings
            {
                ContractResolver = new CustomDateContractResolver(GiphyApiClientSettings.JsonDateTimeFormat)
            };
        }
    }
}