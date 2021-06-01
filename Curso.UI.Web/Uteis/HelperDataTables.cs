using Curso.Domain.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Curso.Domain.Containers;


namespace Curso.UI.Web.Uteis
{
    public static class HelperDataTables
    {
        /// <summary>
        /// Tratamento de retorno de dados e prevenção de erros
        /// </summary>
        /// <typeparam name="T">Tipo de Objeto do retorno</typeparam>
        /// <param name="request">Request da pagina</param>
        /// <param name="retorno">Retorno</param>
        /// <returns></returns>
        public static dynamic GetResponse<T>(DataTableAjaxPostModel dataTableModel, RequestResultModel<List<T>> retorno, List<string> camposFiltro = null, List<string> camposStatus = null, string DefaultStatus = "ativo") where T : class
        {
            int contagem = 0;
            dynamic response;
            try
            {
                // O split "-|-" sera enviado quando telas com filtro por status como projetos por exemplo
                var filtro = dataTableModel.Search.Value.TrataValorForString().ToLower().Trim().Split("-|-");

                if (retorno == null || retorno.Data == null)
                {
                    return new
                    {
                        Data = new List<T>(),
                        dataTableModel.Draw,
                        RecordsFiltered = contagem,
                        RecordsTotal = contagem
                    };
                }
                else
                {
                    List<T> lstElement = retorno.Data;

                    if (camposFiltro != null)
                    {
                        if (!string.IsNullOrEmpty(filtro[0]))
                        {
                            if (camposFiltro != null && camposFiltro.Count > 0)
                            {
                                lstElement = lstElement.Where(GetExpression<T>(camposFiltro, filtro[0]).Compile())?.ToList();
                            }
                        }
                    }

                    if (camposStatus != null)
                    {
                        if (filtro.Length > 1)
                        {
                            var pesquisa = filtro[1];
                            if (pesquisa != "" && pesquisa != "todos" && pesquisa != "undefined")
                            {
                                lstElement = lstElement.Where(GetExpression<T>(camposStatus, pesquisa, true).Compile())?.ToList();
                            }
                        }
                        else
                        {
                            // quando tela com filtro por status e nada foi selecionado no status mas tem um padrao, se não informado
                            // sera filtrado ativos.
                            lstElement = lstElement.Where(GetExpression<T>(camposStatus, DefaultStatus, true).Compile())?.ToList();
                        }
                    }

                    contagem = lstElement.Count();

                    response = new
                    {
                        Data = ProcessarDadosForm(lstElement, dataTableModel),
                        dataTableModel.Draw,
                        RecordsFiltered = contagem,
                        RecordsTotal = contagem
                    };
                }
            }
            catch (Exception)
            {
                // Segundo internet, e sites oficiais microsfot ao se mudar de página rapidamente antes
                // do async ser devolvido pode ocorrer o erro "The client has disconnected", não prejudicial 
                // uma vez que se mudou de página e o retorno não será mais necessário que pode ser tratado e 
                // ou previsto dessa forma ;

                response = new { };
            }
            return response;
        }

        public static List<T> ProcessarDadosForm<T>(List<T> lstElements, DataTableAjaxPostModel dataTableModel) where T : class
        {
            var skip = Convert.ToInt32(dataTableModel.Start.ToString());
            var pageSize = Convert.ToInt32(dataTableModel.Length.ToString());
            var columnIndex = dataTableModel.Order.FirstOrDefault().Column;
            var sortDirection = dataTableModel.Order.FirstOrDefault().Dir.ToString();
            var columName = dataTableModel.Columns[columnIndex].Data.ToString();

            if (pageSize > 0)
            {
                if (lstElements != null)
                {
                    var prop = GetProperty<T>(columName);
                    if (sortDirection == "asc")
                    {
                        return lstElements.OrderBy(prop.GetValue).Skip(skip)
                            .Take(pageSize).ToList();
                    }
                    else
                    {
                        return lstElements.OrderByDescending(prop.GetValue)
                            .Skip(skip).Take(pageSize).ToList();
                    }
                }
            }
            else
            {
                return lstElements;
            }

            return null;
        }

        #region Internos

        private static Expression<Func<T, bool>> GetExpression<T>(List<string> camposFiltro, string filtro, bool valorExato = false) where T : class
        {
            filtro = filtro.ToLower();

            var param = Expression.Parameter(typeof(T), "arg");

            List<Expression> expList = new List<Expression>();

            foreach (var campo in camposFiltro)
            {
                Expression clausule;
                Expression value;

                Expression name = Expression.PropertyOrField(param, campo);

                var type = name.Type;


                if (type.ToString().ToLower().Contains("string"))
                {
                    value = GetValueConstant(filtro, type);
                    MethodInfo toLower = typeof(string).GetMethod("ToLower", Type.EmptyTypes);
                    Expression expLower = Expression.Call(name, toLower);
                    if (!valorExato)
                    {
                        clausule = Expression.Call(expLower, type.GetMethod("Contains", new[] { type }), value);
                    }
                    else
                    {
                        clausule = Expression.Call(expLower, type.GetMethod("Equals", new[] { type }), value);
                    }
                }
                else
                {
                    try
                    {
                        value = GetValueConstant(filtro, type);
                        clausule = Expression.Equal(name, value);
                    }
                    catch (Exception)
                    {
                        continue;
                    }

                }

                expList.Add(clausule);
            }

            Expression exp = null;

            if (expList.Count > 0)
            {
                foreach (var e in expList)
                {
                    if (exp == null)
                        exp = e;
                    else
                        exp = Expression.Or(e, exp);
                }
            }

            if (exp != null)
            {
                return Expression.Lambda<Func<T, bool>>(exp, param);
            }
            else
            {
                exp = Expression.Equal(param, param);
                return Expression.Lambda<Func<T, bool>>(exp, param);
            }
        }

        private static Expression GetValueConstant(string itemValue, Type type)
        {
            Expression value;
            if (type.FullName.Contains("Guid"))
            {
                if (type.FullName.Contains("Nullable"))
                {
                    Guid? nullableGuid = new Guid(itemValue);
                    value = Expression.Constant(nullableGuid, typeof(Guid?));
                }
                else
                {
                    value = Expression.Constant(new Guid(itemValue));
                }
            }
            else if (type.FullName.Contains("Boolean"))
            {
                if (type.FullName.Contains("Nullable"))
                {
                    bool? nullableBool = (itemValue == "true");
                    value = Expression.Constant(nullableBool, typeof(bool?));
                }
                else
                {
                    value = Expression.Constant((itemValue == "true"));
                }
            }
            else if (type.FullName.Contains("Int32"))
            {
                if (type.FullName.Contains("Nullable"))
                {
                    int? nullableInt = Convert.ToInt32(itemValue);
                    value = Expression.Constant(nullableInt, typeof(int?));
                }
                else
                {
                    value = Expression.Constant(Convert.ToInt32(itemValue));
                }
            }
            else if (type.FullName.Contains("Int64"))
            {
                if (type.FullName.Contains("Nullable"))
                {
                    long? nullableLong = Convert.ToInt64(itemValue);
                    value = Expression.Constant(nullableLong, typeof(long?));
                }
                else
                {
                    value = Expression.Constant(Convert.ToInt64(itemValue));
                }
            }
            else if (type.FullName.Contains("Decimal"))
            {
                if (type.FullName.Contains("Nullable"))
                {
                    decimal? nullableDecimal = Convert.ToDecimal(itemValue.Replace(",", "."), new CultureInfo("en-US"));
                    value = Expression.Constant(nullableDecimal, typeof(decimal?));
                }
                else
                {
                    value = Expression.Constant(Convert.ToDecimal(itemValue.Replace(",", "."), new CultureInfo("en-US")));
                }
            }
            else if (type.FullName.Contains("DateTime"))
            {
                try
                {

                    if (type.FullName.Contains("Nullable"))
                    {
                        DateTime.TryParse(itemValue, out DateTime date);
                        DateTime? nullableDate = date;
                        value = Expression.Constant(nullableDate, typeof(DateTime?));
                    }
                    else
                    {
                        DateTime.TryParse(itemValue, out DateTime date);
                        value = Expression.Constant(date);
                    }


                }
                catch (Exception)
                {
                    throw new InvalidOperationException("Invalid datetime value");
                }
            }
            else if (type.GetTypeInfo().IsEnum)
            {
                var enumValue = Enum.ToObject(type, Convert.ToInt32(itemValue));
                value = Expression.Constant(enumValue);
            }
            else
            {
                itemValue = itemValue ?? string.Empty;
                value = Expression.Constant(Convert.ChangeType(itemValue.ToLower(), type));
            }

            return value;
        }

        private static PropertyInfo GetProperty<T>(string name)
        {
            var properties = typeof(T).GetProperties();
            PropertyInfo prop = null;
            foreach (var item in properties)
            {
                if (item.Name.ToLower().Equals(name.ToLower()))
                {
                    prop = item;
                    break;
                }
            }
            return prop;
        }

        #endregion
    }
}
