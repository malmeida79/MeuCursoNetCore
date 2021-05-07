using Curso.Domain.Containers;
using Curso.Domain.Contracts.Helpers;
using Curso.Domain.Enuns;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Curso.CrossCutting.Uteis
{
    public class HelperWeb : IHelperWeb
    {
        private readonly IHttpClientFactory _clientFactory;
        public string UrlBase { get; set; }

        public HelperWeb(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public RequestResultModel<List<T>> OnGet<T>(string controler, string metodo = null, string[] parametros = null)
        {
            var retorno = new RequestResultModel<List<T>>();

            try
            {
                using (var client = MakeHttpClient())
                {
                    var response = client.GetAsync(GetAddress(controler, metodo, parametros)).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var DadosJsonString = response.Content.ReadAsStringAsync().Result;
                        var obj = JsonConvert.DeserializeObject<T[]>(DadosJsonString).ToList();
                        retorno.Status = StatusResult.Success;
                        retorno.Data = obj;
                        return retorno;
                    }
                }
            }
            catch (Exception ex)
            {
                return new RequestResultModel<List<T>>(StatusResult.Danger, default(List<T>), new MessageModel($"Erro ao recuperar dados:{ex.Message}"));
            }

            return new RequestResultModel<List<T>>(StatusResult.Danger, default(List<T>), new MessageModel("Erro ao recuperar dados."));
        }

        public RequestResultModel OnPost(string controler, object objeto, string metodo = null)
        {
            try
            {
                using (var client = MakeHttpClient())
                {
                    var response = client.PostAsync(GetAddress(controler, metodo), GetByteArrayContent(objeto)).Result;
                    return TrataResposta(response, "Post");
                }
            }
            catch (Exception ex)
            {
                return new RequestResultModel(StatusResult.Danger, new MessageModel($"Erro ao enviar dados:{ex.Message}"));
            }
        }

        public RequestResultModel OnPut(string controler, object objeto, string metodo = null)
        {
            using (var client = MakeHttpClient())
            {
                try
                {
                    var response = client.PutAsync(GetAddress(controler, metodo), GetByteArrayContent(objeto)).Result;
                    return TrataResposta(response, "Put");
                }
                catch (Exception ex)
                {
                    return new RequestResultModel(StatusResult.Danger, new MessageModel($"Erro ao atualizar dados:{ex.Message}"));
                }
            }
        }

        public RequestResultModel OnDelete(string controler, string metodo = null, string[] parametros = null)
        {
            using (var client = MakeHttpClient())
            {
                try
                {
                    var response = client.DeleteAsync(GetAddress(controler, metodo, parametros)).Result;
                    return TrataResposta(response, "Delete");
                }
                catch (Exception ex)
                {
                    return new RequestResultModel(StatusResult.Danger, new MessageModel($"Erro ao excluir dados:{ex.Message}."));
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

            client.BaseAddress = new Uri(UrlBase);

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
            var retorno = new RequestResultModel();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    retorno.Status = StatusResult.Success;
                    retorno.Data = null;
                    var msgAcao = "";

                    if (acao == "Post")
                    {
                        msgAcao = "Cadastro";
                    }
                    else if (acao == "Put")
                    {
                        msgAcao = "Alteração";
                    }
                    else if (acao == "Delete")
                    {
                        msgAcao = "Delete";
                    }

                    retorno.Messages.Add(new MessageModel($"Operação {msgAcao}, realizada com sucesso!"));

                    return retorno;
                }
                catch (Exception ex)
                {
                    RequestResultModel res = new RequestResultModel();
                    res.Data = null;
                    res.Status = StatusResult.Danger;
                    res.Messages.Add(new MessageModel($"Falha na recuperação dos dados:{ex.Message}"));
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
