using Curso.Domain.Contracts;

namespace Curso.Domain.Entities
{
    public class ContaInvestimento : Conta, IConta
    {
        public string Chave { get; set; }
        public decimal TaxaAdm { get; set; }

        // obs: Nesse metodo não fizemos override do metodo
        // CadastraConta então ao ser chamado ele seguira com
        // seu comportamento normal e original.
    }
}
