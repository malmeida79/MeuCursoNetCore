using Curso.Domain.Contracts.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Services.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {

    }
}
