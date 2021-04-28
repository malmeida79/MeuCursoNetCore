using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Domain.Entities.Base
{
    public class BaseEntity
    {
        public DateTime DataAlteracao { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
