using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    public class ClientIdResponseModel
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

        [JsonPropertyName("address")]
        public string address { get; set; }

        [JsonPropertyName("registrationDate")]
        public DateTime registrationDate { get; set; }

        [JsonPropertyName("dogs")]
        public List<object> dogs { get; set; }

        [JsonPropertyName("orders")]
        public List<object> orders { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool isDeleted { get; set; }
    }
}
