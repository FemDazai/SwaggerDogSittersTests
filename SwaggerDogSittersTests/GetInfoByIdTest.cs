using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerDogSittersTests
{
    public class GetInfoByIdTest
    {
        [Test]
        public void GetSitterInfoByIdTest()
        {
            //� ��� ���� �����, ������� ���� ������� � ��������. ������ ������ ��� ������
            SittersClient sitterClient = new SittersClient();
            SittersRequestModel sittersrequestModel = new SittersRequestModel()
            {
                Name = "Zinaida",
                LastName = "Pavlova",
                Phone = "+71234567890",
                Email = "ZZ1Z12221iinaidapavlovnaa1@mail.ru",
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

            int actualid = sitterClient.RegistrationSitters(sittersrequestModel);
            Assert.NotNull(actualid);

            SitterIdResponseModel model = sitterClient.GetSitterInfoById(actualid);

            Assert.NotNull(model);
        }
    }
}
