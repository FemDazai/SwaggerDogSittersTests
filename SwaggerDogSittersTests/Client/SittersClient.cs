using SwaggerDogSittersTests.Models;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SwaggerDogSittersTests.Client
{
    public class SittersClient
    {
        public int RegistrationSitters(SittersRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.Created;
            string jsone = JsonSerializer.Serialize<SittersRequestModel>(model);

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

        public List<GetSittersResponseModel> GetSitters(string token)
        {
            HttpStatusCode expectedCode = HttpStatusCode.OK;

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpRequestMessage message = new HttpRequestMessage()

            {
                Method = HttpMethod.Get,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Sitters"),
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;

            Assert.AreEqual(expectedCode, actualCode);
            string responseJsone = responseMessage.Content.ReadAsStringAsync().Result;
            List<GetSittersResponseModel> sitters = JsonSerializer.Deserialize<List<GetSittersResponseModel>>(responseJsone)!;
            return sitters;
        }

        public List<SitterSearchResponseModel> GetSearch(SearchRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.OK;
            string json = JsonSerializer.Serialize<SearchRequestModel>(model);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);

            HttpRequestMessage message = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new System.Uri($"https://piter-education.ru:10000/Search"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage responseMessage = client.Send(message);
            HttpStatusCode actualCode = responseMessage.StatusCode;

            Assert.AreEqual(expectedCode, actualCode);
            // Iz-za specifici protokola hhtp, soobwenie zakodirovano. Nujno rasskodirovat
            string responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            //1.ResponseMessage - blok samoqo soobweniya (obrawaemsa k pismu);
            //2.Content = eqo soderjanie (obrawaemsa k contentu);
            //3.ReadAsStringAsync - iz-za napravleniya mnogo-potocnogo progrramirovaniya, nam mojet ponadobitsa, neskolko vivodov reziltata, a tut mi utocnsyem, kakoe imenno nam nujno 
            //(Ctobi paskodirovat kontent, obrawaet eqo v stringu)
            //async-asinxronniy

            List<SitterSearchResponseModel> sitters = JsonSerializer.Deserialize<List<SitterSearchResponseModel>>(responseJson)!;
            return sitters;
        }

        public void GetErrorWhenSitterPasswordIsWrongTest(SittersRequestModel model)
        {
            HttpStatusCode expectedCode = HttpStatusCode.UnprocessableEntity;
            string jsone = JsonSerializer.Serialize<SittersRequestModel>(model);

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

        }
    }
}
