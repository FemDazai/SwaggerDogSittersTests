using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;


namespace SwaggerDogSittersTests
{
    public class GetListTests
    {
        [Test]
        public void GetSitters()
        {
            NewClientsClient sitter = new NewClientsClient();
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

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "sashaaa@mail.com",
                Password = "12345689"
            };
            NewClientsClient client = new NewClientsClient();
            string token = client.Auth(authRequestModel);

            List<GetSittersResponseModel> sitters = client.GetSitters(token);
        }
    }
}
