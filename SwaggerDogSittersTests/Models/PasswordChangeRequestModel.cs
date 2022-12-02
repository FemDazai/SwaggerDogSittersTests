using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
