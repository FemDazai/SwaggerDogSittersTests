using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    public class SitterIdResponseModel
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("phone")]
        public string phone { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("age")]
        public int age { get; set; }

        [JsonPropertyName("experience")]
        public int experience { get; set; }

        [JsonPropertyName("sex")]
        public int sex { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        public List<PriceCatalog> priceCatalog { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool isDeleted { get; set; }

        [JsonPropertyName("regestrationDate")]
        public string regestrationDate { get; set; }

    }
}
