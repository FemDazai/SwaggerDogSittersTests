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
                Email = "aaadilovsashaa@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualid = client.RegistrationClient(clientsRequestModel);
            Assert.NotNull(actualid);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "aaadilovsashaa@mail.com",
                Password = "12345689"
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
                Email = "zzinaidapavlovnaa@mail.ru",
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

            int actualId = client.RegistrationSitters(sittersrequestModel);
            Assert.NotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "zzinaidapavlovna@mail.ru",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);
        }

        public void ChangePasswordTests()
        {
            NewClientsClient client = new NewClientsClient();
            ClientsResponseModel clientsRequestModel = new ClientsResponseModel()
            {
                Name = "Саша",
                LastName = "Адилов",
                Phone = "+79221110500",
                Email = "aaadilovsashaa@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            string Password = client.RegistrationClient(clientsRequestModel);
            Assert.NotNull(actualid);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "aaadilovsashaa@mail.com",
                Password = "12345689"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);
        }
    }
}