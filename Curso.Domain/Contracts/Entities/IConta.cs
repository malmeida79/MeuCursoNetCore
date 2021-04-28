namespace Curso.Domain.Contracts
{
    public interface IConta
    {
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
    }
}
