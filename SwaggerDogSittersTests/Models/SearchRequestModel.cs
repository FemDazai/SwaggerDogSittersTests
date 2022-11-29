using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SwaggerDogSittersTests.Models
{
    public class SearchRequestModel
    {
        [JsonProperty("priceMinimum")]
        [JsonPropertyName("priceMinimum")]
        public int PriceMinimum { get; set; }

        [JsonProperty("priceMaximum")]
        [JsonPropertyName("priceMaximum")]
        public int PriceMaximum { get; set; }

        [JsonProperty("minRating")]
        [JsonPropertyName("minRating")]
        public int MinRating { get; set; }

        [JsonProperty("isSitterHasComments")]
        [JsonPropertyName("isSitterHasComments")]
        public bool IsSitterHasComments { get; set; }

        [JsonProperty("serviceType")]
        [JsonPropertyName("serviceType")]
        public int ServiceType { get; set; }

        [JsonProperty("district")]
        [JsonPropertyName("district")]
        public int District { get; set; }
    }
}
