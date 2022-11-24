using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using NUnit.Framework;


namespace SwaggerDogSittersTests
{
    public class Tests
    {
        [Test]
        public void RegistrationAndAuthClientTest()
        {
            //У нас есть класс, который ведёт общение с сервером. Создаём объект это класса
            NewClientsClient client = new NewClientsClient();
            ClientsResponseModel clientsRequestModel = new ClientsResponseModel()
            {
                Name = "Саша",
                LastName = "Адилов",
                Phone = "+79221110500",
                Email = "adilovsasha@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            int id = client.RegistrationClient(clientsRequestModel);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "IAdmin@mail.ru",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);
        }
        public void RegistrationAndAuthSittersTest()
        {
            NewClientsClient client = new NewClientsClient();
            SittersResponseModel sittersrequestModel = new SittersResponseModel()
            {
                Name = "Zinaida",
                LastName = "Pavlova",
                Phone = "phone",
                Email = "zinaidapavlovna@mail.ru",
                Password = "123456789",
                Age = 130,
                Experience = 23,
                Sex = 0,
                Description = "string",
                PriceCatalog = new List<PriceCatalogRequest>
                {
                    new PriceCatalogRequest
                    {
                        Service = 1,
                        Price = 5000
                    }
                }
            };
            int id = client.RegistrationSitters(sittersrequestModel);
            //У нас есть класс, который ведёт общение с сервером. Создаём объект это класса
        }
    }
}