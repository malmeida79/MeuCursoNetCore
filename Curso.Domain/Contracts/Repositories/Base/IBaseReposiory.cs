using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Curso.Domain.Contracts.Repositories.Base
{
    public interface IBaseReposiory<TEntity> where TEntity : class
    {
        #region actions
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        #endregion

        #region Ranges

        IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);
        IEnumerable<TEntity> UpdateRange(List<TEntity> entity);
        void DeleteRange(List<TEntity> entity);

        #endregion

        #region Getter's

        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null);
        TEntity Get(Expression<Func<TEntity, bool>> predicate = null);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicado);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicado);

        #endregion
    }
}
