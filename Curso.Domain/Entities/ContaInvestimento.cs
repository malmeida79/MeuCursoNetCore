using Curso.Domain.Entities.Base;

namespace Curso.Domain.Entities
{
    public class ContaInvestimento : BaseEntity
    {
        public string NumeroConta { get; set; }
        public string NumeroAgencia { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public int CodContaInvestimento { get; set; }
        public string Chave { get; set; }
        public decimal TaxaAdm { get; set; }
        public int CodBanco { get; set; }
    }
}
