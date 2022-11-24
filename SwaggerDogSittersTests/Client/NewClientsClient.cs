using SwaggerDogSittersTests.Models;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;


namespace SwaggerDogSittersTests.Client
{
    public class NewClientsClient
    {
        public int RegistrationClient(ClientsResponseModel model) 
        { 
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string jsone = JsonSerializer.Serialize<ClientsResponseModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors)=> { return true; };

            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Clients"),
                Content = new StringContent( jsone, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);

            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.AreEqual(expectedCode, actualCode);

            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);
            //string id = responseMessage.Content.ReadAsStringAsync().Result;

            return id;    
        }

        public string Auth(AuthRequestModel model)
        {
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

            string token = responseMessage.Content.ReadAsStringAsync().Result;

            return token;
        }
        public int RegistrationSitters(SittersResponseModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string jsone = JsonSerializer.Serialize<SittersResponseModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Sitters"),
                Content = new StringContent(jsone, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);

            HttpStatusCode actualCode = responseMessage.StatusCode;
            Assert.AreEqual(expectedCode, actualCode);

            int id = Convert.ToInt32(responseMessage.Content.ReadAsStringAsync().Result);

            return id;
        }
    }
}
