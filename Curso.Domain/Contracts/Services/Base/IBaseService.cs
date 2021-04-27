using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Domain.Contracts.Services.Base
{
    public interface IBaseService<T> where T : class
    {
        public void Add(T entity)
        {
        }

        public void Update(T entity)
        {
        }

        public void Delete(int ID)
        {

        }
    }
}
