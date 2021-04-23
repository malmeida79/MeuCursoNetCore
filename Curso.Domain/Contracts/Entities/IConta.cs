namespace Curso.Domain.Contracts
{
    public interface IConta
    {
        public string NomeBanco { get; set; }
        public int NumeroBanco { get; set; }
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
    }
}
