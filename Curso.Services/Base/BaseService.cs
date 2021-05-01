using Curso.Domain.Contracts.Repositories.Base;
using Curso.Domain.Contracts.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Curso.Services.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseReposiory<T> _repository;

        public BaseService(IBaseReposiory<T> repository)
        {
            _repository = repository;
        }

        public T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            return _repository.AddRange(entities);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public void DeleteRange(List<T> entity)
        {
            _repository.DeleteRange(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicado)
        {
            return _repository.Find(predicado);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicado)
        {
            return _repository.FirstOrDefault(predicado);
        }

        public T Get(Expression<Func<T, bool>> predicate = null)
        {
            return _repository.Get(predicate);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return _repository.GetAll(predicate);
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public IEnumerable<T> UpdateRange(List<T> entities)
        {
            return _repository.UpdateRange(entities);
        }
    }
}
