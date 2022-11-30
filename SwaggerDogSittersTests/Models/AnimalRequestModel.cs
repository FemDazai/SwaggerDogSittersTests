using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerDogSittersTests.Models
{
    public class AnimalRequestModel
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonProperty("recommendationsForCare")]
        [JsonPropertyName("recommendationsForCare")]
        public string RecommendationsForCare { get; set; }

        [JsonProperty("clientId")]
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("breed")]
        [JsonPropertyName("breed")]
        public string Breed { get; set; }

        [JsonProperty("size")]
        [JsonPropertyName("size")]
        public int Size { get; set; }
    }
}
