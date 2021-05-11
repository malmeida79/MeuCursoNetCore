using Curso.Domain.Entities;
using Curso.Domain.Enuns;

namespace Primeiro.Controllers
{
    public class AcoesController
    {
        public bool Deposito(ref ContaCorrente conta, decimal valor)
        {
            conta.Saldo += valor;
            return true;
        }

        public bool Saque(ref ContaCorrente conta, decimal valor)
        {
            bool retorno = false;

            if (ConsultaSaldo(conta, valor) == true)
            {
                conta.Saldo -= valor;
                retorno = true;
            }

            return retorno;
        }

        public bool Saque(ref ContaInvestimento conta, decimal valor)
        {
            bool retorno = false;

            if (ConsultaSaldo(conta, valor) == true)
            {
                conta.Saldo -= valor;
                retorno = true;
            }

            return retorno;
        }

        public bool Transferencia(decimal valor, ref ContaCorrente contaOrigem, ref ContaCorrente contaDestino)
        {
            bool retorno = false;

            if (ConsultaSaldo(contaOrigem, valor))
            {
                contaDestino.Saldo += valor;
                contaOrigem.Saldo -= valor;
                retorno = true;
            }

            return retorno;
        }

        public bool Pagamento(ref ContaCorrente conta, decimal valor, string codigoBarras = "")
        {
            bool retorno = false;

            if (ConsultaSaldo(conta, valor))
            {
                conta.Saldo -= valor;
                retorno = true;
            }

            return retorno;
        }

        public bool Pix(ref ContaCorrente conta, decimal valor, EnumTipoPix tipoOperacao)
        {
            bool retorno = false;

            if (ConsultaSaldo(conta, valor))
            {
                if (tipoOperacao == EnumTipoPix.Saque)
                {
                    conta.Saldo -= valor;
                }

                if (tipoOperacao == EnumTipoPix.Deposito)
                {
                    conta.Saldo += valor;
                }

                if (tipoOperacao == EnumTipoPix.Pagamento)
                {
                    conta.Saldo -= valor;
                }

                if (tipoOperacao == EnumTipoPix.Transferencia)
                {
                    // Saldo -= valor;
                }

            }

            return retorno;
        }

        private bool ConsultaSaldo(ContaCorrente conta, decimal valor)
        {
            bool retorno = false;

            decimal saldoTotal = conta.Saldo + conta.Limite;

            if (valor <= saldoTotal)
            {
                retorno = true;
            }

            return retorno;
        }

        private bool ConsultaSaldo(ContaInvestimento conta, decimal valor)
        {
            bool retorno = false;

            decimal saldoTotal = conta.Saldo;

            if (valor <= saldoTotal)
            {
                retorno = true;
            }

            return retorno;
        }

        private void EnviarAlerta()
        {

        }

    }
}
