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
            NewClientsClient client = new NewClientsClient();
            ClientsResponseModel clientsRequestModel = new ClientsResponseModel()
            {
                Name = "Саша",
                LastName = "Адилов",
                Phone = "+79221110500",
                Email = "adilovsashaa@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };
            
            int actualid = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualid);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "sashaa@mail.com",
                Password = "12345689"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);
        }
    }
}