using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json.Linq;
using System;

namespace Curso.UI.Web.Uteis
{
    public static class Extensions
    {
        /// <summary>
        /// Inserir itens no TempData
        /// </summary>
        /// <typeparam name="T">Tipo de dados</typeparam>
        /// <param name="tempData">TempData a ser gravado</param>
        /// <param name="key">Chave a ser gravada</param>
        /// <param name="value">Valor a ser gravado</param>
        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            tempData[key] = HelperJson.SerializarJSON(value);
        }

        /// <summary>
        /// Reguperar dados do TempData
        /// </summary>
        /// <typeparam name="T">Tipo de dados</typeparam>
        /// <param name="tempData">TempData a ser recuperado</param>
        /// <param name="key">Chave a ser recuperada</param>
        /// <returns></returns>
        public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            tempData.TryGetValue(key, out object o);
            return o == null ? null : HelperJson.DesserializarJSON<T>((string)o);
        }

        /// <summary>
        /// Revert a string ex: "ABCDE" para "EDCBA"
        /// </summary>
        /// <param name="s">string a ser revertida</param>
        /// <returns>string passada retornada como revertida</returns>
        public static string Reverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ObjectToString(this object valor)
        {
            if (valor != null)
            {
                return valor.ToString();
            }
            else
            {
                return "";
            }
        }

        public static int ObjectToInteger(this object valor)
        {
            if (valor != null)
            {
                int.TryParse(valor.ToString(), out int numero);
                return numero;
            }
            else
            {
                return 0;
            }
        }

        public static bool ObjectToCheck(this object valor)
        {
            if (valor != null)
            {
                if (valor.ToString() == "ok")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// REcebe object e retorna em string, caso null retorna ""
        /// </summary>
        /// <param name="valor">valor a ser tratado</param>
        /// <returns></returns>
        public static string TrataValorForString(this object valor, bool devolveStringZero = false)
        {
            if (valor != null)
            {
                if (valor?.GetType().FullName.ToString().ToLower().Contains("date") == true)
                {
                    var saida = Convert.ToDateTime(valor);

                    if (saida > DateTime.MinValue)
                    {
                        return saida.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        return "";
                    }
                }
                else if (valor?.GetType().FullName.ToString().ToLower().Contains("generic") == true)
                {
                    return string.Join(",", valor);
                }
                else
                {
                    var saida = valor.ToString();

                    if (!devolveStringZero)
                    {
                        return (saida != "0") ? saida : "";
                    }
                    else
                    {
                        return saida;
                    }
                }
            }
            else
            {
                if (valor?.GetType().FullName.ToString().ToLower().Contains("int") == true)
                {
                    return "0";
                }
                else if (valor?.GetType().FullName.ToString().ToLower().Contains("bool") == true)
                {
                    return "false";
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// Convert datetime em key integer
        /// </summary>
        /// <param name="data">data a ser convertida</param>
        /// <returns></returns>
        public static int DateTimeToIntKey(this DateTime data)
        {
            return Convert.ToInt32(data.ToString("yyyyMMdd"));
        }

        /// <summary>
        /// Convert int key in datetime
        /// </summary>
        /// <param name="data">data a ser tratada</param>
        /// <returns></returns>
        public static DateTime IntKeyToDateTime(this int data)
        {
            var dataTratada = data.ToString();

            var ano = dataTratada.Substring(0, 4);
            var mes = dataTratada.Substring(4, 2);
            var dia = dataTratada.Substring(6, 2);

            return Convert.ToDateTime($"{ano}-{mes}-{dia}");
        }

        /// <summary>
        /// Convert string key in datetime
        /// </summary>
        /// <param name="dataTratada">data a ser tratada</param>
        /// <returns></returns>
        public static DateTime StringKeyToDateTime(this string dataTratada)
        {
            var ano = dataTratada.Substring(0, 4);
            var mes = dataTratada.Substring(4, 2);
            var dia = dataTratada.Substring(6, 2);

            return Convert.ToDateTime($"{ano}-{mes}-{dia}");
        }

        /// <summary>
        /// Testa JSON se valido
        /// </summary>
        /// <param name="strJSon">String JSON</param>
        /// <returns>TRUE/FALSE</returns>
        public static bool ValidateJSON(this string strJSon)
        {
            if (string.IsNullOrEmpty(strJSon))
            {
                return false;
            }

            try
            {
                JToken.Parse(strJSon);
                JObject.Parse(strJSon);
                return true;
            }
            catch (Exception)
            {
                // Nao fazemos registro de log nesse ponto porque toda
                // vez que o string JSON for testado e não for um JSON
                // valido (objetivo da função) iria registrar um falso
                // log de erro.
                return false;
            }
        }
    }
}
