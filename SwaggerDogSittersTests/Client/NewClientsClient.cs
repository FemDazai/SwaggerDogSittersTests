using SwaggerDogSittersTests.Models;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SwaggerDogSittersTests.Client
{
    public class NewClientsClient
    {
        //Пишем метод, который вернёт нам id нового клиента. Для этого вводим модельку состоящую из полей ввода клиента
        public int RegistrationClient(ClientsRequestModel model)
        {
            //Ожидаемый результат
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            //Далее вводим json модельки клиента и сереализуем его
            string json = JsonSerializer.Serialize<ClientsRequestModel>(model);

            //Это что-то связанное с сертификатами
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);

            //Из готового класса создаём объект, который будет хранить в себе метод, запрос(url), по которому проиойдёт поиск
            //И контент, который будет содержать в себе инфу про сами данные, которые мы отправили
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Clients"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            //Здесь будет лежать возвращаемый результат, после того как мы отправили message
            HttpResponseMessage responseMessage = client.Send(message);

            //фактический результат статус кода, а далее их сравнение.
            HttpStatusCode actualCode = responseMessage.StatusCode;
            //Возврат id
            Assert.AreEqual(expectedCode, actualCode);

            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);
            return id;
        }

        public string Auth(AuthRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.OK;
            string json = JsonSerializer.Serialize<AuthRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Auth"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);

            HttpStatusCode actualCode = responseMessage.StatusCode;

            Assert.AreEqual(expectedCode, actualCode);
            string token = responseMessage.Content.ReadAsStringAsync().Result;

            return token;
        }
        
        public int AnimalRegistration(string token, AnimalRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<AnimalRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Animals"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.AreEqual(expectedCode, actualCode);
            // Iz-za specifici protokola hhtp, soobwenie zakodirovano. Nujno rasskodirovat
            //string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);
            return id;
        }
         
        public void ChangeClientPassword(string token,PasswordChangeRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.NoContent;
            string json = JsonSerializer.Serialize<PasswordChangeRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
          
            {
                Method = HttpMethod.Patch,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Clients/password"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;

            Assert.AreEqual(expectedCode, actualCode);
        }

        public int GetOrderServiceWalk(string token, OrderWalkRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<OrderWalkRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Orders/walk"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.AreEqual(expectedCode, actualCode);

            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);
            return id;
        }

        public ClientIdResponseModel GetClientInfoById(string token, int id  )
        {
            HttpStatusCode expectedCode = HttpStatusCode.OK;

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Clients/{id}")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;

            Assert.AreEqual(expectedCode, actualCode);
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;

            ClientIdResponseModel clients = JsonSerializer.Deserialize<ClientIdResponseModel>(responseJson)!;
            return clients;
        }

        public int GetOrderServiceOverexpose(string token, OrderOverexposeRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<OrderOverexposeRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Orders/overexpose"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.AreEqual(expectedCode, actualCode);

            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);

            return id;
        }

        public void GetErrorWhenClientPasswordIsWrong(ClientsRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.UnprocessableEntity;
            string jsone = JsonSerializer.Serialize<ClientsRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()

            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Clients"),
                Content = new StringContent(jsone, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;

            Assert.AreEqual(expectedCode, actualCode);

        }
        public int GetOrderServiceDailySittings(string token, OrderDailySittingRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<OrderDailySittingRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Orders/daily-sitting"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;

            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(expectedCode, actualCode);

            return id;
        }

        public int GetOrderServiceSittingForADay(string token, OrderSittingForADayRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string json = JsonSerializer.Serialize<OrderSittingForADayRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Orders/sitting-for-a-day"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;

            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(expectedCode, actualCode);

            return id;
        }
    }
}
