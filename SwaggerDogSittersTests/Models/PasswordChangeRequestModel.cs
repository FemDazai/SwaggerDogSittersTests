using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    public class PasswordChangeRequestModel
    { 
            [JsonPropertyName("password")]
            public string password { get; set; }

            [JsonPropertyName("oldPassword")]
            public string oldPassword { get; set; }
    }
}
