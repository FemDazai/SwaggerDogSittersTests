using System.Text.Json.Serialization;

namespace SwaggerDogSittersTests.Models
{
        //НАЧАЛО. Чтобы начать работу, нам нужно понять с чем работаем. Создаём модельку, с котрыми потом будем работать.
        //После написания, идём в класс, который создан для общения с сервером. В данной ситуации, это SuperClient
        public class SittersRequestModel
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

            [JsonPropertyName("age")]
            public int Age { get; set; }

            [JsonPropertyName("experience")]
            public int Experience { get; set; }

            [JsonPropertyName("sex")]
            public int Sex { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }

            [JsonPropertyName("priceCatalog")]
            public List<PriceCatalog> PriceCatalog { get; set; }
        } 
}
