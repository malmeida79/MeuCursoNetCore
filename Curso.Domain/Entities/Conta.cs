using Curso.Domain.Contracts;

namespace Curso.Domain.Entities
{
    public abstract class Conta :Banco, IConta
    {
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }

        // Nesse metodo, usar a palavra virtual para permitir que o mesmo
        // sofra "override" e seja alterado na classe que esta fazendo
        // herança dela. Não usar virtual bloqueia o metodo para alterações.
        public virtual string CadastraConta()
        {
            return "Orginal";
        }
    }
}
