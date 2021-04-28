using Curso.Domain.Entities.Base;

namespace Curso.Domain.Entities
{
    public class Banco: BaseEntity
    {
        public int CodBanco { get; set; }
        public string NomeBanco { get; set; }
        public string NumeroBanco { get; set; }
    }
}
