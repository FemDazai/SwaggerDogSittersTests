using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;

namespace SwaggerDogSittersTests
{
    public class ChangeData
    {
        [Test]
        public void ChangeDataClientTests()
        {
            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "asya",
                LastName = "milova",
                Phone = "+71234567890",
                Email = "milovaaaaaa11@mail.com",
                Password = "1234567899",
                Address = "1234567890",
                Promocode = "string"
            };
            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "milovaaaaaa11@mail.com",
                Password = "1234567899"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            PasswordChangeRequestModel password = new PasswordChangeRequestModel()
            {
                password = "123456789",
                oldPassword = "1234567899"
            };
            client.ChangeClientPassword(actualToken, password);
            AuthRequestModel authRequestModel1 = new AuthRequestModel()
            {
                Email = "milovaaaaaa11@mail.com",
                Password = "123456789"
            };
            string actualToken1 = client.Auth(authRequestModel1);
            Assert.NotNull(actualToken1);
        }

        [Test]
        public void ChangeDataSitterTests()
        {
            NewClientsClient client = new NewClientsClient();
            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Nika",
                LastName = "Irsova",
                Phone = "+7123456789",
                Email = "Nikaaaa1@mail.ru",
                Password = "112233445566",
                Age = 21,
                Experience = 4,
                Sex = 1,
                Description = "string",
                PriceCatalog = new List<PriceCatalog>
                {
                    new PriceCatalog
                    {
                        Service = 1,
                        Price = 1000
                    }

                }
            };
            SittersClient sittersClient = new SittersClient();
            int actualid = sittersClient.RegistrationSitters(sittersrequestModel);
            Assert.NotNull(actualid);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "Nikaaaa1@mail.ru",
                Password = "112233445566"
            };
            string actualToken = client.Auth(authRequestModel);
            Assert.NotNull(actualToken);
            PasswordChangeRequestModel password = new PasswordChangeRequestModel()
            {
                password = "123456578",
                oldPassword = "112233445566"
            };
            sittersClient.ChangeDogSittersPassword(actualToken, password);
            AuthRequestModel authRequestModel1 = new AuthRequestModel()
            {
                Email = "Nikaaaa1@mail.ru",
                Password = "123456578"
            };
            string actualToken1 = client.Auth(authRequestModel1);
            Assert.NotNull(actualToken1);
        }
    }
}

