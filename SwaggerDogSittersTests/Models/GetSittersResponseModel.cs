using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
