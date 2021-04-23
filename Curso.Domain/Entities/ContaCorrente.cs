using Curso.Domain.Contracts;
using Curso.Domain.Enuns;
using System;

namespace Curso.Domain.Entities
{
    public class ContaCorrente: Conta, IConta
    {
        private string _nome;
        private int _numero;

        // construtor sem exigencia de valores
        public ContaCorrente()
        {

        }

        // construtor com exigencia de valores (sobrecarga)
        public ContaCorrente(string nomeBanco, int numeroBanco)
        {
            _nome = nomeBanco;
            _numero = numeroBanco;
        }

        public EnumTipoConta TipoConta { get; set; }
        public DateTime DataAbertura { get; set; }

        // fazendo override para mudar o metodo que esta sendo herdado.
        public override string CadastraConta()
        {
            // se nao vazio ou nulo, usar o valor
            if (!string.IsNullOrEmpty(_nome))
            {
                return _nome;
            }
            else
            {
                return "Sem nome de banco";
            }
        }
    }
}
