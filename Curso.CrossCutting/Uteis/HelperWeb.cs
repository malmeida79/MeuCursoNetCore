using Curso.Domain.Containers;
using Curso.Domain.Contracts.Helpers;
using Curso.Domain.Enuns;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Curso.CrossCutting.Uteis
{
    public class HelperWeb : IHelperWeb
    {

        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _config;
        private string urlBase = "";

        public HelperWeb() { 
        

        }

        public HelperWeb(IConfiguration config, IHttpClientFactory clientFactory)
        {
            _config = config;
            _clientFactory = clientFactory;
            urlBase = _config.GetSection("EndPointAddress").Value;
        }

        public List<T> OnGet<T>(string endPoint)
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

        public async Task<RequestResultModel<T>> OnGetASync<T>(string controler, string metodo = null, string[] parametros = null)
        {
            try
            {
                using (var client = MakeHttpClient())
                {
                    var responseTask = await client.GetStringAsync(GetAddress(controler, metodo, parametros));

                    if (!string.IsNullOrEmpty(responseTask))
                    {
                        return JsonConvert.DeserializeObject<RequestResultModel<T>>(responseTask);
                    }
                }
            }
            catch (Exception ex)
            {

                return new RequestResultModel<T>(StatusResult.Danger, default(T), new MessageModel("Erro ao recuperar dados."));
            }

            return new RequestResultModel<T>(StatusResult.Danger, default(T), new MessageModel("Erro ao recuperar dados."));
        }

        public async Task<RequestResultModel> OnPostASync(string controler, object objeto, string metodo = null)
        {
            try
            {
                using (var client = MakeHttpClient())
                {
                    var response = await client.PostAsync(GetAddress(controler, metodo), GetByteArrayContent(objeto)).ConfigureAwait(false);
                    return TrataResposta(response, "Post");
                }
            }
            catch (Exception ex)
            {
                return new RequestResultModel(StatusResult.Danger, new MessageModel("Erro ao enviar dados."));
            }
        }


        public async Task<RequestResultModel> OnPutASync(string controler, object objeto, string metodo = null)
        {
            using (var client = MakeHttpClient())
            {
                try
                {
                    var response = await client.PutAsync(GetAddress(controler, metodo), GetByteArrayContent(objeto)).ConfigureAwait(false);
                    return TrataResposta(response, "Put");
                }
                catch (Exception ex)
                {
                    return new RequestResultModel(StatusResult.Danger, new MessageModel("Erro ao atualizar dados."));
                }
            }
        }

        public async Task<RequestResultModel> OnDeleteASync(string controler, string metodo = null, string[] parametros = null)
        {
            using (var client = MakeHttpClient())
            {
                try
                {
                    var response = await client.DeleteAsync(GetAddress(controler, metodo, parametros));
                    return TrataResposta(response, "Delete");
                }
                catch (Exception ex)
                {
                    return new RequestResultModel(StatusResult.Danger, new MessageModel("Erro ao excluir dados."));
                }
            }
        }

        private string GetAddress(string controler, string metodo = null, string[] parametros = null)
        {

            string Address = $"{controler}";

            if (metodo != null)
            {
                Address = $"{controler}/{metodo}";
            }
            else
            {
                Address = controler;
            }

            if (parametros != null)
            {
                for (int i = 0; i < parametros.Length; i++)
                {
                    Address += $"/{parametros[i]}";
                }
            }

            return Address;
        }

        private HttpClient MakeHttpClient(bool fullClient = false, bool passaBearer = true)
        {
            var client = _clientFactory.CreateClient();

            client.BaseAddress = new Uri(urlBase);

            //if (passaBearer)
            //{
            //    if (UsuarioLogado.AccessToken != null)
            //    {
            //        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UsuarioLogado.AccessToken);
            //    }
            //}

            if (fullClient)
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            return client;
        }

        private ByteArrayContent GetByteArrayContent(object objeto)
        {

            string content = JsonConvert.SerializeObject(objeto, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return byteContent;
        }

        private RequestResultModel TrataResposta(HttpResponseMessage response, string acao)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<RequestResultModel>(result);
                }
                catch (Exception ex)
                {
                    RequestResultModel res = new RequestResultModel();
                    res.Data = null;
                    res.Status = StatusResult.Danger;
                    res.Messages.Add(new MessageModel("Falha na recuperação dos dados, resposta da API não estava em formato correto."));
                    return res;
                }
            }
            else
            {
                RequestResultModel res = new RequestResultModel();
                res.Data = null;
                res.Status = StatusResult.Danger;
                res.Messages.Add(new MessageModel("Falha na recuperação dos dados, resposta da API não estava em formato correto."));
                return res;
            }
        }
    }
}
