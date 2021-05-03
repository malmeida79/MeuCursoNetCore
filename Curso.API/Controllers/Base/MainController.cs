using Curso.Domain.Contracts.Services.Base;
using Curso.Domain.Entities.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.API.Controllers.Base
{
    public abstract class MainController : Controller
    {

    }

    public abstract class MainController<TEntity, TService> : Controller
     where TEntity : BaseEntity
     where TService : class, IBaseService<TEntity>
    {
        protected readonly TService _service;

        protected MainController(IServiceProvider provider)
        {
            _service = (TService)provider.GetService(typeof(TService));
        }

        [AllowAnonymous]
        [HttpGet]
        public virtual IActionResult GetAll()
        {
            try
            {
                var entity = _service.GetAll();

                if (entity == null)
                {
                    return Ok("Dados não localizados.");
                }
                else
                {
                    return Ok(entity);
                }

            }
            catch (Exception ex)
            {
                return Ok($"ocorreu erro:{ex.Message}");
            }
        }

        [AllowAnonymous]
        [HttpGet("{codigo}")]
        public virtual IActionResult GetByCod(int codigo)
        {
            try
            {
                var entity = _service.GetById(codigo);

                if (entity == null)
                {
                    return Ok("Dados não localizados.");
                }
                else
                {
                    return Ok(entity);
                }

            }
            catch (Exception ex)
            {
                return Ok($"ocorreu erro:{ex.Message}");
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public virtual IActionResult Post([FromBody] TEntity model)
        {
            try
            {
                var entity = _service.Add(model);

                if (entity == null)
                {
                    return Ok("Dados não localizados.");
                }
                else
                {
                    return Ok(entity);
                }

            }
            catch (Exception ex)
            {
                return Ok($"ocorreu erro:{ex.Message}");
            }
        }

        [AllowAnonymous]
        [HttpPut]
        public virtual IActionResult Put([FromBody] TEntity model)
        {
            try
            {
                _service.Update(model);
                return Ok("Dados atualizados com sucesso!.");
            }
            catch (Exception ex)
            {
                return Ok($"ocorreu erro:{ex.Message}");
            }
        }

        [AllowAnonymous]
        [HttpDelete("{codigo}")]
        public virtual IActionResult Delete(int codigo)
        {
            try
            {
                var entity = _service.GetById(codigo);

                if (entity == null)
                {
                    return Ok("Dados não localizados para excluir.");
                }

                _service.Delete(entity);
                return Ok("Dados excluidos com sucesso!");

            }
            catch (Exception ex)
            {
                return Ok($"ocorreu erro:{ex.Message}");
            }
        }

    }
}
