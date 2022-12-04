using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;

namespace SwaggerDogSittersTests
{
    public class RegistrationTests
    {
        [Test]
        public void RegistrationAndAuthClientTest()
        {
            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "sasha",
                LastName = "adilov",
                Phone = "+79221110500",
                Email = "AdilovSasha@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "AdilovSasha@mail.com",
                Password = "12345689"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);
        }

        [Test]
        public void RegistrationAndAuthSittersTest()
        {
            NewClientsClient client = new NewClientsClient();
            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Zinaida",
                LastName = "Pavlova",
                Phone = "+71234567890",
                Email = "ZinaidaPavlova@mail.ru",
                Password = "123456789",
                Age = 130,
                Experience = 23,
                Sex = 1,
                Description = "string",
                PriceCatalog = new List<PriceCatalog>
                    {
                        new PriceCatalog
                        {
                            Service = 1,
                            Price = 5000
                        }
                    }
            };

            SittersClient sitterClient = new SittersClient();
            int actualid = sitterClient.RegistrationSitters(sittersrequestModel);
            Assert.NotNull(actualid);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "ZinaidaPavlova@mail.ru",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);
            Assert.NotNull(actualToken);
        }

        [Test]
        public void AnimalRegistrationTest()
        {
            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name="Rina",
                LastName="Kirova",
                Phone="+71234567890",
                Email="Rinakir@mail.com",
                Password="123456789",
                Address="1234567890",
                Promocode="1234567890"
            };

            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "Rinakir@mail.com",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            AnimalRequestModel animalRequestModel = new AnimalRequestModel()
            {
                Name="Kiko",
                Age=7,
                RecommendationsForCare="string",
                ClientId= actualId,
                Breed="poodles",
                Size= 4
            };
            int actualid = client.AnimalRegistration(actualToken, animalRequestModel);
            Assert.IsNotNull(actualid); 
        }

        [TearDown]
        public void ClearSitters()
        {
            DBCleaner dBCleaner = new DBCleaner();
            dBCleaner.Clear();
        }
    }
}