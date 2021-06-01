using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Curso.UI.Web.Uteis
{
    public static class HelperJson
    {
        /// <summary>
        /// serializa JSON
        /// </summary>
        /// <param name="json"></param>
        public static string SerializarJSON(object model)
        {
            try
            {
                return JsonConvert.SerializeObject(model, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings() { PreserveReferencesHandling = PreserveReferencesHandling.All });
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Desserializa JSON
        /// </summary>
        /// <param name="json"></param>
        public static T DesserializarJSON<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        /// <summary>
        /// Esses tratamentos são necessarios devido tipo de retorno do HTTP Result que apresenta uma serie de caracteres desnecessários
        /// e ao ser convertido para JSON apresenta erro.
        /// </summary>
        /// <param name="postResult">string result a ser tratada</param>
        /// <returns>string result tratada</returns>
        public static string TrataRetornoPostResultForJSonValido(string postResult)
        {
            if (!postResult.ValidateJSON())
            {
                return postResult.Replace(@"\r\n", "").Replace(@"\", "").Replace(@"""{", "{").Replace(@"}""", "}");
            }
            else
            {
                return postResult;
            }
        }

        /// <summary>
        /// Extrai do HttpRetorno apenas o result enviado pela API
        /// </summary>
        /// <param name="postResult">String JSON valida</param>
        /// <returns>Result enviado pela api</returns>
        public static string ExtraiApenasResultEnviadoAPI(string postResult)
        {
            JObject rss = JObject.Parse(postResult);
            if (rss["result"] != null)
            {
                var resultApi = rss["result"].ToString();
                return resultApi;
            }
            else
            {
                return postResult;
            }
        }
    }
}
