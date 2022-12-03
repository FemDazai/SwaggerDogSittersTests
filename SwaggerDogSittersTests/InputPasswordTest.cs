using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Email = "ZZZiinaidapav0lovnaa@mail.ru",
                Password = "1234567",
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
    }
}
