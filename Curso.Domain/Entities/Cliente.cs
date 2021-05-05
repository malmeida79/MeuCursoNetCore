using Curso.Domain.Entities.Base;

namespace Curso.Domain.Entities
{
    public class Cliente: BaseEntity
    {
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
    }
}
