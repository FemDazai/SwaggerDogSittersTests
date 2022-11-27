using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using NUnit.Framework;


namespace SwaggerDogSittersTests
{
    public class RegistrationTests
    {
        [Test]
        public void RegistrationAndAuthClientTest()
        {
            //� ��� ���� �����, ������� ���� ������� � ��������. ������ ������ ��� ������
            NewClientsClient client = new NewClientsClient();
            ClientsResponseModel clientsRequestModel = new ClientsResponseModel()
            {
                Name = "����",
                LastName = "������",
                Phone = "+79221110500",
                Email = "aaadilovsashaa@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };           
            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            int actualid = client.RegistrationClient(clientsRequestModel);
            Assert.NotNull(actualid);

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
                    }
            int actualId = client.RegistrationSitters(sittersrequestModel);
                        Price = 5000
            };
                }

            Assert.NotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "zzinaidapavlovna@mail.ru",
            string actualToken = client.Auth(authRequestModel);
                Password = "123456789"
            };

            Assert.NotNull(actualToken);
        }
    }
}