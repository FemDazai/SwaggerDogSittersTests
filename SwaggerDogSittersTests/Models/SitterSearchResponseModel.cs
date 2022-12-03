using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    public class SitterSearchResponseModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("experience")]
        public int Experience { get; set; }

        [JsonPropertyName("regestrationDate")]
        public string RegestrationDate { get; set; }
    }
}

