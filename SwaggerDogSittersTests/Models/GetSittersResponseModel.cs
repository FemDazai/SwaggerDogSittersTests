using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    public class GetSittersResponseModel
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("experience")]
        public int experience { get; set; }

        [JsonPropertyName("regestrationDate")]
        public string regestrationDate { get; set; }
    }
}
