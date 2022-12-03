using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    public class SitterSearchResponseModel
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("lastName")]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonProperty("experience")]
        [JsonPropertyName("experience")]
        public int Experience { get; set; }

        [JsonProperty("regestrationDate")]
        [JsonPropertyName("regestrationDate")]
        public string RegestrationDate { get; set; }
    }
}

