using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using System.Net;

namespace SwaggerDogSittersTests
{
    public class InputPasswordTest
    {
        [Test]
        public void InputPasswordTestSitters()
        {
            SittersClient client = new SittersClient();
            SittersRequestModel sittersRequestModel = new SittersRequestModel()
            {
                Name = "Zinaida",
                LastName = "Pavlova",
                Phone = "+71234567890",
                Email = "zinaida@mail.ru",
                Password = "1234567",
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
        }

        [Test]
        public void InputPasswordTestClients()
        {
            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "sasha",
                LastName = "adilov",
                Phone = "+79221110500",
                Email = "AdilovSasha@mail.com",
                Password = "12345",
                Address = "1234567890",
                Promocode = "string"
            };
            client.GetErrorWhenClientPasswordIsWrong(clientsRequestModel);
        }


        [TearDown]
        public void ClearSitters()
        {
            DBCleaner dBCleaner = new DBCleaner();
            dBCleaner.Clear();
        }
    }
}
