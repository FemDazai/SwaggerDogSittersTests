using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SwaggerDogSittersTests
{
    public class SearchTest
    {
        [Test]
        public void RegistrationAndAuthClientTest()
        {
            //� ��� ���� �����, ������� ���� ������� � ��������. ������ ������ ��� ������
            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "sergey",
                LastName = "sergeev",
                Phone = "+79221110500",
                Email = "sergeysergeev1@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

        }

        public void RegistrationAndAuthSittersTest()
        {
            NewClientsClient client = new NewClientsClient();
            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Zina",
                LastName = "Pavlova",
                Phone = "+71234567890",
                Email = "zinapavlovnaa@mail.ru",
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
                    
            };
        }

        public void GetSearchTest()
        {
            //� ��� ���� �����, ������� ���� ������� � ��������. ������ ������ ��� ������
            NewClientsClient client = new NewClientsClient();
            SearchRequestModel searchRequestModel = new SearchRequestModel()
            {
                PriceMinimum = 0,
                PriceMaximum = 50000,
                MinRating = 0,
                IsSitterHasComments = false,
                ServiceType = 1,
                District = 1
            };
            List<SitterResponseModel> sitters = client.GetSearch(searchRequestModel);
        }
        [TearDown]
        public void TearDown()
        {
            DBCleaner dBCleaner = new DBCleaner();
            dBCleaner.Clear();
        }
    }
}
