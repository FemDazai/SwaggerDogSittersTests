using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using NUnit.Framework;


namespace SwaggerDogSittersTests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            ClientsInputModel clientsInputModel = new ClientsInputModel()
            {
                Name = "Саша",
                LastName = "Адилов",
                Phone = "+79221110500",
                Email = "sashaa@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };
            NewClient client = new NewClient();

            string token = client.Post(clientsInputModel);
        }
    }
}