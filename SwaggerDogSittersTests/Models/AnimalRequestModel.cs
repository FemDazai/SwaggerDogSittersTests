using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SwaggerDogSittersTests.Models
{
    public class AnimalRequestModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("recommendationsForCare")]
        public string RecommendationsForCare { get; set; }

        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        [JsonPropertyName("breed")]
        public string Breed { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }
    }
}
