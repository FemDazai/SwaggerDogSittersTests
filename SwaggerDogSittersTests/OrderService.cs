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
                Email = "111haaaashiramamadarov@gmail.com",
                Password = "123456789",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualId1 = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId1);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "111haaaashiramamadarov@gmail.com",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Kabuto",
                LastName = "Yakushi",
                Phone = "+71234567890",
                Email = "111kaaaabutoyakushi@mail.ru",
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
            int actualId2 = sitter.RegistrationSitters(sittersrequestModel);
            Assert.IsNotNull(actualId2);

            AnimalRequestModel animalRequestModel = new AnimalRequestModel()
            {
                Name = "Orochimaru",
                Age = 25,
                RecommendationsForCare = "string",
                ClientId = actualId1,
                Breed = "poodles",
                Size = 4
            };
            int actualId3 = client.AnimalRegistration(actualToken, animalRequestModel);
            Assert.IsNotNull(actualId3);

            OrderModel order1 = new OrderModel()
            {
                clientId = actualId1,
                sitterId = actualId2,
                animalIds = actualId3,
                status = 1,
                workDate = "2022 - 12 - 03T15:14:10.346Z",
                district = 1,
                isTrial = true,
            };
            int actualId4 = client.GetOrderServiceWalk(actualToken, order1);
            Assert.IsNotNull(actualId4);
        }
    }
}
