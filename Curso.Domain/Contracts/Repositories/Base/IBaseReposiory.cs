using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Domain.Contracts.Repositories.Base
{
    public interface IBaseReposiory<T> where T :class
    {
        public void Add(T entity) { 
        }

        public void Update(T entity)
        {
        }

        public void Delete(int ID)
        {

        }
    }
}
