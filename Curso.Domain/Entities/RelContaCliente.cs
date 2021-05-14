using Curso.Domain.Entities.Base;
using System;

namespace Curso.Domain.Entities
{
    public class RelContaCliente : BaseEntity
    {
        public int CodBanco { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataAbertura { get; set; }
        public string NomeBanco { get; set; }
    }
}
