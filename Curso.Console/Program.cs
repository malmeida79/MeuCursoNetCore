using Primeiro.Controllers;
using Curso.Domain.Entities;
using Curso.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Area ContaCorrente

            // criando as contas (instanciando as contas)
            AcoesController acao = new AcoesController();

            ContaInvestimento ccInvest = new ContaInvestimento();
            ccInvest.Chave = "xhyj-yut-123-pou";
            ccInvest.Saldo = 3000;
            ccInvest.TaxaAdm = 2;


            //  instanciando classe fazendo uso do construtor
            ContaCorrente ccCliente = new ContaCorrente();
            ccCliente.NumeroConta = "12345";
            ccCliente.NumeroAgencia = "43";
            ccCliente.Saldo = 100;
            ccCliente.Limite = 350;
            ccCliente.TipoConta = EnumTipoConta.Conjunta;

            // simplesmente instanciando classes com construtor simples
            ContaCorrente conta = new ContaCorrente();
            conta.NumeroConta = "56789";
            conta.NumeroAgencia = "86";
            conta.Saldo = 300;
            conta.Limite = 200;
            conta.TipoConta = EnumTipoConta.Digital;

            acao.Saque(ref ccInvest, 300);

            // depoisto de 20 em uma conta
            acao.Deposito(ref conta, 20);

            try
            {
                // forçado erro de divisao por zero para demosntrar o try/catch
                var numero = 0;
                var divisao = 100 / numero;
            }
            catch (Exception ex)
            {
                // capturando o erro
                var erro = ex;

                // gerando uma excessao e parando o programa (remover comentarios abaixo)
                // throw new Exception("Ocorreu uma falha, chame o adm.");

                // apresentando a mensagem para o usuario
                Console.WriteLine("Ocorreu uma falha, chame o adm [0005].");

                // caso queira parar o programa apos o erro, remover os 
                // comentarios abaixo
                // return;
            }

            // depositei 500
            acao.Deposito(ref ccCliente, 500);

            // tentei sacar de novo
            var outracoisa = acao.Saque(ref ccCliente, 700);

            // passagem de parametro por referencia alterando a conta
            // que esta fora do metodo
            acao.Transferencia(200, ref conta, ref ccCliente);

            // metodo com parametro opcional codigo de barras
            // fornece se tiver.
            acao.Pagamento(ref conta, 50);

            // utilizando enuns
            acao.Pix(ref conta, 100, EnumTipoPix.Pagamento, EnumChavePix.Cpf);

            // saldo atual
            var saldo = ccCliente.Saldo;

            // imprimindo n tela
            Console.WriteLine($"Saldo da conta:{ccCliente.NumeroConta} é {ccCliente.Saldo}");
            Console.WriteLine($"Saldo da conta:{conta.NumeroConta} é {conta.Saldo}");

            #endregion

            #region Area Listas Simples

            // declarando a lista
            var nomes = new List<string>();

            // adicionando itens na lista
            nomes.Add("Marcos");
            nomes.Add("Matheus");
            nomes.Add("Mary");
            nomes.Add("Jhonny");

            // segue apenas se tivermos nomes na lista
            if (nomes.Count > 0)
            {
                // para cada item da colçao nomes faça ...
                foreach (var item in nomes)
                {
                    Console.WriteLine($"O nome é: {item}.");
                }

                Console.WriteLine($"Temos:{nomes.Count} nomes na lista");
            }
            else
            {
                Console.WriteLine("Nomes nao carregados.");
            }

            // buscando todos os nomes que contenham a letra m
            // usando tolower para q todos os nomes sejam convertidos 
            // para minuscula senao teriamos q fazer dois contains
            // um para o maiusculo e outro para o minusculo.
            var pesquisa = nomes.Where(x => x.ToLower().Contains("m"));

            // executa um looping uma vez para cada item da pesquisa
            foreach (var item in pesquisa)
            {
                Console.WriteLine($"O nome é: {item}.");
            }

            // se algo retornou da pesquisa, segue
            if (pesquisa != null && pesquisa.Count() > 0)
            {
                // imprimindo o primeiro item da lista e o ultimo
                Console.WriteLine($"O nome é: {pesquisa.FirstOrDefault()}.");
                Console.WriteLine($"O nome é: {pesquisa.LastOrDefault()}.");
            }

            #endregion

            #region Area de Listas complexas

            var bc = new List<Banco>();

            var bc1 = new Banco();
            bc1.CodBanco = 1;
            bc1.NomeBanco = "Banco do Brasil";

            var bc2 = new Banco();
            bc2.CodBanco = 341;
            bc2.NomeBanco = "Itau";

            var bc3 = new Banco();
            bc3.CodBanco = 237;
            bc3.NomeBanco = "Banco Bradesco";

            bc.Add(bc1);
            bc.Add(bc2);
            bc.Add(bc3);

            var buscaItau = bc.Where(x => x.NomeBanco.ToLower().Contains("itau"));
            var buscaBB = bc.Where(x => x.CodBanco == 1);

            #endregion
        }
    }
}
