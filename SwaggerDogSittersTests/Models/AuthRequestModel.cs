using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{

    public class AuthRequestModel
    {
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
