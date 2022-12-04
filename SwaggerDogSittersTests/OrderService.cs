using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;

namespace SwaggerDogSittersTests
{
    public class OrderService
    {
        [Test]
        public void GetOrderSeviceWalk()
        { 
            ClientsRequestModel clientRequest = new ClientsRequestModel();
            NewClientsClient client = new NewClientsClient();
            SittersClient sitter = new SittersClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "Hashirama",
                LastName = "Madarov",
                Phone = "+79221110500",
                Email = "hashirama@gmail.com",
                Password = "123456789",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualclientId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualclientId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "hashirama@gmail.com",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Kabuto",
                LastName = "Yakushi",
                Phone = "+71234567890",
                Email = "kabuto@mail.ru",
                Password = "123456789",
                Age = 130,
                Experience = 3,
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
            int actualsitterId = sitter.RegistrationSitters(sittersrequestModel);
            Assert.IsNotNull(actualsitterId);

            AnimalRequestModel animalRequestModel = new AnimalRequestModel()
            {
                Name = "Orochimaru",
                Age = 25,
                RecommendationsForCare = "string",
                ClientId = actualclientId,
                Breed = "poodles",
                Size = 4
            };
            int actualanimalId = client.AnimalRegistration(actualToken, animalRequestModel);
            Assert.IsNotNull(actualanimalId);

            OrderWalkRequestModel order1 = new OrderWalkRequestModel()
            {
                clientId = actualclientId,
                sitterId = actualsitterId,
                animalIds = new List<int>
                {
                    actualanimalId
                },
                status = 1,
                workDate = "2022 - 12 - 03T15:14:10.346Z",
                district = 1,
                isTrial = true,
            };
            int actualId = client.GetOrderServiceWalk(actualToken, order1);
            Assert.IsNotNull(actualId);
        }

        [Test]
        public void GetOrderSeviceOverexpose()
        {
            NewClientsClient client = new NewClientsClient();
            SittersClient sitter = new SittersClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "Itachi",
                LastName = "Uchiha",
                Phone = "+79221110500",
                Email = "itachiduwka@gmail.com",
                Password = "123456789",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualclientId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualclientId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "itachiduwka@gmail.com",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Sasuke",
                LastName = "Uchiha",
                Phone = "+71234567890",
                Email = "Sasukezakroysya@mail.ru",
                Password = "123456789",
                Age = 130,
                Experience = 3,
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
            int actualsitterId = sitter.RegistrationSitters(sittersrequestModel);
            Assert.IsNotNull(actualsitterId);

            AnimalRequestModel animalRequestModel = new AnimalRequestModel()
            {
                Name = "Orochimaru",
                Age = 25,
                RecommendationsForCare = "string",
                ClientId = actualclientId,
                Breed = "poodles",
                Size = 4
            };
            int actualanimalId = client.AnimalRegistration(actualToken, animalRequestModel);
            Assert.IsNotNull(actualanimalId);

            OrderOverexposeRequestModel order1 = new OrderOverexposeRequestModel()
            {
                clientId = actualclientId,
                sitterId = actualsitterId,
                animalIds = new List<int>
                {
                    actualanimalId
                },
                status = 1,
                workDate = "2022 - 12 - 03T15:14:10.346Z",
                district = 1,
                dayQuantity=60,
                walkPerDayQuantity=0
            };
            int actualId = client.GetOrderServiceOverexpose(actualToken, order1);
            Assert.IsNotNull(actualId);
        }

        [TearDown]
        public void ClearSitters()
        {
            DBCleaner dBCleaner = new DBCleaner();
            dBCleaner.Clear();
        }
    }
}
