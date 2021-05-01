using Curso.Domain.Contracts.Repositories.Base;
using Curso.Infra.Repositories.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Curso.Infra.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseReposiory<TEntity> where TEntity : class
    {
        protected readonly BancosContext _dbContext;

        public BaseRepository(BancosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BaseRepository()
        {
            _dbContext = new BancosContext();
        }

        public TEntity Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            _dbContext.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
            _dbContext.SaveChanges();
            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Detached;
            }
            return entities;
        }

        public IEnumerable<TEntity> UpdateRange(List<TEntity> entities)
        {
            _dbContext.Set<TEntity>().UpdateRange(entities);
            _dbContext.SaveChanges();
            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Detached;
            }
            return entities;
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void DeleteRange(List<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
            _dbContext.SaveChanges();
            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Detached;
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext.Set<TEntity>().Where(predicado).AsEnumerable();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(predicado);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return _dbContext.Set<TEntity>().Where(predicate);
            }

            return _dbContext.Set<TEntity>().AsEnumerable();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate = null)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(predicate);
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            _dbContext.Entry(entity).State = EntityState.Detached;
        }

        ///// <summary>
        ///// Registra acoes
        ///// </summary>
        ///// <param name = "log" > Log de acao a ser registrado</param>
        ////public void SaveLogAcao(LogAcao log)
        ////{
        ////    _dbContext.Set<LogAcao>().Add(log);
        ////    _dbContext.Entry(log).State = EntityState.Added;
        ////    _dbContext.SaveChanges();
        ////}

        ///// <summary>
        ///// Registra Erros
        ///// </summary>
        ///// <param name = "log" > De erros a ser registrado</param>
        ////public void SaveLogErro(LogErro log)
        ////{
        ////    _dbContext.Set<LogErro>().Add(log);
        ////    _dbContext.Entry(log).State = EntityState.Added;
        ////    _dbContext.SaveChanges();
        ////}
    }
}
