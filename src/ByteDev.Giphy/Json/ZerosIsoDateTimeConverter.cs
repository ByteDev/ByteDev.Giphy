using System;
using Newtonsoft.Json;

namespace ByteDev.Giphy.Json
{
    internal class ZerosIsoDateTimeConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        private readonly string _zeroDateString;

        public ZerosIsoDateTimeConverter(string dateTimeFormat, string zeroDateString)
        {
            DateTimeFormat = dateTimeFormat;
            _zeroDateString = zeroDateString;
        }
        
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value.ToString() == _zeroDateString ? 
                DateTime.MinValue :
                base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}