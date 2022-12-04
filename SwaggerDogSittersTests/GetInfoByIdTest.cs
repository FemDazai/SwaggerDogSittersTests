using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;

namespace SwaggerDogSittersTests
{
    public class GetInfoByIdTest
    {
        [Test]
        public void GetSitterInfoByIdTest()
        {
            SittersClient sitterClient = new SittersClient();
            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Zinaida",
                LastName = "Pavlova",
                Phone = "+71234567890",
                Email = "zinaidapavlovna@mail.ru",
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
            int actualid = sitterClient.RegistrationSitters(sittersrequestModel);
            Assert.NotNull(actualid);

            NewClientsClient client = new NewClientsClient();

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "zinaidapavlovna@mail.ru",
                Password = "123456789"
            };
            string actualToken =client.Auth(authRequestModel);
            Assert.NotNull(actualToken);

            SitterIdResponseModel model = sitterClient.GetSitterInfoById(actualToken, actualid);
            Assert.NotNull(model);
        }

        [Test]
        public void GetClientInfoByIdTest()
        {
            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "Molly",
                LastName = "Posh",
                Phone = "+79221110500",
                Email = "mollyposh@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "mollyposh@mail.com",
                Password = "12345689"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            ClientIdResponseModel model = client.GetClientInfoById(actualToken, actualId);
            Assert.NotNull(model);
        }

        [TearDown]
        public void ClearSitters()
        {
            DBCleaner dBCleaner = new DBCleaner();
            dBCleaner.Clear();
        }
    }
}
