using SwaggerDogSittersTests.Client;
using SwaggerDogSittersTests.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Email = "milovaaaaa@mail.com",
                Password = "1234567899",
                Address = "1234567890",
                Promocode = "string"
            };
            int actualId = client.RegistrationClient(clientsRequestModel);
            Assert.IsNotNull(actualId);

            AuthRequestModel authRequestModel = new AuthRequestModel()
            {
                Email = "milovaaaaa@mail.com",
                Password = "1234567899"
            };
            string actualToken = client.Auth(authRequestModel);

            Assert.NotNull(actualToken);

            PasswordChangeRequestModel password = new PasswordChangeRequestModel()
            {
                password = "123456789",
                oldPassword = "1234567899"
            };

            AuthRequestModel authRequestModel1= new AuthRequestModel()
            {
                Email = "milovaaaaa@mail.com",
                Password = "123456789"
            };
            string actualToken1 = client.Auth(authRequestModel1);
            Assert.NotNull(actualToken1);





        }
    }
}
