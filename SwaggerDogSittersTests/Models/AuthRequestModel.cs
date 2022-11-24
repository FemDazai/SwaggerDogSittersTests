﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SwaggerDogSittersTests.Models
{
    public class AuthRequestModel
    {
        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}