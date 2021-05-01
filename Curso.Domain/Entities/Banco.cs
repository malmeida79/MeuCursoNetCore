using Curso.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curso.Domain.Entities
{
    public class Banco : BaseEntity
    {
        public int CodBanco { get; set; }
        public string NomeBanco { get; set; }
        public string NumeroBanco { get; set; }
    }
}
