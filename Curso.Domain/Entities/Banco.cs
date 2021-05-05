using Curso.Domain.Entities.Base;
using System.Collections.Generic;

namespace Curso.Domain.Entities
{
    public class Banco : BaseEntity
    {
        public virtual int CodBanco { get; set; }
        public string NomeBanco { get; set; }
        public string NumeroBanco { get; set; }
        public ICollection<ContaCorrente> Contas { get; set; }
    }
}
