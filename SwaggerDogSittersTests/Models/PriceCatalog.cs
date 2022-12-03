using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    public class PriceCatalog
    {
        [JsonPropertyName("service")]
        public int Service { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }
    }
}
