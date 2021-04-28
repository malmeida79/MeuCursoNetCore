using Curso.Domain.Entities.Base;

namespace Curso.Domain.Entities
{
    public class TipoConta : BaseEntity
    {
        public int CodTipoConta { get; set; }
        public string NomeTipoConta { get; set; }
    }
}
