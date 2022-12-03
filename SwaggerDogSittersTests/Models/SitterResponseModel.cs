using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
    //НАЧАЛО. Чтобы начать работу, нам нужно понять с чем работаем. Создаём модельку, с котрыми потом будем работать.
    //После написания, идём в класс, который создан для общения с сервером. В данной ситуации, это SuperClient
    
    public class SitterResponseModel
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

        [JsonProperty("age")]
        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonProperty("experience")]
        [JsonPropertyName("experience")]
        public int Experience { get; set; }

        [JsonProperty("sex")]
        [JsonPropertyName("sex")]
        public int Sex { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("priceCatalog")]
        public List<PriceCatalog> PriceCatalog { get; set; }
    }
}

