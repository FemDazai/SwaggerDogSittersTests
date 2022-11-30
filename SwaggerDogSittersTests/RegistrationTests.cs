using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using NUnit.Framework;
using System.Data;
using Dapper;
using System.Data.SqlClient;



namespace SwaggerDogSittersTests
{
    public class RegistrationTests
    {
        //[OneTimeSetUp]
        //public void ClearClients()
        //{
        //    DBCleaner dBCleaner = new DBCleaner();
        //    dBCleaner.Clear();
        //}

        [Test]
        public void RegistrationAndAuthClientTest()
        {
            //� ��� ���� �����, ������� ���� ������� � ��������. ������ ������ ��� ������
            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name = "sasha",
                LastName = "adilov",
                Phone = "+79221110500",
                Email = "AAADDilovsashAAA@mail.com",
                Password = "12345689",
                Address = "1234567890",
                Promocode = "string"
            };

            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "AAADDilovsashAAA@mail.com",
                Password = "12345689"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);
        }

        [Test]
        public void RegistrationAndAuthSittersTest()
        {
            NewClientsClient client = new NewClientsClient();
            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Zinaida",
                LastName = "Pavlova",
                Phone = "+71234567890",
                Email = "ZZZiinaidapavlovnaa@mail.ru",
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

            int actualid = client.RegistrationSitters(sittersrequestModel);
            Assert.NotNull(actualid);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "ZZZiinaidapavlovnaa@mail.ru",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);
            Assert.NotNull(actualToken);
        }
        //[TearDown]
        //public void ClearSitters()
        //{
        //    DBCleaner dBCleaner = new DBCleaner();
        //    dBCleaner.Clear();
        //}

        [Test]
        public void AnimalRegistrationTest()
        {
            //� ��� ���� �����, ������� ���� ������� � ��������. ������ ������ ��� ������
            NewClientsClient client = new NewClientsClient();
            ClientsRequestModel clientsRequestModel = new ClientsRequestModel()
            {
                Name="Rina",
                LastName="Kirova",
                Phone="+71234567890",
                Email="rinakir@mail.com",
                Password="123456789",
                Address="1234567890",
                Promocode="1234567890"
            };

            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "rinakir@mail.com",
                Password = "123456789"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            AnimalRequestModel animalRequestModel = new AnimalRequestModel()
            {
                Name="kiko",
                Age=7,
                RecommendationsForCare="string",
                ClientId= 10157,
                Breed="poodles",
                Size= 4
            };
            int actuaAnimallId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

        }
    }
}