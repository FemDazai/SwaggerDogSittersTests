using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    public class OrderDailySittingRequestModel
    {
        [JsonPropertyName("clientId")]
        public int clientId { get; set; }

        [JsonPropertyName("sitterId")]
        public int sitterId { get; set; }

        [JsonPropertyName("animalIds")]
        public List<int> animalIds { get; set; }

        [JsonPropertyName("status")]
        public int status { get; set; }

        [JsonPropertyName("workDate")]
        public string workDate { get; set; }

        [JsonPropertyName("district")]
        public int district { get; set; }

        [JsonPropertyName("dayQuantity")]
        public int dayQuantity { get; set; }

        [JsonPropertyName("walkPerDayQuantity")]
        public int walkPerDayQuantity { get; set; }
    }
}
