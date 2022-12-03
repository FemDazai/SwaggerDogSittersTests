using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;

namespace SwaggerDogSittersTests
{
    public class SearchTest
    {
        [Test]
        public void GetSearchSitterInfoTest()
        {   
            NewClientsClient client = new NewClientsClient();
            SittersClient sitterClient = new SittersClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "sergey",
                LastName = "sergeev",
                Phone = "+79221110500",
                Email = "sergeysergeev2222211111@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);


            SittersRequestModel sittersRequestModel = new SittersRequestModel()
            {
                Name = "Zina",
                LastName = "Pavlova",
                Phone = "+71234567890",
                Email = "zinapavlovnaa222221111@mail.ru",
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
            int actualId2 = sitterClient.RegistrationSitters(sittersRequestModel);
            Assert.IsNotNull(actualId2);

            SearchRequestModel searchRequestModel = new SearchRequestModel()
            {
                PriceMinimum = 0,
                PriceMaximum = 50000,
                MinRating = 0,
                IsSitterHasComments = false,
                ServiceType = 1,
                District = 1
            };
            List<SitterSearchResponseModel> sitters = sitterClient.GetSearch(searchRequestModel);
            Assert.NotNull(sitters);
        }
        [TearDown]
        public void TearDown()
        {
            DBCleaner dBCleaner = new DBCleaner();
            dBCleaner.Clear();
        }
    }
}
