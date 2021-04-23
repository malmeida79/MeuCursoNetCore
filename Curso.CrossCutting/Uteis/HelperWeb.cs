using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Curso.CrossCutting.Uteis
{
    public static class HelperWeb
    {
        public static List<T> GetHttpClient<T>(string endPoint)
        {
            var retorno = new List<T>();

            var URI = $@"http://localhost:48542/{endPoint}";
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(URI).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var DadosJsonString = response.Content.ReadAsStringAsync().Result;
                        retorno = JsonConvert.DeserializeObject<T[]>(DadosJsonString).ToList();
                    }
                }
            }

            return retorno;
        }
    }
}
