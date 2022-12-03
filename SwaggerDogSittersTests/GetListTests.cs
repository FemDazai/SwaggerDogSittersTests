using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;


namespace SwaggerDogSittersTests
{
    public class GetListTests
    {
        [Test]
        public void GetSitters()
        {
            SittersClient sitter = new SittersClient();
            List<SittersRequestModel> sittersrequestModels = new List<SittersRequestModel> {
            new SittersRequestModel()
            {
                Name = "Megi",
                LastName = "Lick",
                Phone = "+71231231231",
                Email = "megi11@mail.ru",
                Password = "123456789",
                Age = 130,
                Experience = 23,
                Sex = 1,
                Description = "string",
                PriceCatalog = new List<PriceCatalogRequest>
                    {
                        new PriceCatalogRequest
                        {
                            Service = 1,
                            Price = 5000
                        }
                    }
            },
            new SittersRequestModel()
            {
                Name = "Megi",
                LastName = "Lick",
                Phone = "+71231231231",
                Email = "megi22@mail.ru",
                Password = "123456789",
                Age = 130,
                Experience = 23,
                Sex = 1,
                Description = "string",
                PriceCatalog = new List<PriceCatalogRequest>
                    {
                        new PriceCatalogRequest
                        {
                            Service = 1,
                            Price = 5000
                        }
                    }
            }
            };

            foreach (var sittersrequestModel in sittersrequestModels)
            {
                Assert.NotNull(sitter.RegistrationSitters(sittersrequestModel));
            }

            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "sasha",
                LastName = "adilov",
                Phone = "+79221110500",
                Email = "KAADDIlovsashAAA@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "KAADDIlovsashAAA@mail.com",
                Password = "12345689"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            List<GetSittersResponseModel> sitters = sitter.GetSitters(actualToken);
            Assert.NotNull(sitters);
        }
        //[TearDown]
        //public void ClearSitters()
        //{
        //    DBCleaner dBCleaner = new DBCleaner();
        //    dBCleaner.Clear();
        //}
    }
}
