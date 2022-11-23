using SwaggerDogSittersTests.Models;
using System.Text.Json;

namespace SwaggerDogSittersTests.Client
{
    public class NewClient
    {
        public string Post(ClientsInputModel model)
        { 
            string json = JsonSerializer.Serialize<ClientsInputModel>(model);
            return json;    
        }
    }
}
