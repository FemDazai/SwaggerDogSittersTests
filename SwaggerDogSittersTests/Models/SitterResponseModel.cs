using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SwaggerDogSittersTests.Models
{
    //НАЧАЛО. Чтобы начать работу, нам нужно понять с чем работаем. Создаём модельку, с котрыми потом будем работать.
    //После написания, идём в класс, который создан для общения с сервером. В данной ситуации, это SuperClient
    public class PriceCatalogResponse
    {
        [JsonProperty("service")]
        [JsonPropertyName("service")]
        public int Service { get; set; }

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public int Price { get; set; }
    }

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

        [JsonProperty("priceCatalog")]
        [JsonPropertyName("priceCatalog")]
        public List<PriceCatalogResponse> PriceCatalog { get; set; }
    }
}

