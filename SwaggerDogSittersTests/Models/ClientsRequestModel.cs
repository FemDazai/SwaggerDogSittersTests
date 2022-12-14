using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SwaggerDogSittersTests.Models
{
    public class ClientsRequestModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("promocode")]
        public string Promocode { get; set; }
    }
}
