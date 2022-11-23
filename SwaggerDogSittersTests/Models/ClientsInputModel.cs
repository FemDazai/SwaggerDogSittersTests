using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerDogSittersTests.Models
{
    public class ClientsInputModel
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("lastName")]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonProperty("address")]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonProperty("promocode")]
        [JsonPropertyName("promocode")]
        public string Promocode { get; set; }
    }
}
