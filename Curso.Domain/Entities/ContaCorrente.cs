using Curso.Domain.Entities.Base;
using System;

namespace Curso.Domain.Entities
{
    public class ContaCorrente : BaseEntity
    {
        public string NumeroConta { get; set; }
        public string NumeroAgencia { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public int CodBanco { get; set; }
        public int CodContaCorrente { get; set; }
        public DateTime DataAbertura { get; set; }
        public Banco Banco { get; set; }
    }
}
