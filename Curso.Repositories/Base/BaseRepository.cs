using Curso.Domain.Contracts.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Repositories.Base
{
    public class BaseRepository<T> : IBaseReposiory<T> where T : class
    {
    }
}
