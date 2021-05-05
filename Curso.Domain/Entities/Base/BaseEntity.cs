using System;

namespace Curso.Domain.Entities.Base
{
    public class BaseEntity
    {
        public DateTime? DataAlteracao { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
