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
                Email = "adilovsasha@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };
            
            int id = client.RegistrationClient(clientsRequestModel);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "IAdmin@mail.ru",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);
        }
    }
}