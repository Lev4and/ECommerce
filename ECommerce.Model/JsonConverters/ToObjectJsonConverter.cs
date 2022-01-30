using Newtonsoft.Json;

namespace ECommerce.Model.JsonConverters
{
    public class ToObjectJsonConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            return JsonConvert.DeserializeObject<T>(Convert.ToString(reader.Value));
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
