﻿using SwaggerDogSittersTests.Models;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Collections;
using System.Collections.Generic;


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
                List<GetSittersResponseModel> sitters= JsonSerializer.Deserialize<List<GetSittersResponseModel>>(responseJsone)!;
                return sitters; 
            }
    }
}
